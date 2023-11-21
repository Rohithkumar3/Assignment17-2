using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_2
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            HerbalProduct herbalProduct = CreateHerbalProduct();
            DisplayDetails(herbalProduct);
            Console.ReadKey();
        }

        static HerbalProduct CreateHerbalProduct()
        {
            HerbalProduct herbalProduct = new HerbalProduct();
            herbalProduct.SetInformation(1, "Herbal Shampoo", 150.9);

            herbalProduct.SetHerbalInformation("Aloe Vera",DateTime.Now, DateTime.Now.AddMonths(22));

            return herbalProduct;
        }

        static void DisplayDetails(Product product)
        {
            product.ShowDetails();
        }
    }   
    }

