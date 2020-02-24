using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("==LA CALCULADORA DE EDWARD==");
        calculadora();

    }
    public static void calculadora()
    {
        int operacion = 0;
        Console.WriteLine("Ingrese la Operacion que deseas realizar");
        Int32.TryParse(Console.ReadLine(), out operacion);
          
         switch (operacion)
         {

            //case 0:
               // error();
               // Console.WriteLine(" ERROR!!!!!!!!!! ");
              //  break;
            case 1:
               Console.WriteLine(" SUMA¡¡¡ "); 
                suma();
                
                break;
            case 2:
                Console.WriteLine(" RESTA!!! ");
                resta();
                
                break;
            case 3:
                Console.WriteLine(" MULTIPLICACION!! ");
                multiplicacion();
              
                break;
            case 4:
                Console.WriteLine(" DIVICION!!! ");
                divicion();
                
                break;

         }

    }

    public static void suma()
    {

        int resultado = 0;
        int num1 = 0;
        int num2 = 0;
        Console.WriteLine("ingrese el primer numero");
        Int32.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("ingrese el segundo numero");
        Int32.TryParse(Console.ReadLine(), out num2);
        resultado = num1 + num2;
        Console.WriteLine(" El resultado de la suma es: " + num1 + " + " + num2 + " = " + resultado);
        Console.ReadLine();
    }
    public static void resta()
    {

        int resultado = 0;
        int num1 = 0;
        int num2 = 0;
        Console.WriteLine("ingrese el primer numero");
        Int32.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("ingrese el segundo numero");
        Int32.TryParse(Console.ReadLine(), out num2);
        resultado = num1 - num2;
        Console.WriteLine(" El resultado de la resta es: " + num1 + " - " + num2 + " = " + resultado);
        Console.ReadLine();
    }
    public static void multiplicacion()
    {

        int resultado = 0;
        int num1 = 0;
        int num2 = 0;
        Console.WriteLine("ingrese el primer numero");
        Int32.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("ingrese el segundo numero");
        Int32.TryParse(Console.ReadLine(), out num2);
        resultado = num1 * num2;
        Console.WriteLine(" El resultado de la multiplicacion es: " + num1 + " / " + num2 + " = " + resultado);
        Console.ReadLine();
    }
    public static void divicion()
    {

        int resultado = 0;
        int num1 = 0;
        int num2 = 0;
        Console.WriteLine("ingrese el primer numero");
        Int32.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("ingrese el segundo numero");
        Int32.TryParse(Console.ReadLine(), out num2);
        resultado = num1 / num2;
        Console.WriteLine(" El resultado de la divicion es: " + num1 + " / " + num2 + " = " + resultado);
        Console.ReadLine();
    }
}

   



