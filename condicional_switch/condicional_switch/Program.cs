using System;
class Program
{
    static void Main(string[] args)
    {
        int day = 0;
        int mun = 0;
        string meslestras = "";
        int year = 0;

        Console.Write("Ingrese su dia de nacimiento: ");
        day = Convert.ToInt32(Console.ReadLine());
        Console.Write("");
        Console.Write("ingrese su mes de nacimiento: ");
        mun = Convert.ToInt32(Console.ReadLine());
        Console.Write("");
        Console.Write("ingrese su año de nacimiento: ");
        year = Convert.ToInt32(Console.ReadLine());

        switch(mun)
        {
            case 1:
                meslestras = "enero";
                break;
            case 2:
                meslestras = "febrero";
                break;

            case 3:
                meslestras = "marzo";
                break;
            case 4:
                meslestras = "abril";
                break;
            case 5:
                meslestras = "mayo";
                break;
            case 6:
                meslestras = "junio";
                break;
            case 7:
                meslestras = "julio";
                break;
            case 8:
                meslestras = "agosto";
                break;
            case 9:
                meslestras = "septiembre";
                break;

            case 10:
                meslestras = "octubre";
                break;
            case 11:
                meslestras = "noviembre";
                break;
            case 12:
                meslestras = "diciembre";
                break;
            default:
                meslestras = "Error";
                break;
             
        }

        if (meslestras == "ERROR!!!")
        {
            Console.WriteLine(" la fecha ingresada es incorrecta");
            Console.ReadLine();
        }

        Console.WriteLine("usted nacio el " + day + " de " + meslestras + " del " + year);
        Console.ReadLine();
    }
}

