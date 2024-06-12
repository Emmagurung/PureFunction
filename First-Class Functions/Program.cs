using System;
class FirstClassFunctionExample
{

    public static void Main()
    {

        Func<int, int> operation = Square;   
        int result = operation(5); 
        Console.WriteLine($"Result: {result}");
    }
    static int Square(int x) 
    {
        return x * x;
    }

}