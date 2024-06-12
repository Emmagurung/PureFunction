using System;

public class ImmutabilityExample
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 }; 


        var newNumbers = new List<int>(numbers);

        newNumbers.Add(6); // Add a new element (6) to the "newNumbers" list

        Console.WriteLine("Original Numbers: " + string.Join(", ", numbers));
        Console.WriteLine("New Numbers: " + string.Join(", ", newNumbers));
    }
}