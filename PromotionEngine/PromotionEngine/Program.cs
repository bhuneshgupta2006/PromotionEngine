using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.WriteLine("Please Enter the number of orders");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Select the Product Type:A or B or C or D");
                string producttype = Console.ReadLine();
                Product p = new Product(producttype.ToLower());
                products.Add(p);
            }
            int totalPrice = GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        private static int GetTotalPrice(List<Product> products)
        {
            int counterA = 0;
            int priceA = 50;
            int counterB = 0;
            int priceB = 30;
            int counterC = 0;
            int priceC = 20;
            int counterD = 0;
            int priceD = 15;
            foreach (Product product in products)
            {
                if (product.ProductID == "a")
                {
                    counterA = counterA + 1;
                }
                if (product.ProductID == "b")
                {
                    counterB = counterB + 1;
                }
                if (product.ProductID == "c")
                {
                    counterC = counterC + 1;
                }
                if (product.ProductID == "d")
                {
                    counterD = counterD + 1;
                }
            }
            int totalPriceA = (counterA / 3) * 130 + (counterA % 3 * priceA);
            int totalPriceB = (counterB / 2) * 45 + (counterB % 2 * priceB);
            int totalPriceC = (counterC * priceC);
            int totalPriceD = (counterD * priceD);
            return totalPriceA + totalPriceB + totalPriceC + totalPriceD;

        }
    }
    public class Product
    {

        public string ProductID { get; set; }
        public decimal ProductPrice { get; set; }
        public Product(string productid)
        {
            ProductID = productid;
            switch (productid)
            {
                case "A":
                    ProductPrice = 50;
                    break;
                case "B":
                    ProductPrice = 30;
                    break;
                case "C":
                    ProductPrice = 20;
                    break;
                case "D":
                    ProductPrice = 15;
                    break;
            }
        }

    }
}
