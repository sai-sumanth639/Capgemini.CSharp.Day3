using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Capgemini.CSharp.Day3

{

    internal class ProductDetails

    {

        private int _id;

        private string _name;

        private string _mobileNo;

        public int Id

        {

            get

            {

                return _id;

            }

            set

            {

                _id = value;

            }

        }

        public string Name

        {

            get { return _name; }

            set

            {

                if (_name != value)

                {

                    _name = value;

                }

            }

        }

        public string MobileNo

        {

            set

            {

                _mobileNo = value;

            }

            get

            {

                return _mobileNo.Length != 10 ? "Invalid Mobile No" : _mobileNo;

            }

        }

        //Auto Implemeted Property : private double _price;

        public double Price { get; set; }

    }

    public class TestClass3

    {

        static void Main(string[] args)

        {

            ProductDetails pd = new ProductDetails();

            pd.Id = 1;

            pd.Name = "Pen";

            pd.Price = 788.88;

            pd.MobileNo = "789456";

            Console.WriteLine($"Mobile No :{pd.MobileNo}");

        }

    }

}

