using System;
using System.Collections.Generic;

namespace MyListGen
{
    public interface IWriteBox<in T>
    {
        void Add(T item);
    }

    public interface IReadBox<out T>
    {
        public T this[int index] { get; }
    }

    public class MyList<T> : IReadBox<T>, IWriteBox<T>
    {
        List<T> _myList = new();
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < _myList.Count)
                {
                    return _myList[index];
                }
                return default(T);
            }
        }

        public void Add(T item)
        {
            _myList.Add(item);
        }
    }

    public class Account
    {
        public virtual void Speak() => Console.WriteLine("This is Account");
    }

    public class Admin : Account
    {
        public override void Speak() => Console.WriteLine("I am admin");
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IReadBox<Admin> adminBox = new MyList<Admin>();
            TestReadBox(adminBox);
            IWriteBox<Account> accountBox = new MyList<Account>();
            TestWriteBox(accountBox);
        }

        static void TestReadBox(IReadBox<Account> account)
        {
            Console.WriteLine("Testing IReadBox<Account>");
            Account acc = account[0];
            if (acc != null)
                acc.Speak();
            else
                Console.WriteLine("Box is empty or null");
        }

        static void TestWriteBox(IWriteBox<Admin> admin)
        {
            Console.WriteLine("Testing IWriteBox<Admin>");
            admin.Add(new Admin());
        }
    }
}
