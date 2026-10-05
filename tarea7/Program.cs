using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dame un numero");
        int num;
        num = Convert.ToInt32(Console.ReadLine() );
        Console.WriteLine("Dame otro numero");
        int num2;
        num2 = Convert.ToInt32(Console.ReadLine() );

        Console.WriteLine("Division: " + num/num2);
        Console.WriteLine("Resto: " + num % num2);

    }
}
