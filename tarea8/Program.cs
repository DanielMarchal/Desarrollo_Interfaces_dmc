using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dame un numero");
        int num;
        num = Convert.ToInt32(Console.ReadLine() );

        Console.WriteLine("Numero: " + num + ", doble del numero: " + num*2 + 
        ", triple del numero: " + num*3);
    }
}
