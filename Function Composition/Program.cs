using System;

class FunctionalCompositionExample
{
    static void Main()
    {
        
        Func<int, int> square = Square;  // Define square functions
        Func<int, int> increment = Increment;  // Define increment functions

        // Compose the Square and Increment functions to create a new function: squareAndIncrement
        Func<int, int> squareAndIncrement = Compose(square, increment);

        // Call the composed function with an argument and get the result
        int result = squareAndIncrement(3);

       
        Console.WriteLine($"Result of composing square and increment: {result}");
    }
    // Square function: returns the square of the input
    static int Square(int x)
    {
        return x * x;
    }
    // Increment function: returns the input incremented by 1
    static int Increment(int x)
    {
        return x + 1;
    }
    // Compose function: combines two functions into one by passing the output of one function to the input of another
    static Func<int, int> Compose(Func<int, int> f1, Func<int, int> f2)
    {
        return x => f2(f1(x));
    }
}