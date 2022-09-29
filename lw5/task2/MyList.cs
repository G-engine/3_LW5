using System.Collections;

namespace task2;

public class MyList<T> : IEnumerable
{
    private T[]? data;

    public int Length
    {
        get => data.Length;
    }
    
    public IEnumerator GetEnumerator() => data.GetEnumerator();
    
    public MyList(int number)
    {
        data = new T[number];
    }
    
    public MyList(params T[] values)
    {
        data = new T[values.Length];
        for (int i = 0; i < values.Length; ++i)
            data[i] = values[i];
    }

    public void Add(T value)
    {
        T[] newData = new T[data.Length + 1];
        for (int i = 0; i < data.Length; ++i)
            newData[i] = data[i];
        newData[^1] = value;
        
        data = newData;
    }

    public void AddRange(params T[] values)
    {
        T[] newData = new T[data.Length + values.Length];
        for (int i = 0; i < data.Length; ++i)
            newData[i] = data[i];
        for (int i = 0; i < values.Length; ++i)
            newData[i + data.Length] = values[i];

        data = newData;
    }

    public T this[int index]
    {
        get => data[index];
        set => data[index] = value;
    }
}