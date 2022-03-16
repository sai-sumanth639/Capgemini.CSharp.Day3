using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day3
{
    internal class parent1
    {
        public sealed class Parent1
        {
            public int Id;
        }

        class ChildClass //: Parent1
        {
            public void Get()
            {
                //Id=5153
            }
        }
        static void Main(string[] args)
        {
                Parent1 obj=new Parent1();

        }
    }
}
