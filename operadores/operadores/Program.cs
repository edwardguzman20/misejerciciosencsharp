using System;
  class Program
    {
        static void Main(string[] args)
        {
        string[] operaciones = new string[5];
        operaciones[0] = "Suma";
        operaciones[1] = "Resta";
        operaciones[2] = "Multiplicacion";
        operaciones[3] = "Dividicion";
        operaciones[4] = "Error";
        string  respuestausuario;
        int num1 = 0;
        int num2 = 0;
        int operacion;
        int resultado = 0;

        Console.WriteLine("desea realizar algun tipo de operacion: (Y/N)");
        respuestausuario = Console.ReadLine();
            while(respuestausuario == "Y")
            {

            Console.Write("ingresa el primer entero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingresa el segundo entero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

                for (int op = 0; op <=3; op++)
                {

                Console.WriteLine((op + 1) + ". " + operaciones[op]);

                }

            Console.WriteLine("seleccione la operaion que desea realizar");
            operacion = Convert.ToInt32(Console.ReadLine());
            switch(operacion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = num1 / num2;
                    break;
                default:
                     Console.WriteLine( "no selecciono una operacion");
                     break;
            }
            Console.WriteLine("El resultado de la operacion es: " + resultado);
            Console.WriteLine("Desea realizar otra operacion: (Y/N)");
            respuestausuario = Console.ReadLine();

            }
        Console.WriteLine("fin del programa");
        Console.ReadLine();
        }
     }

