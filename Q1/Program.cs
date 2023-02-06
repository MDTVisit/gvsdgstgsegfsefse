using System;
class Program
{

    static void Main(string[] args)
    {

        double n = double.Parse(Console.ReadLine());

        Console.WriteLine (F(n));


    }


    static double F(double X)
    {
        if (X*X <= 4)
        {return 2;}


        return 1 + F(X - ((4 * Math.Abs(X)) / X));
    }

} 