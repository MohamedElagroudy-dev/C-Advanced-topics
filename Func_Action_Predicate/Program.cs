namespace Func
{
    delegate T del<T> (T a, T b);
    internal class Program
    {
        static void Main(string[] args)
        {
            del<int> del1 = Add;

            Console.WriteLine(del1(10,10));



            Func<int, int, int> del2 = Add; // arguments first and return typ in last // Work with out delegate defination in line 3

            Console.WriteLine(del1(20, 10));



            Func<string, int, string> del3 = Add2;

            Console.WriteLine(del3("Messi", 10));


            Func<int,int,int> del4 = (x,y) => x + y;

            Console.WriteLine(del4(100,100));

            Func<string> del5 = () => "Hi";

            Console.WriteLine(del5());
            
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static string Add2(string x, int y)
        {
            return x + " " + y;
        }
    }
}
