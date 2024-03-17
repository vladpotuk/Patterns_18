using System;

public class DescendingSortStrategy<T> : ISortStrategy<T> where T : IComparable<T>
{
    public void Sort(T[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
    }
}
