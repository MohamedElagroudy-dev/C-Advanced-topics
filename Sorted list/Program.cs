namespace Sorted_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var s = new SortedList<int,string>();
            s.Add(5, "6");
            s.Add(2, "3");
            s.Add(1, "2");         
            s.Add(4, "5");    
            s.Add(3, "4");

            foreach (var i in s)
            {
                Console.WriteLine(i.Key+" - "+i.Value);
            }

        }
    }
}
