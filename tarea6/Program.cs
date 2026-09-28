using System;

class Program
{
    static void Main(string[] args)
    {
        const double millas = 1609;
        Console.WriteLine("Dame un numero");
        int sc ;
        while(!int.TryParse(Console.ReadLine(),out sc) )
        {
            Console.WriteLine("Dato inválido. Introduce otro: ");
        }
        Console.WriteLine(sc + " metros son " + sc*millas + " millas" );
    }
}
