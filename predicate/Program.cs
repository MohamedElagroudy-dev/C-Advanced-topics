namespace Func
{
    //delegate T del<T>(T a, T b);
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> dlg = isEven;
            Console.WriteLine(dlg(55));



            Predicate<int> f = isEven; // Use if return type is bool // you dont have to write the return type

            Console.WriteLine(f(56));

        }

       static bool isEven(int x)
        {
            if(x % 2 == 0) return true;
            return false;
        }
    }
}
