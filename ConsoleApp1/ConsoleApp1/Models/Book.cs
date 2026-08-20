namespace ConsoleApp1.Models;

public class Book : Product
{
    public string Genre;
    public Book[] book;

    public Book(string name, decimal price , int count , string genre):base(name,price,count)
    {
        Genre = genre;
    }
    public void AddBook()
    {

        Console.WriteLine("Enter lenght : ");
        int bookLeght = Convert.ToInt32(Console.ReadLine());

        book = new Book[bookLeght];



        for (int i = 0; i < book.Length; i++)
        {


            book[i].Name = name;
            book[i].Price = price;
            book[i].Count = count;
        }


    }
}
