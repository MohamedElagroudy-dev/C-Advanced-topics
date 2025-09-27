namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookCollection books = new BookCollection();

            books[0] = new Book() { Title = "Harry Boter", Author = "Elagroudy" }; 
        }
    }
}
