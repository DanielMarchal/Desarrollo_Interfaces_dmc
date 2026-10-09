using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dame un numero");
        byte num = Convert.ToByte(Console.ReadLine() );

        Console.WriteLine("Dame otro numero");
        byte num2 = Convert.ToByte(Console.ReadLine() );

        ushort resultado = (ushort) (num*num2);
        Console.WriteLine("El resultado de multiplicar " + num + " y " + num2 + ", es " + resultado);
    }
}
