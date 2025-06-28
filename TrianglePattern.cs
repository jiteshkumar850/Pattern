using System;
namespace Pattern
{
    class TrianglePattern
{
    static void Main()
    {
        int n = 5;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}
}
