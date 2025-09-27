namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Tuple<int, int>(1, 2);
            var t2 = new Tuple<int, string>(1, "var");
            var t3 = new Tuple<string, int, double, char>("mohamed",10,3.3,'c');
            Console.WriteLine(t2);
            Console.WriteLine(t3.Item3);
            var tt = Tuple.Create(t1, t2, t3);
            Console.WriteLine(tt.Item3);
            Console.WriteLine(tt.Item3.Item4);


            var rest = Tuple.Create(1,2,3,4,5,6,7,8);
            Console.WriteLine(rest.Rest.Item1);


            var p = new person()
            {
                name = "MOhamed",
                age = 20,
                id = 24166
            };

            var data = p.get_name_age_and_id();
            Console.WriteLine(data);
        }
    }
    class person
    {
        public string name { get; set; }
        public int id { get; set; }
        public int age { get; set; }

        public Tuple<string,int,int> get_name_age_and_id()
        {
            return Tuple.Create(name,id,age);  // can also ==> (name,id,age)
        }
    }
    
}
