using System;

    class Program
    {
        static void Main(string[] args)
        {
             string nombreusuario = "";
             Console.Write("por favor, ingresa su nombre: ");
             nombreusuario = Console.ReadLine();
             


             while (nombreusuario != "FIN")
             {
               Console.WriteLine("bienbenido, sr(a) " + nombreusuario + ".");
               Console.WriteLine("");
               Console.Write("por favor, ingresa su nombre: ");
               nombreusuario = Console.ReadLine();
               
             }
             Console.WriteLine("fin del programa");
             Console.ReadLine();
        }
    }

