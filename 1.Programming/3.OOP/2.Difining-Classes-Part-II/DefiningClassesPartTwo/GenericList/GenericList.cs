using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Implements generic resizable list
/// </summary>
/// <typeparam name="T">The type of the elements in the list</typeparam>
public class GenericList<T> where T: IComparable
{
    //Fields
    private T[] arr;
    private int capacity;
    private int count;

    //Properties
    /// <summary>
    /// Sets or gets the total number of elements the list can hold without resizing.
    /// </summary>
    public int Capacity
    {
        get
        {
            return this.capacity;
        }
        set
        {
            if (value < this.capacity)
            {
                throw new ArgumentOutOfRangeException("capacity is smaller than the current value");
            }
            this.capacity = value;
        }
    }

    /// <summary>
    /// Gets the number of elements in the list.
    /// </summary>
    public int Count
    {
        get
        {
            return this.count;
        }
        private set { }
    }

    public T this[int index]
    {
        get
        {
            CheckIndex(index, this.count);
            return arr[index];
        }
        set
        {
            CheckIndex(index, this.count);
            arr[index] = value;
        }
    }

    //Constructors
    public GenericList()
        :this(4)
    {
    }

    public GenericList(int capacity)
    {
        this.capacity = capacity;
        this.count = 0;
        this.arr = new T[this.capacity];

        List<int> a = new List<int>();
        
    }

    //Methods
    /// <summary>
    /// Adds element at the end of the list
    /// </summary>
    public void Add(T item)
    {
        if (this.count == this.capacity)
        {
            this.capacity *= 2;
            T[] newArr = new T[this.capacity];
            Array.Copy(this.arr, newArr, count);
            this.arr = newArr;
        }
        arr[count] = item;
        count++;
    }

    /// <summary>
    /// Gets the element at given index
    /// </summary>
    public T ElementAt(int index)
    {
        CheckIndex(index, this.count);

        return arr[index];
    }

    /// <summary>
    /// Removes element at given index
    /// </summary>
    public void RemoveAt(int index)
    {
        CheckIndex(index, this.count);

        T[] newArr = new T[this.capacity];
        Array.Copy(this.arr, newArr, index);
        Array.Copy(this.arr, index + 1, newArr, index, this.count - 1 - index);
        this.arr = newArr;
        count--;
    }

    /// <summary>
    /// Insert element at given index
    /// </summary>
    public void Insert(int index, T item)
    {
        CheckIndex(index, this.count);

        if (this.count == this.capacity)
        {
            this.capacity *= 2;
        }

        T[] newArr = new T[this.capacity];
        Array.Copy(this.arr, newArr, index);
        newArr[index] = item;
        Array.Copy(this.arr, index, newArr, index + 1, this.count - index);
        this.arr = newArr;
        count++;
    }

    /// <summary>
    /// Clears the list
    /// </summary>
    public void Clear()
    {
        this.count = 0;
    }

    /// <summary>
    /// Finds element by value
    /// </summary>
    /// <returns>The index of the element or -1 if it is not found</returns>
    public int Find(T item)
    {
        for (int i = 0; i < this.arr.Length; i++)
        {
            if (this.arr[i].CompareTo(item) == 0)
            {
                return i;
            }
        }
        return -1;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < this.count; i++)
        {
            sb.AppendFormat("{0} ", this.arr[i]);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Finds the minimal element in the list
    /// </summary>
    public T Min()
    {
        CheckCount(this.count);

        T min = this.arr.Min();
        return min;
    }

    /// <summary>
    /// Finds the maximal element in the list
    /// </summary>
    public T Max()
    {
        CheckCount(this.count);

        T max = this.arr.Max();
        return max;
    }

    /// <summary>
    /// Check if given index is valid. Throws exception otherwise.
    /// </summary>
    /// <param name="index">The index</param>
    /// <param name="count">The length of the list</param>
    private static void CheckIndex(int index, int count)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException(
                "Index was out of range. Must be non-negative and less than the size of the collection");
        }
    }

    /// <summary>
    /// Check if there are any elements in the list. Throws exception if the list is empty.
    /// </summary>
    private static void CheckCount(int count)
    {
        if (count == 0)
        {
            throw new InvalidOperationException(
                "The collection contains no elements");
        }
    }
}

