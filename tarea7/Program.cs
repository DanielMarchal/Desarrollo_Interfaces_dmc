using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dame un numero");
        int num;
        while(!int.TryParse(Console.ReadLine(), out num) )
        {
            Console.WriteLine("Numero incorrecto, introduce otro: ");
        }
        Console.WriteLine("Dame otro numero");
        int num2;
        while(!int.TryParse(Console.ReadLine(), out num2) )
        {
            Console.WriteLine("Numero incorrecto, introduce otro: ");
        }
        Console.WriteLine("Division: " + num/num2);
        Console.WriteLine("Resto: " + num % num2);

    }
}