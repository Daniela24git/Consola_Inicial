using System;
using ClassLibrary1;
using Interface;
using Personaje;
using Ninject;
using DoAction;
using System.Reflection;
namespace Inyecciones_Dependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un nombre");
            var name = Console.ReadLine();

            Console.WriteLine("Ingresa una habilidad");
            var skill = Console.ReadLine();

            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            IArma nuevaArma = kernel.Get<IArma>();

            PersonajeNew personaje = new PersonajeNew(name, skill);
            Usuario user = new Usuario(nuevaArma);
            user.Jugar(personaje);
        }
    }
}
