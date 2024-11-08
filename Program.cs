using System;

class Program
{
    public static void Main(string[] args)
    {
        Write1ThroughN_While(41);
        Write1ThroughN_For(4);
        WriteNThrough1_While(5);
        WriteNThrough1_For(6);
        WriteEvensThrough100();
        FindSum(10);
        FindSumOfEvenNumbers(50);
        FindSumOfOddNumbers(55);
        OutputRightTriangle(5);
    }

    //Funtions
    public static void Write1ThroughN_While(int n)
    {
        int counter = 1;
        while (counter <= n)
        {
            Console.WriteLine(counter);
            counter++;
        }
    }

    public static void Write1ThroughN_For(int n)
    {
        for (int counter = 1; counter <= n; counter++)
        {
            Console.WriteLine(counter);
        }
    }

    public static void WriteNThrough1_While(int n)
    {
        int counter = n;
        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }

    public static void WriteNThrough1_For(int n)
    {
        for (int counter = n; counter >= 1; counter--)
        {
            Console.WriteLine(counter);
        }
    }

    public static void WriteEvensThrough100()
    {
        for (int counter = 2; counter <= 100; counter++)
        {
            if (counter % 2 == 0)
            {
                Console.WriteLine(counter);
            }

        }
    }

    public static void FindSum(int n)
    {
        int counter = 0;
        while (counter < n)
        {
            counter++;
            Console.WriteLine(counter);
        }

        if (counter == n)
        {
            Console.WriteLine(counter + n);

        }
    }

    public static void FindSumOfEvenNumbers(int n)
    {
        int counter = 0;
        while (counter < n)
        {
            counter++;
            if (counter % 2 == 0)
            {
                Console.WriteLine(counter);
            }
        }

        if (counter == n)
        {
            Console.WriteLine(counter + n);
        }
    }

    public static void FindSumOfOddNumbers(int n)
    {
        int counter = 1;
        while (counter < n)
        {
            counter++;
            if (counter % 2 == 1)
            {
                Console.WriteLine(counter);
            }
        }

        if (counter == n)
        {
            Console.WriteLine(counter + n);
        }
    }
    public static void OutputRightTriangle(int _base)
    {
        for (int i= 0; i < _base; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}