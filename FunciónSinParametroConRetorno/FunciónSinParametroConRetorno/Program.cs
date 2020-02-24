using System;

class Program
{
    static decimal precioproducto = 0;
    static decimal precioproductoconiva = 0;
    static int categoriaproducto = 0;
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor, ingresa el costo de producto ");
        decimal.TryParse(Console.ReadLine(), out precioproducto);
        Console.WriteLine("Por favor, ingresa la categoria de producto ");
        int.TryParse(Console.ReadLine(), out categoriaproducto);
        if (categoriaproducto == 1)
        {
            precioproductoconiva = porcentaje5();
            Console.WriteLine("el precio del producto con iva es: {0:C}" , precioproductoconiva);
        }
        if (categoriaproducto == 2)
        {
            precioproductoconiva = porcentaje5();
            Console.WriteLine("el precio del producto con iva es: {0:C}", precioproductoconiva);
        }
        if (categoriaproducto == 3)
        {
            precioproductoconiva = porcentaje5();
            Console.WriteLine("el precio del producto con iva es: {0:C}", precioproductoconiva);
        }
        if (categoriaproducto == 4)
        {
            precioproductoconiva = porcentaje5();
            Console.WriteLine("el precio del producto con iva es: {0:C}", precioproductoconiva);
        }
        Console.ReadLine();
    }
    public static decimal porcentaje0()
    {

        decimal aux = 0.00m;
        precioproducto += precioproducto * aux;
        return precioproducto;

    }
    public static decimal porcentaje5()
    {

        decimal aux = 0.05m;
        precioproducto += precioproducto * aux;
        return precioproducto;

    }
    public static decimal porcentaje10()
    {

        decimal aux = 0.1m;
        precioproducto += precioproducto * aux;
        return precioproducto;

    }
    public static decimal porcentaje19()
    {

        decimal aux = 0.19m;
        precioproducto += precioproducto * aux;
        return precioproducto;

    }




}
