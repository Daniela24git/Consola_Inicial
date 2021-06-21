using System;

namespace ConsoleApp4

// Mis clases se enfocan en el libro llamado Batallas Epicas en donde existen cazarecompensas, cazademonios, y cazatesoros,
//tienen muchos guerreros que luchan por el bienestar de un pueblo tranquilo y que muchos demonios quieren destruir.


{
    partial class Program
    {


        static void Main(string[] args)
        {
            var CazaRecompensas = new Cazador
            {

                Nombre = "Pepito",

                Apellido = "Perez",

                Edad = 35,

                Fortalezas = "Resistente",

                Proteccion = "Chaleco antibalas",

                Recompensa = 200,

                Temperamento = "Explosivo",

                Armas = "Pistola",

                Estado = "Activo" // El cazarecompensas esta en estado activo es decir que esta disponible para ejercer su oficio. 

            };

            Console.WriteLine(CazaRecompensas.Saludar());
            Console.WriteLine("¿Como se llama el compañero del Cazador?");

            var resultado = Console.ReadLine();
            Console.WriteLine(CazaRecompensas.Saludar(resultado));

            Console.WriteLine(CazaRecompensas.Encontrar());
            Console.WriteLine("¿Que tesoro encontraste?");

            var Tesoro = Console.ReadLine();
            Console.WriteLine(CazaRecompensas.Encontrar(Tesoro));

            Console.WriteLine(CazaRecompensas.Defensa());
            Console.WriteLine("¿Que clase de escudo usas?");

            var Escudo = Console.ReadLine();
            Console.WriteLine(CazaRecompensas.Defensa(Escudo));

            Console.WriteLine(CazaRecompensas.Destrezas());
            Console.WriteLine("¿Que clase de destrea adicional manejas ?");

            var destreza = Console.ReadLine();
            Console.WriteLine(CazaRecompensas.Destrezas(destreza));

            Console.WriteLine(CazaRecompensas.Disponibilidad());
            Console.WriteLine("¿En que animo se encuentra?");

            var animo = Console.ReadLine();
            Console.WriteLine(CazaRecompensas.Disponibilidad(animo));


            var CazaDemonios = new Combatiente
            {
                Apodo = "El eterno superviviente",

                Edad = 30,

                TipodeGuerrero = "Guerreo Sangriento",

                Experiencia = "Con nivel alto",

                Triunfos = "Conquista de una Legión",

                Habilidades = "Usar dos espadas a la vez",

                Debilidades = "No tiene control sobre su energia",

                TipoArmada = "Espada de llamas",

                Defensa = "Escudo de tortuga",

                Poderes = "Tecnica con circulo letal "

            };

            Console.WriteLine("----------------COMBATIENTE--------------------");

            Console.WriteLine(CazaDemonios.Saludo());
            Console.WriteLine("¿Cual es el nombre del Guerrero?");

            var nombre = Console.ReadLine();
            Console.WriteLine(CazaDemonios.Saludo(nombre));

            Console.WriteLine(CazaDemonios.Ataque());
            Console.WriteLine("¿Con que arma desearia atacar?");

            var ataque = Console.ReadLine();
            Console.WriteLine(CazaDemonios.Ataque(ataque));

            Console.WriteLine(CazaDemonios.Proteger());
            Console.WriteLine("¿Que ataque definitivo utilizarias para defenderte?");

            var defensa = Console.ReadLine();
            Console.WriteLine(CazaDemonios.Proteger(defensa));

            Console.WriteLine(CazaDemonios.Entrenar());
            Console.WriteLine("¿Con que tipo de arma entrenaria el guerrero?");

            var arma = Console.ReadLine();
            Console.WriteLine(CazaDemonios.Entrenar(arma));

            Console.WriteLine(CazaDemonios.ObtenerTitulos());
            Console.WriteLine("¿Que titulo le pondria al Guerrero?");

            var titulo = Console.ReadLine();
            Console.WriteLine(CazaDemonios.ObtenerTitulos(titulo));


            var Combatiente = new Mago
            {
                Nombre = "Luan",

                TiempoLimiteVida = "Limitado",

                TipodeMago = "Mago poderoso",

                Apodo = "Indestructible",

                Magia = "Magia poderosa con rayos",

                Hazañas = "Protejer una ciudad con un muro magico",

                Transformacion = "Transforma en Tigre",

                Habilidad = "Magia arcana",

                Armas = "Baston de Fuego",

                Estado = "Descansando"

            };


            Console.WriteLine("----------------MAGO--------------------");


            Console.WriteLine(Combatiente.Saludo());
            Console.WriteLine("¿Que tipo de mago desearias ser?");

            var mago = Console.ReadLine();
            Console.WriteLine(Combatiente.Saludo(mago));

            Console.WriteLine(Combatiente.Convertir());
            Console.WriteLine("¿En que desearia transformarse el mago?");

            var transformacion = Console.ReadLine();
            Console.WriteLine(Combatiente.Convertir(transformacion));

            Console.WriteLine(Combatiente.Conjurar());
            Console.WriteLine("¿Que tipo de criatura quiere invocar?");

            var criatura = Console.ReadLine();
            Console.WriteLine(Combatiente.Conjurar(criatura));

            Console.WriteLine(Combatiente.Atacar());
            Console.WriteLine("¿Cual seria el poder magico a utilizar?");

            var poder = Console.ReadLine();
            Console.WriteLine(Combatiente.Atacar(poder));

            Console.WriteLine(Combatiente.Dormir());
            Console.WriteLine("¿Que desea que el mago haga?");

            var accion = Console.ReadLine();
            Console.WriteLine(Combatiente.Dormir(accion));

        }


    }
}

      
            
            


