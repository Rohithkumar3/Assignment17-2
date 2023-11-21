using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_2
{
    internal class Product
    {
            protected int pid;
            protected string pname;
            protected double pprice;

            public void SetInformation(int id, string name, double price)
            {
                pid = id;
                pname = name;
                pprice = price;
            }

            public virtual void ShowDetails()
            {
                Console.WriteLine($"Product ID: {pid}");
                Console.WriteLine($"Product Name: {pname}");
                Console.WriteLine($"Product Price: ${pprice}");
            }
        }
    }

