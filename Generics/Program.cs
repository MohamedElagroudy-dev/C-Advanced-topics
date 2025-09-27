using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product<string, float> product = new Product<string, float>()
            {
                Name = "product",
                Price = 20.26f
            };
            product.Print();

            Product<string, int> product2 = new Product<string, int>()
            {
                Name = "product",
                Price = 20
            };
            product2.Print();
            product2.PrintName("mohamed","LIFO");

            Product<int, float> product3 = new Product<int, float>()
            {
                Name = 200,
                Price = 20.26f
            };
            product3.Print();
            product3.PrintName(444, "LIFO");

            /////////////////

            Printer.PrintHello<string>("Mohamed");
            Printer.PrintHello("Elagroudy"); //if you delete <string> it's ok trust him he is smart

            ////////////////

            Container<int> c = new Box<int>();
            c.add(100000);     

            ///////////////
            
            CompanyEntance<Engineer> com = new CompanyEntance<Engineer>();
            com.LogToCompany(new Engineer());
        }
    }

    class Product<T, U>  //generic class
    {
        public T Name { get; set; }
        public U Price { get; set; }

        public T[] ProductSpefics = new T[10]; 
        public void Print()
        {
            Console.WriteLine($"{Name} - {Price}");
        }
        public void PrintName( T name ,string dis ) //generic method
        {
            Console.WriteLine($"{name} - {dis}");
        }
    }

    static class  Printer
    {
        public static void PrintHello<T>(T name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }

}
