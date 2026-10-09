using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 3;
        int b = ++a;
        Console.WriteLine("b = " + b);
        int c = a++;
        Console.WriteLine("c = " + c);
        b = b*3;
        Console.WriteLine("b = " + b);
        a = a*2;
        Console.WriteLine("a = " + a);
    }
}
