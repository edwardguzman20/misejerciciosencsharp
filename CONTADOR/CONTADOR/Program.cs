using System;

class Program
{
    static void Main(string[] args)
    {
        string PRODUCTO = "";
        int numerousuario = 1;
        Console.WriteLine("SUPERMERCADO EL SENA-YAMBORO ");
        Console.WriteLine("");
        Console.Write("por favor, ingresa el producto: ");
        PRODUCTO = Console.ReadLine();



        while (PRODUCTO != "FIN")
        {
            Console.WriteLine("producto nº " + numerousuario + ".");
            Console.WriteLine("");
            Console.Write("por favor, ingresa el producto: ");
            PRODUCTO = Console.ReadLine();
            numerousuario += 1;

        }
        Console.WriteLine("fin del programa");
        Console.ReadLine();
    }
}

