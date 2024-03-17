using System;
using System.Collections.Generic;

public class StringDataProcessor : DataProcessor<string>
{
    public StringDataProcessor(List<string> data) : base(data)
    {
    }

    protected override void Process()
    {
        Console.WriteLine("Processing string data...");
        foreach (var item in data)
        {
            Console.WriteLine("String data item: " + item);
        }
    }

    protected override void PreProcess()
    {
        Console.WriteLine("Additional preprocessing for strings...");
    }
}
