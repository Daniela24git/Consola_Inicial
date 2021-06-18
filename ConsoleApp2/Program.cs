using System;

namespace Fist_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es tu nombre:");
            var nombre = Console.ReadLine();

            Console.WriteLine("Cual es tu apellido:");
            var apellido = Console.ReadLine(); 
            
            Console.WriteLine("Cual es tu direccion de domicilio:");
            var dirección = Console.ReadLine();

            Console.WriteLine("Cual es tu estado civil:");
            var EstadoCivil = Console.ReadLine();

            Console.WriteLine("Cual es tu edad:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto pesas:");
            int peso = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es tu altura:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Cual es el lugar en que nacio:");
            var LugarNac = Console.ReadLine();

            Console.WriteLine("Cual es tu pais de origen:");
            var pais = Console.ReadLine();

            Console.WriteLine("Cual es tu ciudad:");
            var ciudad = Console.ReadLine();
            DateTime fechaIngreso = DateTime.Now;

            Persona nombreP;
            nombreP = new Persona();

            Console.WriteLine("================DATOS PERSONALES====================");
            Console.WriteLine(nombreP.datosPersona(nombre, apellido, dirección));

            Console.WriteLine(nombreP.datosNum(edad, peso, altura));

            Console.WriteLine(nombreP.datosCiud(LugarNac, pais, ciudad));

            Console.WriteLine("Fecha Actual: " + fechaIngreso);
            Console.ReadKey();
        }
    }
}

//To do Datos necesarios para la persona
//Float
//Double
//DateTime
//bool

    
          


