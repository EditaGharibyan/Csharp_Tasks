namespace Book_Library
{
    public class Book
    {
        public string Title;
        public string Author;
        public bool isAvailable;
        public Book()
        {
            Title = "The Little Prince";
            Author = "Antoine de Saint-Exupéry,";
            isAvailable = true;
        }

        public void BorrowBook()
        {
            if (isAvailable == true)
            {
                Console.WriteLine("The book is borrowed");
                isAvailable = false;
            }
            else
            {
                Console.WriteLine("You cant borrow this Book");
            }
        }
        public void ReturnBook()
        {
            isAvailable = true;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Book[] books = new Book[3];
            for (int i=0;i<books.Length; i++)
            {
                books[i] = new Book();
                books[i].Title = Console.ReadLine();
                books[i].Author = Console.ReadLine();
                books[i].isAvailable = bool.Parse(Console.ReadLine());

            }
           // books[0].BorrowBook();
           // Console.WriteLine($"{books[0].isAvailable}");
            Console.WriteLine("What you want doing\n1.borrow \n2.return \n3.end(for ending)");
            string choose =Console.ReadLine();
            while (choose!="end")
            {
                Console.WriteLine("Enter title of this book");
                string MyTitle = Console.ReadLine();
                if (choose == "1")
                {

                    foreach (Book item in books)
                    {
                        if (item.Title == MyTitle)
                        {
                            item.BorrowBook();
                        }


                    }
                }
                else if (choose == "2")
                {
                    foreach (Book item in books)
                    {
                        if (item.Title == MyTitle)
                        {
                            item.ReturnBook();
                        }

                    }
                }
                else
                {
                    Console.WriteLine("invalid choice");
                }


                choose = Console.ReadLine();

            }
            

        }
    }
}
