namespace ShapeClass
{
    public abstract class Shape
    {
        public abstract double Surface();
        public abstract void draw();
        public virtual void Print() { }
    }
    public class Square : Shape
    {
        private int side;
        public Square(int a)
        {
            Side = a;
        }
        public int Side
        {
            set
            {
                if (value > 0)
                {
                    side = value;

                }
            }
            get
            {
                return side;
            }
        }
        public override void Print()
        {
            
            Console.WriteLine($" {this.GetType()}  {this.Surface()}");
            this.draw();
        }
        public override double Surface()
        {
            return side * side;
        }
        public override void draw()
        {
            Console.WriteLine("I`m draw Square");
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write("+"+" ");
                }
                Console.WriteLine();
            }
        }
    }
    public class Rectangle:Shape
    {
        private int height;
        private int weight;
        public Rectangle(int a,int b)
        {
            this.Height = a;
            this.Weight = b;
        }
        public int Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
            }
            get
            {
                return height;
            }
        }
        public int Weight
        {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
            get
            {
                return weight;
            }
        }
        public override double Surface()
        {
            return height * weight;
        }
        public override void Print()
        {
            Console.WriteLine($" {this.GetType()}  {this.Surface()}");
            this.draw();
        }
        public override void draw()
        {
            Console.WriteLine("I`m draw Rectangle");
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < weight; j++)
                {
                    Console.Write("+"+" ");
                }
                Console.WriteLine();
            }
        }
    }

    internal class SHape
    {
        static void Main(string[] args)
        {
            Shape[] shape = { new Rectangle(5, 3), new Square(4), new Rectangle(3, 2) };
            foreach (var item in shape)
            {
                item.Print();
            }

        }
    }
}
