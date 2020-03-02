using System;

    class Program
    {
        static void Main(string[] args)
        {
        aprendices apSena = new aprendices();
        apSena.nombres = "  JHON EDWARD ";
        apSena.apellidos = " GUZMAN CHAVARRO ";
        apSena.direccion = " VEREDAD HIGUERON ";
        saludo(apSena);
        }
        private  static void saludo (aprendices apSena)
        {
        Console.WriteLine(" Bienvenido. sr(a)" + apSena.nombres + apSena.apellidos);
        Console.WriteLine(" su direccion de residencia es: " + apSena.direccion);
        Console.ReadLine();

        }


  }

