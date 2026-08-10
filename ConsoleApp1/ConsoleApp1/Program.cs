namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new();

            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter price : ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter count : ");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter genre : ");
            string genre = Console.ReadLine();


            Book book = new(name,price,count,genre);
            book.AddBook();   
        }
    }
}
