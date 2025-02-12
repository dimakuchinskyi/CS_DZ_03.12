using System.Text;
using _03._12.Entites;

namespace _03._12;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        int[] array = { 2, 1, 3, 9, 10, 7, 6, 8, 3, 5 };
        Arr arr = new Arr(array);

        Console.WriteLine($"Max: {arr.Max()}");
        Console.WriteLine($"Min: {arr.Min()}");
        Console.WriteLine($"Average: {arr.Average()}");
        Console.WriteLine($"Search 5: {arr.Search(5)}");
        Console.WriteLine($"Search 11: {arr.Search(11)}");

        arr.SortAsc();
        Console.WriteLine("Sort Asc:");
        arr.Print();
        arr.SortDesc();
        Console.WriteLine("Sort Desc:");
        arr.Print();
        arr.SortByParam(true);
        Console.WriteLine("Sort Asc:");
        arr.Print();
        arr.SortByParam(false);
        Console.WriteLine("Sort Desc:");
        arr.Print();
    }
}