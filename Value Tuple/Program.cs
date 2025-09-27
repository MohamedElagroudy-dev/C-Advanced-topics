namespace Value_Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValueTuple<string, int, int> data = ("Mohamed",20,24166);

            (string , int , int ) emp = ("Ahmed", 20, 24166);

            (string name, int age, int id)  ag= ("agroudy", 20, 24166);

            var x = (1, 2, 3, 4, 5,6,7,8,9,10,12,15,45,2,55,54,5,'x');

            Console.WriteLine(data.Item1);
            Console.WriteLine(ag.age);
        }
    }
}
