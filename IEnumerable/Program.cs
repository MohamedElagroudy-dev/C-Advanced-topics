using System.Collections;

namespace IEnumerabl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arraylist = new ArrayList();
            var list = new List<int>();
            var dic = new Dictionary<int, int>();

            var shoppinglist = new ShoppingList();

            foreach (var item in shoppinglist)
            {
                Console.WriteLine(item);
            }

        }
    }
}
