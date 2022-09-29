using System.Collections;

namespace task3;

public class MyDictionary<TKey,TValue> : IEnumerable
{
    private KeyValuePair<TKey, TValue>[]? pairs;

    public MyDictionary(TKey key, TValue value)
    {
        pairs = new KeyValuePair<TKey, TValue>[] {new KeyValuePair<TKey,TValue>(key, value)};
    }

    public IEnumerator GetEnumerator() => pairs.GetEnumerator();
    
    public void Add(TKey key, TValue value)
    {
        KeyValuePair<TKey, TValue>[]? newPairs = new KeyValuePair<TKey, TValue>[pairs.Length + 1];
        for (int i = 0; i < pairs.Length; ++i)
            newPairs[i] = pairs[i];

        newPairs[^1] = new KeyValuePair<TKey, TValue>(key, value);
        pairs = newPairs;
    }

    public TValue this[TKey index]
    {
        get
        {
            for (int i = 0; i < pairs.Length; ++i)
                if (pairs[i].Key.Equals(index))
                    return pairs[i].Value;
            throw new Exception();
        }
    }
}