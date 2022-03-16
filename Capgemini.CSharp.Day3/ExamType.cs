using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Capgemini.CSharp.Day3
{
    internal class ExamType
    {
        private class Bird
        {
            public string Name;
            public double Maxheight;
            public Bird() //Default Constructor
            {
                this.Name = "MountainEagle";
                this.Maxheight = double.Parse("500");
                //
                // TODO: Add constructor logic here
                //
            }
            public Bird(string Name, double Maxheight) //Overloaded Constructor
            {
                this.Name = Name;
                this.Maxheight =Maxheight;
            }
            public void fly()
            {
                Console.WriteLine($"{this.Name} is flying at altitude {this.Maxheight}");
            }
            public void fly(string AtHeight)
            {
                if (double.Parse(AtHeight) <= this.Maxheight)
                    Console.WriteLine(this.Name + " flying at " + AtHeight.ToString());
                else
                    Console.WriteLine(this.Name + " cannot fly At this height");

            }
            static void Main(string[] args)
            {
                Bird b = new Bird("Eagle",double.Parse("500"));
                b.fly();
                b.fly(("300"));
            }



        }
    }
}
