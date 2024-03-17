using System;
using System.Collections.Generic;

public class IntegerDataProcessor : DataProcessor<int>
{
    public IntegerDataProcessor(List<int> data) : base(data)
    {
    }

    protected override void Process()
    {
        Console.WriteLine("Processing integer data...");
        foreach (var item in data)
        {
            Console.WriteLine("Integer data item: " + item);
        }
    }

    protected override void PostProcess()
    {
        Console.WriteLine("Additional postprocessing for integers...");
    }
}
