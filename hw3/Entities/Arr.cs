namespace _03._12.Entities;

public class Arr : ICalc2
{
    private int[] _array;
    
    public Arr(int[] array)
    {
        _array = array;
    }
    
    public int CountDistinct()
    {
        return _array.Distinct().Count();
    }
    
    public int EqualToValue(int valueToCompare)
    {
        return _array.Count(x => x == valueToCompare);
    }
    
    public string Print()
    {
        return string.Join(" ", _array);
    }
}