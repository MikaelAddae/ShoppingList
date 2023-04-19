using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lunch Store");
            Console.WriteLine("Please select an item to purchase");
            Console.WriteLine("========\t========");
            decimal total = 0;

            Dictionary<string, decimal> store = new Dictionary<string, decimal>();
            List<string> cart = new List<string>();
            List<decimal> price = new List<decimal>();

            store.Add("cheese", (decimal)1.99);
            store.Add("ham", (decimal)4.55);
            store.Add("apple", (decimal)0.85);
            store.Add("banana", (decimal)0.65);
            store.Add("chips", (decimal)1.11);
            store.Add("bread", (decimal)2.25);
            store.Add("soda", (decimal)1.55);
            store.Add("juice", (decimal)2.22);

            bool goOn = true;

            do
            {
                foreach (KeyValuePair<string, decimal> kvp in store)
                {

                    Console.WriteLine(kvp.Key + "\t\t" + kvp.Value);

                }
                Console.WriteLine();
                Console.WriteLine("Choose an item to purchase");
                string addCart = Console.ReadLine().ToLower().Trim();

                if (store.ContainsKey(addCart))
                {
                    cart.Add(addCart);
                    price.Add(store[addCart]);

                }
                else
                {
                    Console.WriteLine("Please try again");
                }
                goOn = Continue();
            }
            while (goOn == true);
            Console.WriteLine();
            Console.WriteLine("These are the items you have added to your cart");
            Console.WriteLine();

            foreach (string item in cart)
            {
                Console.WriteLine(item + "\t" + store[item]);
                total += store[item];
            }


            Console.WriteLine("=============");
            Console.WriteLine("Total:" +"\t" + total);
        }


        public static bool Continue()
        {
            Console.WriteLine("Would you like to add an item? y/n");
            string input = Console.ReadLine().ToLower().Trim();

            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
 
                return false;
            }
            else
            {
                Console.WriteLine("Type \"y\" to order more, type \"n\" to checkout");
                return Continue();
            }
        }


    }
}