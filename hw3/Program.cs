using System.Text;
using _03._12.Entities;

namespace _03._12;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;  
        Console.OutputEncoding = Encoding.Unicode;
        
        var arr = new Arr(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 5, 11 });
        Console.WriteLine(arr.Print());
        Console.WriteLine(arr.CountDistinct());
        Console.WriteLine(arr.EqualToValue(5));
    }
}