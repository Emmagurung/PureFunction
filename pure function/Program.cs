
    using System;

    class PureFunctionExample
    {
        static int Add(int x, int y) => x + y;   

    static void Main()
        {
            int result = Add(3, 5);  
        Console.WriteLine($"Result of Add(3, 5): {result}");
        }
    }