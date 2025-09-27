namespace Delegates
{
    internal class Program
    {
        delegate int CalculateDelegate(int x, int y);
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            //Calculate(x,y,Add);
            //Calculate(x,y,Subtract);
            //Calculate(x,y,Multiply);
            //CalculateDelegate op = Divide;
            //Calculate(x,y,op);
            //Calculate(x,y,delegate (int num1 ,int num2) { return (num1 * num2) / (num1 + num2);});
            //Calculate(x,y, ( num1 , num2) => (num1 * num2) / (num1 + num2)); //lampda Expression
            //Calculate(x,y, (j,k) => j+k);
            CalculateDelegate dlg = Add;
            dlg += Subtract;
            Calculate(x, y, dlg);
        }
        static void Calculate(int x, int y,CalculateDelegate dlg )
        {
            int result = dlg(x,y);
            Console.WriteLine(result);
        }
        static int Add(int x, int y)
        {
            Console.WriteLine("Add");
            return x + y;
        } 
        static int Subtract(int x, int y)
        {
            Console.WriteLine("Subtract");
            return x - y;
        } 
        static int Multiply(int x, int y)
        {
            Console.WriteLine("Multiply");
            return x * y;
        } 
        static int Divide(int x, int y)
        {
            Console.WriteLine("Divide");
            return x / y;
        }
    }
}
