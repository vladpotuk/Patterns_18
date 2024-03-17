public class SortContext<T>
{
    private ISortStrategy<T> _sortStrategy;

    public void SetSortStrategy(ISortStrategy<T> sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    public void SortArray(T[] array)
    {
        _sortStrategy.Sort(array);
    }
}
