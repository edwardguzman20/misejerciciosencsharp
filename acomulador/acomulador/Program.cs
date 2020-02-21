using System;

class Program
{
    static void Main(string[] args)
    {
        int valorproducto = 0;
        string respuesta = "";
        int cantidadproducto = 0;
        int totalproducto = 0;
        int numeroproducto = 0;
        int totalcompra = 0;
        Console.WriteLine("BIENVENIDOS AL SUPERMERCADO SENA-YAMBORO ");
        Console.WriteLine("");
        Console.WriteLine("Desea agregar productos al carrito Y/N");
        respuesta = (Console.ReadLine());
        while (respuesta == "Y")
        {
            numeroproducto++;
            Console.WriteLine("ingrese el valor del producto N. " + numeroproducto + ": ");
            valorproducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Ingrese la cantidad del producto N. " + numeroproducto + ": ");
            cantidadproducto = Convert.ToInt32(Console.ReadLine());
            totalproducto = valorproducto * cantidadproducto;
            totalcompra += totalproducto;
            Console.WriteLine("Desea agregar mas productos al carrito Y/N");
            respuesta = (Console.ReadLine());
        }

        Console.WriteLine("valor total de la factura: " + totalcompra);
        Console.WriteLine(" MUCHAS GRACIAS POR SU COMPRA SR(A) " );

        Console.ReadLine();
    }
}

