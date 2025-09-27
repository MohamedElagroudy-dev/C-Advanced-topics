using System.Collections;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var h = new Hashtable();
            h.Add("Name", "Mohamed");
            h.Add("Age", 20);
            h.Add(150, "njara629@gmail.com");

            string res1 = (string)h[150];

            int res2 = (int)h["Age"];

            Console.WriteLine(res1);

            Console.WriteLine(res2);






        }
    }
}
