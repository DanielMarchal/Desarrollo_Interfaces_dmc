using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dame el radio del circulo");
        double radio = Convert.ToDouble(Console.ReadLine() );
        double area = Math.Round(Math.PI*Math.Pow(radio, 2), 2);

        Console.WriteLine("El area del circulo cuyo radio es " + radio + ", es " + area );

    }
}
