using System;

namespace Shop
{
    public class Shop
    {
        public string? Name { get; set; }
        public int _discount;
        public int Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                if (_discount!=value)
                {
                    OnDiscountChanged(_discount,value);
                }
                _discount = value;
            }
        }
        public event EventHandler<DiscountChangedEventArgs>? DiscountChanged;
        public virtual void OnDiscountChanged(int oldDiscount,int newDiscount)
        {

            DiscountChanged?.Invoke(this,new DiscountChangedEventArgs(oldDiscount, newDiscount));
        }

    }

    public class DiscountChangedEventArgs:EventArgs
    {
        public int OldDiscount { get; set; }
        public int NewDiscount { get; set; }
        public DiscountChangedEventArgs(int oldDiscount, int newDiscount)
        {
            OldDiscount = oldDiscount;
            NewDiscount = newDiscount;
        }
    }
    public class Subscriber
    {
        public void HandleEvent(object sender, DiscountChangedEventArgs e)
        {
            Console.WriteLine($"Price up: from{e.OldDiscount} until {e.NewDiscount}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Subscriber sub = new();
            shop.DiscountChanged += sub.HandleEvent;
            shop.Discount = 10;
            shop.Discount = 20;


        }
    }
}
