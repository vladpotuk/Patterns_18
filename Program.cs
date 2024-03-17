using System;

class Program
{
    static void Main(string[] args)
    {
        
        var sortContext = new SortContext<int>();

        
        int[] numbers = { 4, 2, 7, 1, 9, 5 };

        
        sortContext.SetSortStrategy(new AscendingSortStrategy<int>());
        sortContext.SortArray(numbers);
        Console.WriteLine("Ascending order:");
        PrintArray(numbers);

        
        sortContext.SetSortStrategy(new DescendingSortStrategy<int>());
        sortContext.SortArray(numbers);
        Console.WriteLine("Descending order:");
        PrintArray(numbers);
    }

    static void PrintArray<T>(T[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
