using DB_in_C_.Models;
using System.Linq;
class Program
{
    public static void Main(string[] args)
    {
        var categories = new List<Category>
        {
            new Category(1, "Books"),
            new Category(2, "Electronics"),
            new Category(3, "Clothing"),
            new Category(4, "Home & Kitchen"),
            new Category(5, "Toys")
        };

        var products = new List<Product>
        {
            new Product(1, "C# Programming Book", 29.99, 1),
            new Product(2, "JavaScript for Beginners", 24.99, 1),
            new Product(3, "Blender", 59.99, 4),
            new Product(4, "Smartphone", 499.99, 2),
            new Product(5, "Laptop", 999.99, 2),
            new Product(6, "Tablet", 199.99, 2),
            new Product(7, "T-Shirt", 14.99, 3),
            new Product(8, "Jeans", 39.99, 3),
            new Product(9, "Jacket", 89.99, 3),
            new Product(10, "Lego Set", 89.99, 5),
            new Product(11, "Action Figure", 19.99, 5),
            new Product(12, "Cooking Pot", 34.99, 4),
            new Product(13, "Electric Kettle", 24.99, 4),
            new Product(14, "Data Structures Book", 34.99, 1),
            new Product(15, "Monitor", 149.99, 2),
            new Product(16, "Keyboard", 49.99, 2),
            new Product(17, "Microwave", 99.99, 4)
        };

        var sections = new List<Marketing>
        {
            new Marketing(1, "Holiday Sale"),
            new Marketing(2, "Buy One Get One"),
            new Marketing(3, "Summer Clearance"),
            new Marketing(4, "New Arrivals Launch"),
            new Marketing(5, "Back to School Promo")
        };

        var employees = new List<Employee>
        {
            new Employee(1, "Alice Johnson", 55000m, 1),
            new Employee(2, "Bob Smith", 62000m, 2),
            new Employee(3, "Catherine Lee", 58000m, 1),
            new Employee(4, "David Brown", 70000m, 3),
            new Employee(5, "Eva Green", 64000m, 2),
            new Employee(6, "Frank Moore", 75000m, 4),
            new Employee(7, "Grace Hall", 53000m, 1),
            new Employee(8, "Henry Scott", 60000m, 3),
            new Employee(9, "Isabella Adams", 72000m, 4),
            new Employee(10, "Jack Turner", 50000m, 2)
        };

        var users = new List<User>
        {
            new User(1, "Anna"),
            new User(2, "Brian"),
            new User(3, "Carla"),
            new User(4, "Derek"),
            new User(5, "Emily")
        };
        var orders = new List<Order>
        {
            new Order(1, 1, OrderStatus.Pending),
            new Order(2, 4, OrderStatus.Deliveried),
            new Order(3, 2, OrderStatus.OnTheWay),
            new Order(4, 3, OrderStatus.Deliveried),
            new Order(5, 4, OrderStatus.Pending),
            new Order(6, 3, OrderStatus.OnTheWay),
            new Order(7, 4, OrderStatus.PaymentRejected),
            new Order(8, 3, OrderStatus.Deliveried)
        };

        var orderDetails = new List<OrderDetails>
        {
            new OrderDetails(1, 1, 1, 1),    // User 1
            new OrderDetails(2, 1, 1, 2),    // User 1
            new OrderDetails(3, 2, 3, 1),    // User 1
            new OrderDetails(4, 3, 4, 1),    // User 2
            new OrderDetails(5, 4, 5, 1),    // User 3
            new OrderDetails(6, 5, 6, 2),    // User 3
            new OrderDetails(7, 5, 7, 1),    // User 3
            new OrderDetails(8, 6, 8, 3),    // User 3
            new OrderDetails(9, 7, 9, 1),    // User 4
            new OrderDetails(10, 8, 10, 1),  // User 5
            new OrderDetails(11, 2, 11, 2),  // User 1
            new OrderDetails(12, 5, 12, 1),  // User 3
            new OrderDetails(13, 6, 13, 1),  // User 3
            new OrderDetails(14, 6, 14, 2),  // User 3
            new OrderDetails(15, 6, 15, 1)   // User 3
        };


        var result = (from e in employees
                      where e.sectionId == (
                        from item in employees
                        group item by item.sectionId into g
                        let sum = g.Sum(s => s.Salary)
                        orderby sum descending
                        select new
                        {
                            department = g.Key,
                            total = sum
                        }
                    ).First().department
                      select e.Name
                );

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("User who has order");
        //  Գտնել այն user - ներին, որոնք գոնե մեկ պատվեր արել են(հուշում join-ը,
        //  արդեն իսկ ներառում է միայն պատվեր արածներին)
        var userWIthOrders = (from user in users
                              join order in orders on user.Id equals order.userId
                              select user.Name).Distinct();
        foreach (var item in userWIthOrders)
        {
            Console.WriteLine(item);
        }
        //2.Տպել յուրաքանչյուր աշխատակցի անունը և department-ի անունը, որտեղ աշխատում են
        var sectionName = from emp in employees
                          join sec in sections on emp.sectionId equals sec.Id
                          select new
                          {
                              name = emp.Name,
                              department = sec.Name
                          };
        foreach (var item in sectionName)
        {
            Console.WriteLine($"{item.name}     From       {item.department}");
        }
        // Այն ապրանքները, որոնք որևէ պատվերի մեջ եղել են ավելի քան 2 հատ քանակով
        Console.WriteLine();
        Console.WriteLine("More Than two");
        var moreThanTwo = from prod in products
                          join ord in orderDetails on prod.Id equals ord.productId
                          where ord.count >= 2
                          select prod.Name;
        foreach (var item in moreThanTwo)
        {
            Console.WriteLine($"{item}");
        }
        //Յուրաքանչյուր user-ի համար ցույց տալ նրա կատարած պատվերների քանակը
        var countOfOrders = from user in users
                            join order in orders on user.Id equals order.userId
                            group order by order.userId into g2
                            select new
                            {
                                id = g2.Key,
                                count = g2.Count(),
                            };
        Console.WriteLine();
        Console.WriteLine("Count of orders each user");
        foreach (var item in countOfOrders)
        {
            Console.WriteLine($"{item.id} {item.count}");
        }
        //Գտնել ամենաշատ պատվերներ արած մարդու անունը
        Console.WriteLine();
        Console.WriteLine("Amenashat patver arac usery");
        var userWithmaxOrder = users.Where(u => u.Id == countOfOrders.OrderByDescending(e => e.count).
        First().id).Select(u => u.Name);
        //  Console.WriteLine($"{userWithmaxOrder}");
        foreach (var item in userWithmaxOrder)
        {
            Console.WriteLine($"{item}");
        }
        //Xia vor forov enq menak karum tpenq inqy 1 hat string chi?

        //Գտնել ամենաթանկ պատվերը կատարած userին
        var expOrd = (from prod in products
                      join ord in orderDetails on prod.Id equals ord.productId
                      join or in orders on ord.orderId equals or.Id
                      join user in users on or.userId equals user.Id
                      orderby prod.Price * ord.count descending
                      select user.Name).First();
        Console.WriteLine($"{expOrd}");
        //3 ամենահաճախ պատվիրված ապրանքները
        var tri = (from prod in products
                   join ord in orderDetails on prod.Id equals ord.productId
                   orderby ord.count descending
                   select prod.Name).Take(3);
        foreach (var item in tri)
        {
            Console.WriteLine($"{item}");
        }
        //Ապրանքներ, որոնք երբևէ չեն պատվիրվել (կարող եք օգտվել Any մեթոդից)
        var notOrder = from prod in products
                       where
                       !(from ord in orderDetails
                         select ord.productId).Contains(prod.Id)
                       select prod.Name;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        //Console.WriteLine($"{notOrder}");
        //Console.WriteLine($"{notOrder}");
        foreach (var item in notOrder)
        {
            Console.WriteLine($"{item}");
        }
        //Յուրաքանչյուր userի անունը և իր ծախսած ընդհանուր գումարը պատվերներում
        var listUs = from prod in products
                     join ord in orderDetails on prod.Id equals ord.productId
                     join or in orders on ord.orderId equals or.Id
                     join user in users on or.userId equals user.Id
                     group new { user, prod, ord } by user into g
                     select new
                     {
                         total = g.Sum(x=>x.prod.Price * x.ord.count),
                         name = g.Key.Name,
                     };
        //var esim = from us in users

        //           select new
        //           {
        //               sumtot = (from l in listUs
        //                         where l.id == us.Id
        //                         select l.total).Sum(l => l),
        //               name = us.Name,
        //           };
        Console.WriteLine();
        foreach (var item in listUs)
        {
            Console.WriteLine($"Name: {item.name} Total:{item.total}");
        }
    }
}
