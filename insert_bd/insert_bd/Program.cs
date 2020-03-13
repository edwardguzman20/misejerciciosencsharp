using System;

using MySql.Data.MySqlClient;

class Program
{

    static void Main(string[] args)
    {
        usuarios clienteENCC = new usuarios();
        preguntas(clienteENCC);
        GuardarEnBD(clienteENCC);
    }
    private static void preguntas(usuarios clienteENCC)
    {

        Console.WriteLine("Ingrese su primer nombre");
        clienteENCC.PrimerNombre = Console.ReadLine();
        Console.WriteLine("Ingrese su segundo nombre");
        clienteENCC.SegundoNombre = Console.ReadLine();
        Console.WriteLine("Ingrese su primer apellido ");
        clienteENCC.PrimerApellido = Console.ReadLine();
        Console.WriteLine("Ingrese su segundo apellido ");
        clienteENCC.SegundoApellido = Console.ReadLine();
        Console.WriteLine("Ingrese su tipo de documento");
        clienteENCC.TipoDocumento = Console.ReadLine();
        Console.WriteLine("Ingrese su numero de documento");
        clienteENCC.NumeroDocumento = Console.ReadLine();
        Console.WriteLine("Ingrese su telefono ");
        clienteENCC.Telefono = Console.ReadLine();
        Console.WriteLine("Ingrese su email ");
        clienteENCC.Email = Console.ReadLine();
        Console.WriteLine("Ingrese su direccion");
        clienteENCC.Direccion = Console.ReadLine();
        Console.WriteLine("Ingrese su usuario ");
        clienteENCC.usuario = Console.ReadLine();
        Console.WriteLine("Ingrese su password ");
        clienteENCC.password = Console.ReadLine();

        


    }
    private static void GuardarEnBD(usuarios clienteENCC)
    {
        MySqlConnection conex = new MySqlConnection(

            "Server=127.0.0.1;" +
            "Database=bdencc;" +
            "Uid=root;" +
            "Pwd=;" +
            "SslMode=None"
            );

        conex.Open();

        string sql = "insert into usuarios" +
            "(PrimerNombre, SegundoNombre," +
            "PrimerApellido, SegundoApellido," +
            "TipoDocumento, NumeroDocumento," +
            "Telefono, Email," +
            "Direccion, usuario, password) " +
            "VALUES " +
            "(@PrimerNombre, @SegundoNombre," +
            "@PrimerApellido, @SegundoApellido," +
            "@TipoDocumento, @NumeroDocumento," +
            "@Telefono, @Email," +
            "@Direccion, @usuario, @password)";




        MySqlCommand cmd = new MySqlCommand(sql, conex);

        cmd.Parameters.AddWithValue("@PrimerNombre", clienteENCC.PrimerNombre);
        cmd.Parameters.AddWithValue("@SegundoNombre", clienteENCC.SegundoNombre);
        cmd.Parameters.AddWithValue("@PrimerApellido", clienteENCC.PrimerApellido);
        cmd.Parameters.AddWithValue("@SegundoApellido", clienteENCC.SegundoApellido);
        cmd.Parameters.AddWithValue("@TipoDocumento", clienteENCC.TipoDocumento);
        cmd.Parameters.AddWithValue("@NumeroDocumento", clienteENCC.NumeroDocumento);
        cmd.Parameters.AddWithValue("@Telefono", clienteENCC.Telefono);
        cmd.Parameters.AddWithValue("@Email", clienteENCC.Email);
        cmd.Parameters.AddWithValue("@Direccion", clienteENCC.Direccion);
        cmd.Parameters.AddWithValue("@usuario", clienteENCC.usuario);
        cmd.Parameters.AddWithValue("@password", clienteENCC.password);
        int numerofilas = cmd.ExecuteNonQuery();
        if(numerofilas > 0)
        {
            Console.WriteLine("usuario registrado exitosamente");
            Console.ReadLine();
        }

    }   



}

