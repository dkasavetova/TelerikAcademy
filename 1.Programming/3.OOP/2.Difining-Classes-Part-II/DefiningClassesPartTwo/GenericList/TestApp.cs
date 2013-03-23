using System;

class TestApp
{
    static void Main()
    {
        //Create new list
        GenericList<int> list = new GenericList<int>(5);

        Console.WriteLine("Capacity: " + list.Capacity);
        Console.WriteLine("Count: " + list.Count);
        Console.WriteLine();

        //Add some values
        list.Add(0);
        list.Add(1);
        list.Add(2);
        list.Add(3);

        Console.WriteLine("--- add values 0, 1, 2, 3");
        Console.WriteLine("Capacity: " + list.Capacity);
        Console.WriteLine("Count: " + list.Count);
        Console.WriteLine("List: " + list);
        Console.WriteLine();

        //Add more values to cause increasing of capacity
        list.Add(4);
        list.Add(5);

        Console.WriteLine("--- add values 4, 5");
        Console.WriteLine("Capacity: " + list.Capacity);
        Console.WriteLine("Count: " + list.Count);
        Console.WriteLine("List: " + list);
        Console.WriteLine();

        //Remove a value
        list.RemoveAt(2);
        Console.WriteLine("--- remove value 2");
        Console.WriteLine("Capacity: " + list.Capacity);
        Console.WriteLine("Count: " + list.Count);
        Console.WriteLine("List: " + list);
        Console.WriteLine();

        //Insert it back
        list.Insert(2, 2);
        Console.WriteLine("--- insert value 2 at position 2");
        Console.WriteLine("Capacity: " + list.Capacity);
        Console.WriteLine("Count: " + list.Count);
        Console.WriteLine("List: " + list);
        Console.WriteLine();

        //Find it's index
        Console.WriteLine("Index of element with value 2: " + list.Find(2));
        Console.WriteLine();

        //Find the max element
        Console.WriteLine("Max: " + list.Max());
        Console.WriteLine();

        //Find the min element
        Console.WriteLine("Min: " + list.Min());
        Console.WriteLine();

        //Clear the list
        list.Clear();
        Console.WriteLine("--- clear the list");
        Console.WriteLine("Capacity: " + list.Capacity);
        Console.WriteLine("Count: " + list.Count);
        Console.WriteLine();

    }
}

