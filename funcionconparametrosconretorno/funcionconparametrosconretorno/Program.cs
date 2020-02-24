using System;

class Program
{
    static void Main(string[] args)
    {
        int numeronotas = 0;
        Console.WriteLine("==== UNIVERSIDAD AnTONIO NARIÑO====");
        Console.WriteLine("ingrese el numero de notas: ");
        Int32.TryParse(Console.ReadLine(), out numeronotas);
        string resultado = calcularnotas(numeronotas);
    }
    public static string calcularnotas(int numeronotas)
    {
        decimal nota = 0;
        decimal promedio = 0;
        decimal sumanotas = 0;
        for (int i = 1; i <= numeronotas; i++)
        {

            Console.Write("ingrese la nota N. " + i + ": ");
            decimal.TryParse(Console.ReadLine(), out nota);
            sumanotas += nota++;
            promedio = sumanotas / i;
        }
        Console.WriteLine("la suma de las notas es: " + sumanotas);
        Console.ReadLine();
        Console.WriteLine("el promedio de las notas es: " + promedio);
        Console.ReadLine();
        if (promedio >= 6)
        {
            Console.WriteLine(" señor, usted aprobo el semestre con el siguiente  promedio: {0:F2}", promedio);
            Console.Write("paso el semestre !!!!!FELICITACIONES!!!!!!");
            Console.ReadLine();


        }
        else
        {

            Console.WriteLine(" señor, usted reprobo el semestre en la universidad con el siguiente  promedio: {0:F2} ", promedio);
            Console.Write("señor perdio el semestre y la plta de sus papas  !!!!! FELICITACIONES vago vaya venda bonice!!!!!");
            Console.ReadLine();

        }
        return "";
    }

}




