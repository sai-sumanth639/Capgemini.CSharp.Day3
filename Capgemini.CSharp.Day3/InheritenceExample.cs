using System;



using static System.Console;

namespace Capgemini.CSharp.Day3

{

    public class Customer

    {

        protected string Name, City;

        //public void GetDetails()

        //{

        // Write("Enter Name :");

        // Name = ReadLine();

        // Write("Enter City :");

        // City = ReadLine();

        //}

        //public void PrintDetails()

        //{

        // WriteLine($"Name :{Name}\tCity :{City}");

        //}

        public Customer(int a)

        {

            WriteLine("Base Class Constructor :" + a);

        }

        public Customer()

        {

            WriteLine("Base Class Default Constructor");

        }

    }

    public class Orders : Customer

    {

        protected int OrderId;

        protected DateTime OrderDate;

        public Orders() : base(10)//Constructor Inheritance

        {

        }

        public void GetDetails()

        {

            Write("Enter Name :");

            base.Name = ReadLine();

            Write("Enter City :");

            base.City = ReadLine();

            Write("Enter Order Id :");

            OrderId = int.Parse(ReadLine());

            Write("Enter Order Date :");

            OrderDate = DateTime.Parse(ReadLine());

        }

        public void PrintDetails()

        {

            //base.PrintDetails();

            WriteLine($"Name :{Name}\tCity :{City}");

            WriteLine($"Order ID :{OrderId}\tOrder Date :{OrderDate}");

        }

    }

    class TestClass

    {

        static void Main(string[] args)

        {

            //Customer customer = new Customer();

            //customer.GetDetails();

            //customer.PrintDetails();

            Orders orders = new Orders();

            orders.GetDetails();

            orders.PrintDetails();

        }

    }

}





