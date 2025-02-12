namespace _03._12.Entities;

public class Arr : ICalc
{
    private int[] _array;
    
    public Arr(int[] array)
    {
        _array = array;
    }
    
    public int Less(int valueToCompare)
    {
        int count = 0;
        foreach (var item in _array)
        {
            if (item < valueToCompare)
            {
                count++;
            }
        }
        return count;
    }
    
    public int Greater(int valueToCompare)
    {
        int count = 0;
        foreach (var item in _array)
        {
            if (item > valueToCompare)
            {
                count++;
            }
        }
        return count;
    }
}