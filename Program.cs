using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n = 800000; //random numbers
        double[,] numbers;
        Stopwatch timer = new Stopwatch();

        numbers = GenRandomNumbers(n);

        //addition of ints
        timer.Start();
        AddIntegers(numbers, n);
        timer.Stop();
        Console.WriteLine("Addition of ints");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");

        //multiplication of ints
        timer.Restart();
        MultiplyIntegers(numbers, n);
        timer.Stop();
        Console.WriteLine("Multiplication of ints");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");

        //direct multiplication of doubles
        timer.Restart();
        SquareDoublesDirectly(numbers, n);
        timer.Stop();
        Console.WriteLine("Direct multiplication of doubles (squared)");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");

        //Math.Pow for doubles
        timer.Restart();
        SquareDoublesWithMathPow(numbers, n);
        timer.Stop();
        Console.WriteLine("Using Math.Pow for doubles (squared)");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");

        //Math.Sqrt for doubles
        timer.Restart();
        SquareRootDoublesWithMathSqrt(numbers, n);
        timer.Stop();
        Console.WriteLine("Using Math.Sqrt for doubles (square root)");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
    }

    //adds integers
    static void AddIntegers(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = (int)nums[i, 0] + (int)nums[i, 1];
        }
    }

    //multiplies integers
    static void MultiplyIntegers(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = (int)nums[i, 0] * (int)nums[i, 1];
        }
    }

    //squares doubles with direct multiplication
    static void SquareDoublesDirectly(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] * nums[i, 0];
        }
    }

    //Math.Pow
    static void SquareDoublesWithMathPow(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = Math.Pow(nums[i, 0], 2);
        }
    }

    //computes the square root with doubles using Math.Sqrt
    static void SquareRootDoublesWithMathSqrt(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = Math.Sqrt(nums[i, 0]);
        }
    }

    //generates array of rand num
    static double[,] GenRandomNumbers(int count)
    {
        Random rand = new Random(); 
        double[,] num = new double[count, 3]; 

        for (int i = 0; i < count; ++i)
        {
            num[i, 0] = 10000.0 * rand.NextDouble(); 
            num[i, 1] = 10000.0 * rand.NextDouble();
        }
    return num;
    }
}