using System;

    class Program
    {
        static void Main(string[] args)
        {
          aprendiz apSena = new aprendiz();
          preguntas(apSena);
        }
        private static void preguntas(aprendiz apSena)
        {
        Console.WriteLine("===REGISTRO DE APRENDICES===");

        Console.WriteLine("Ingrese su tipo de identificacion");
        apSena.tipoidentificacion = Console.ReadLine();
        Console.WriteLine("Ingrese su numero de identificacion");
        apSena.numeroidentificacion = Console.ReadLine();
        Console.WriteLine("Ingrese sus nombres ");
        apSena.nombres = Console.ReadLine();
        Console.WriteLine("Ingrese sus apllidos ");
        apSena.apellidos = Console.ReadLine();
        Console.WriteLine("Ingrese su fecha de nacimiento: (DD/MM/AAAA)");
        apSena.fechanacimeinto = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Ingrese su genero");
        apSena.genero = Console.ReadLine();
        Console.WriteLine("Ingrese su id ficha ");
        apSena.idficha = Console.ReadLine();
        Console.WriteLine("Ingrese su estado civil: ");
        apSena.estadocivil = Console.ReadLine();
        Console.WriteLine("Ingrese su direccion ");
        apSena.direccion = Console.ReadLine();
        Console.WriteLine("Ingrese su RH");
        apSena.RH = Console.ReadLine();
        Console.WriteLine("Ingrese su email ");
        apSena.email = Console.ReadLine();
        Console.WriteLine("Ingrese su telefono ");
        apSena.telefono = Console.ReadLine();
        Console.WriteLine("Ingrese su tipo de poblacion");
        apSena.tipopoblacion = Console.ReadLine();
        Console.WriteLine("Ingrese su departamento de residencia");
        apSena.departamentoresidencia = Console.ReadLine();
        Console.WriteLine("Ingrese su municipio de residencia ");
        apSena.municipioresidencia = Console.ReadLine();
        Console.WriteLine("Ingrese su departamento de nacimiento: ");
        apSena.departamentonacimiento = Console.ReadLine();
        Console.WriteLine("Ingrese su municipio de nacimeinto");
        apSena.municipionacimiento = Console.ReadLine();
        Console.WriteLine("Ingrese su estrato ");
        apSena.estrato = Console.ReadLine();
        Console.WriteLine("Ingrese su EPS: ");
        apSena.EPS = Console.ReadLine();
        Console.WriteLine("Ingrese su tipo de regimen ");
        apSena.tiporegimen = Console.ReadLine();
        Console.WriteLine("Ingrese su fecha de ingreso: (DD/MM/AAAA)");
        apSena.fechaingreso = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Ingrese su discapacidad");
        apSena.discapacidad = Console.ReadLine();
        Console.WriteLine("ingrese su libreta militar");
        apSena.libretamilitar = Console.ReadLine();

        Console.ReadLine();
                

        mostrarrespuestas(apSena);
        


        }
        private static void mostrarrespuestas(aprendiz apSena)
        {
        Console.WriteLine("======ESTOS SON TUS DATOS===== ");

        Console.WriteLine("tipo de identificacion: " + apSena.tipoidentificacion);
        Console.WriteLine("numero de identificacion: " + apSena.numeroidentificacion);
        Console.WriteLine("su mombre es: " + apSena.nombres);
        Console.WriteLine("su apellido es: " + apSena.apellidos);
        Console.WriteLine("su fecha de naciemiento es: " + apSena.fechanacimeinto.Day + "/" + 
        apSena.fechanacimeinto.Month + "/" + apSena.fechanacimeinto.Year);
        Console.WriteLine("su genero es: " + apSena.genero);
        Console.WriteLine("su id ficha es: " + apSena.idficha);
        Console.WriteLine("su estado civil " + apSena.estadocivil);
        Console.WriteLine("su direccion es: " + apSena.direccion);
        Console.WriteLine("su RH ES : " + apSena.RH);
        Console.WriteLine("su correo es: " + apSena.email);
        Console.WriteLine("su telefono es: " + apSena.telefono);
        Console.WriteLine("tipo de poblacion: " + apSena.tipopoblacion);
        Console.WriteLine("su departamento de residencia es: " + apSena.departamentoresidencia);
        Console.WriteLine("su municipio de residencia es " + apSena.municipioresidencia);
        Console.WriteLine("su departamento de nacimiento es " + apSena.departamentonacimiento);
        Console.WriteLine("su municipio de nacimeinto es : " + apSena.municipionacimiento);
        Console.WriteLine("su estrato es: " + apSena.estrato);
        Console.WriteLine("su EPS es: " + apSena.EPS);
        Console.WriteLine("su tipo de regimen: " + apSena.tiporegimen);
        Console.WriteLine("su fecha de ingreso es: " + apSena.fechaingreso.Day + "/" +
        apSena.fechaingreso.Month + "/" + apSena.fechaingreso.Year);
        Console.WriteLine("su discapacidad es: " + apSena.discapacidad);
        Console.WriteLine("libreta militar: " + apSena.libretamilitar);
        Console.ReadLine();


        }
         
       




    }

