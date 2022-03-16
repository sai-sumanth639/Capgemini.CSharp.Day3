using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day3
{
    public class practise
    {
        public int Id;
        public string Name;
        public String MobileNo;
        public String City;

        public virtual void GetDetails() { }
        public virtual void PrintDetails() { }
    }
public class Student : practise
    {
        public float Fees;
        public float TotalMarks;
        public override void GetDetails()
        {
            
        }
        public override void PrintDetails() 
        {

        }
    }
    public class Employee1 : practise
    {
        public string Department;
    }
    public class Technical : Employee1
    {
        public string Subject;
        public override void GetDetails()
        {
            Id = 1;
            Name = "karthik";
            MobileNo = "81799";
            City = "Hyderabad";
            Department = "Math";
            Subject = "Math";
        }
        public override void PrintDetails()
        {

        }
    }
    public class NonTechnical : Employee1
    {
        public string Duration;
    }
    public class TestClass2
    {
        static void Main(string[] args)
        {


            practise person = new practise();
            person = new Employee1();
            person = new Technical();
            person = new NonTechnical();
            person = new Student();
            Student student = new Student();
            //Student= new Employee();
        }
    }

    
}

