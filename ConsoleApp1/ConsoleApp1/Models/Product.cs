namespace ConsoleApp1.Models;

public class Product
{
    public string Name;
    public decimal Price;
    public int Count;
    public Product()
    {
        
    }
    public Product(string name, decimal price, int count)
    {
        Name = name;
        Price = price;
        Count = count;
    }
    public void Detail()
    {
        Console.WriteLine($"Product name : {Name} price : {Price} count : {Count} ");
    }
    public void Discount(int precent) // endirim
    {
        Console.WriteLine($"Endirim : {precent}%");
        Console.WriteLine($"{Price *= precent /100 }");
        Console.WriteLine($"{Price - precent}");
    }
}
