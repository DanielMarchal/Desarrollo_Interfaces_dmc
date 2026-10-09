using System;

class Program
{
    static void Main(string[] args)
    {
        int numero1 = 13;
        int numero2 = 6;

        double miDouble1 = 13.0;
        double miDouble2 = 6.0;

        float miFloat1 = 13.0f;
        float miFloat2 = 6.0f;

        Console.WriteLine("13 / 6 (siendo enteros) = " + numero1/numero2);
        Console.WriteLine("13.0 / 6.0 (siendo double) = " + miDouble1/miDouble2);
        Console.WriteLine("13.0f / 6.0f (siendo float) = " + miFloat1/miFloat2);

    }
}
