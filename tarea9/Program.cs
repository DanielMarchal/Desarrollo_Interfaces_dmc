using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dame un numero: ");
        int num = Convert.ToInt32(Console.ReadLine() );

        Console.WriteLine("LA TABLA DE MULTIPLICAR DE " + num);
        Console.WriteLine(num + " *  1 = " + num*1);
        Console.WriteLine(num + " *  2 = " + num*2);
        Console.WriteLine(num + " *  3 = " + num*3);
        Console.WriteLine(num + " *  4 = " + num*4);
        Console.WriteLine(num + " *  5 = " + num*5);
        Console.WriteLine(num + " *  6 = " + num*6);
        Console.WriteLine(num + " *  7 = " + num*7);
        Console.WriteLine(num + " *  8 = " + num*8);
        Console.WriteLine(num + " *  9 = " + num*9);
        Console.WriteLine(num + " *  10 = " + num*10);
    }
}
