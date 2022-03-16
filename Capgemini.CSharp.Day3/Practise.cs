using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Capgemini.CSharp.Day3

{

    //public class Parent { }

    public abstract class Person //: Parent

    {

        public int Id;

        public string Name;

        public string MobileNo;

        public string City;

        public abstract void GetDetails();

        public abstract void PrintDetails();

        public virtual void Test() { }

    }

    public class Student1 : Person

    {

        public float Fees;

        public float TotalMarks;

        public override void GetDetails()

        {

            Id = 1001;

            Name = "Pravin";

            MobileNo = "12345566";

            Fees = 45000;

            TotalMarks = 500;

        }

        public override void PrintDetails()

        {

            Console.WriteLine($"Id :{Id}\tName :{Name}\tFees :{Fees}\tTotal Marks :{TotalMarks}");

        }

    }

    public abstract class Employee : Person

    {

        public string Department;

    }

    public class Techincal : Employee

    {

        public string Subject;

        public override void GetDetails()

        {

            Id = 1;

            Name = "Karthick";

            MobileNo = "7888";

            City = "Mumbai";

            Subject = "Maths";

            Department = "Maths";

        }

        public override void PrintDetails()

        {

            Console.WriteLine($"Id :{Id}\tSubject :{Subject}");

        }

    }

    public class NonTechnical1 : Employee

    {

        public string Duration;

        public override void GetDetails()

        {

            //throw new NotImplementedException();

            Id = 200;

            Name = "siva";

        }

        public override void PrintDetails()

        {

            //throw new NotImplementedException();

            Console.WriteLine($"Id :{Id}\tName :{Name}");

        }

    }

    public class TestClass6

    {

        static void Main(string[] args)

        {

            Person person1;

            //Techincal Staff

            person1 = new Techincal();

            person1.GetDetails();

            person1.PrintDetails();

            //Non Technical

            person1= new NonTechnical1();

            person1.GetDetails();

            person1.PrintDetails();

            //Students

            person1 = new Student1();

            person1.GetDetails();

            person1.PrintDetails();

            //Student student = new Student();

            //student = new Employee();

            //ParentClass parentClass = new

        }

    }

    //Just ignore the below code

    public class ParentClass

    {

        public int Id;

    }

    public abstract class ChildClass : ParentClass

    {

    }

    public class ChildClass2 : ChildClass

    {

        public void GetParent()

        {

            Id = 1;

        }

    }

}

