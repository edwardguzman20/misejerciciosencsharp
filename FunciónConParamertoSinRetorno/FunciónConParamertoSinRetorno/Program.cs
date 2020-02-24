using System;

class Program
{
    static void Main(string[] args)
    {
        string nombre = "";
        string apellido = "";
        Console.WriteLine("Por ingres su nombre: ");
        nombre = Console.ReadLine();
        Console.WriteLine("Por ingres su apellido: ");
        apellido = Console.ReadLine();

        mostrarmensaje(nombre, apellido);
      
    }
    public static void mostrarmensaje(string nombreusuario, string apellidousuario)
    {
        Console.WriteLine("bienbenido, sr(a). " + nombreusuario + " " + apellidousuario);
        Console.ReadLine();
    }
}
