using System;


    class Program
    {
        static void Main(string[] args)
        {
       
        string[] aprendices;
        aprendices = new string[3];
        for (int apr = 0; apr < 2; apr++)
            {

            Console.WriteLine("por favor ingrese el nombre del aprendiz nº " + (apr + 1 ) + ": ");
            aprendices[apr] = Console.ReadLine();
        }
        for (int apr = 0; apr < 2; apr++)
            {

            Console.Write((apr + 1) + ". " + aprendices[apr]);
            Console.ReadLine();

        }
        Console.WriteLine(aprendices);
        Console.ReadKey();

        }
    }

