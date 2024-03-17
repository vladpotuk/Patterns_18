using System;
using System.Collections.Generic;

public abstract class DataProcessor<T>
{
    protected List<T> data;

    public DataProcessor(List<T> data)
    {
        this.data = data;
    }

    public void ProcessData()
    {
        PreProcess();
        Process();
        PostProcess();
    }

    protected virtual void PreProcess()
    {
        Console.WriteLine("Default preprocessing...");
    }

    protected abstract void Process();

    protected virtual void PostProcess()
    {
        Console.WriteLine("Default postprocessing...");
    }
}
