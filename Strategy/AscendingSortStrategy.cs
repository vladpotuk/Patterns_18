using System;

public class AscendingSortStrategy<T> : ISortStrategy<T> where T : IComparable<T>
{
    public void Sort(T[] array)
    {
        Array.Sort(array);
    }
}
