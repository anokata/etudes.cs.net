using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    private Queue<T> buf;
    private int capacity;

    public CircularBuffer(int capacity)
    {
        buf = new Queue<T>(capacity);
        this.capacity = capacity;
    }

    public T Read() => buf.Dequeue();

    public void Write(T value)
    {
        if (capacity == buf.Count)
            throw new InvalidOperationException("Not enough capacity");
        buf.Enqueue(value);
    }

    public void Overwrite(T value)
    {
        if (buf.Count == capacity)
            Clear();
        Write(value);
    }

    public void Clear()
    {
        if (buf.Count > 0)
            buf.Dequeue();
    }
}