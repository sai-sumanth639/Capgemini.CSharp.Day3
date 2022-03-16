using System;
using static System.Console;
namespace Capgemini.CSharp.Day3
{
    internal class Program
    {
        public string Name;
        public static string City;
        public Program()
        {
            Name = "Sam";
            City = "Chennai";
            WriteLine("Constructor is created");

        }
        static Program()
        {
            City = "Mumbai";
            WriteLine("Static constructor created");
        }
        public void Dispose()
        {
            Name = null;
        }
        static void Main(string[] args)
            {
            Program p = new Program();
            WriteLine($"City:{Program.City}");
            p.Dispose();
        }
        }
    }

