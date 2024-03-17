using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> intData = new List<int> { 1, 2, 3, 4, 5 };
        
        DataProcessor<int> intProcessor = new IntegerDataProcessor(intData);
        intProcessor.ProcessData();

        Console.WriteLine();

        
        List<string> stringData = new List<string> { "apple", "banana", "orange" };
        
        DataProcessor<string> stringProcessor = new StringDataProcessor(stringData);
        stringProcessor.ProcessData();
    }
}

