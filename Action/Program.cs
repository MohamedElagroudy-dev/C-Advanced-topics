namespace Action
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Action<double> dlg = print; // Not need return type

            dlg(22.2);

            Action<string> dlg2 = Add3;

            dlg2("Mohamed");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static string Add2(string x, int y)
        {
            return x + " " + y;
        }
        static void Add3( string y)
        {
            Console.WriteLine( "Helllo"+ " " + y) ;
        }

        static void print(double d)
        {
            Console.WriteLine(d);
        }
    }
}
