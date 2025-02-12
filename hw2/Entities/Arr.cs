namespace _03._12.Entities;

public class Arr : IOutput2
{
    private int[] _array;
    
    public Arr(int[] array)
    {
        _array = array;
    }
    
    public void ShowEven()
    {
        Console.WriteLine("Even numbers:");
        foreach (var item in _array)
        {
            if (item % 2 == 0)
            {
                Console.Write(item + " ");
            }
        }
    }
    
    public void ShowOdd()
    {
        Console.WriteLine("\nOdd numbers:");
        foreach (var item in _array)
        {
            if (item % 2 != 0)
            {
                Console.Write(item + " ");
            }
        }
    }
}