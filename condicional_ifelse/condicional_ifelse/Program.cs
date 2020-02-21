using System;

class Program
{
    static void Main(string[] args)
    {
        int edad = 14;


        if (edad > 15)

        {
            Console.WriteLine("BIENVENIDO");
            Console.ReadKey();
        }
            
        else
        {
            Console.WriteLine("Lo sentimos. No puede ingresar al sistema");
            Console.ReadKey();
        }
    }
}

