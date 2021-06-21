using System;

namespace ConsoleApp4


{
    class Cazador
    {
        public string Nombre { get; set;} 

        public string Apellido { get; set; } 

        public int Edad { get; set; } 

        public string Fortalezas { get; set; } 

        public string Proteccion { get; set; }

        public int Recompensa { get; set; }

        public string Temperamento { get; set; }

        public string Armas { get; set; }

        public string Tesoro { get; set; }

        public string Estado { get; set; }

        public string Saludar()
        {
            return $"Hola mi nombre es: {Nombre}, Mi apellido es: {Apellido}, Mi edad es Edad: {Edad}, Soy un cazador de recompensas";
            
        }

        public string Saludar(string nombreCompañero)
        {
            return $"Hola {nombreCompañero} como estas";
        }

        public string Encontrar()
        {
            var ganancia = 100;
            var resultado = Recompensa + ganancia;
            return $"Mi tesoro es de: {resultado}";
           
        }

        public string Encontrar(string recompensaTesoro)
        {
            return $"La recompensa es de: {recompensaTesoro}";
        }

        public string Defensa()
        {
            return $"Mi mejor armadura es: {Proteccion}, Mis armas preferidas son: {Armas}";
           
        }

        public string Defensa(string protejerCazador)
        {
            return $"Mi mejor protección es:{protejerCazador}";
        }

        public string Destrezas()
        {
            return $"habilidad para encontrar tesoros {Fortalezas} Buen manejo de brujula";
            
        }

        public string Destrezas(string habilidadCazador)
        {
            return $"Mi maxima destreza es {habilidadCazador}";
        }

        public string Disponibilidad()
        {
            return $"Cual es el temperamento del cazatesoros: {Temperamento} Cual es el estado del cazatesoros: {Estado}";
  
        }

        public string Disponibilidad(string nombreTemperamento)
        {
            return $"{nombreTemperamento}, es muy facil llegar a este Estado";
        }
    }
}


