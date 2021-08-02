using System;
using System.Collections;
using System.Collections.Immutable;
using System.Collections.Generic;
using System.Linq;

public class SimpleLinkedList<T> : IEnumerable<T>
{
    private T value;
    private SimpleLinkedList<T> next;
    private SimpleLinkedList<T> last;
    private int count = 0;

    public SimpleLinkedList(T value)
    {
        this.value = value;
    }

    public SimpleLinkedList(IEnumerable<T> values)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public T Value 
    { 
        get
        {
            return value;
        } 
    }

    public SimpleLinkedList<T> Next
    { 
        get
        {
            return next;
        } 
    }

    public SimpleLinkedList<T> Add(T value)
    {
        SimpleLinkedList<T> newHead = new SimpleLinkedList<T>(value);
        count++;
        if (last is null) 
        {
            this.next = newHead;
        } else {
            this.last.next = newHead;
        }
        this.last = newHead;
        return this;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new SimpleLinkedListEnumerator<T>(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        //T[] array = new T[count];
        //return array.GetEnumerator();
        //return this.ToArray();
        //return new SimpleLinkedListEnumerator<T>(this);
    }
}

class SimpleLinkedListEnumerator<T> : IEnumerator<T>
{

    private SimpleLinkedList<T> list;
    private SimpleLinkedList<T> head;

    public SimpleLinkedListEnumerator(SimpleLinkedList<T> list)
    {
        this.list = list;
        this.head = list;
    }

    public T Current
    {
        get {
            return this.list.Value;
        }
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public void Dispose()
    {
        //Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    
    public bool MoveNext()
    {
        if (list != null)
        {
            this.list = list.Next;
            return true;
        } else { return false; }
    }
    
    public void Reset()
    {
        list = head;
    }
}