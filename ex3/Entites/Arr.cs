namespace _03._12.Entites;

public class Arr : IMath, ISort
{
    private int[] _array;
    
    public Arr(int[] array)
    {
        _array = array;
    }
    
    public int Max()
    {
        int max = _array[0];
        for (int i = 1; i < _array.Length; i++)
        {
            if (_array[i] > max)
            {
                max = _array[i];
            }
        }
        return max;
    }
    
    public int Min()
    {
        int min = _array[0];
        for (int i = 1; i < _array.Length; i++)
        {
            if (_array[i] < min)
            {
                min = _array[i];
            }
        }
        return min;
    }
    
    public float Average()
    {
        float sum = 0;
        for (int i = 0; i < _array.Length; i++)
        {
            sum += _array[i];
        }
        return sum / _array.Length;
    }
    
    public bool Search(int value)
    {
        for (int i = 0; i < _array.Length; i++)
        {
            if (_array[i] == value)
            {
                return true;
            }
        }
        return false;
    }
    
    public void SortAsc()
    {
        Array.Sort(_array);
    }
    
    public void SortDesc()
    {
        Array.Sort(_array);
        Array.Reverse(_array);
    }
    
    public void SortByParam(bool isAsc)
    {
        if (isAsc)
        {
            SortAsc();
        }
        else
        {
            SortDesc();
        }
    }
    
    public void Print()
    {
        foreach (var item in _array)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}