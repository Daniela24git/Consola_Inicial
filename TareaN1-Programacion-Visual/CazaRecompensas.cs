using System;

namespace ConsoleApp4


{
    class CazaRecompensas

    {
        public string Nombre { get; set;}
        
        public string Apellido { get; set;}
        
        public int Edad { get; set; }                   
        
        public string Estado { get; set; } // El caza recompezas estaria en su estado Activo, o Inactivo
                                           
        public string Habilidad { get; set; } //Habilidad con armas, habilidad para cobrar
                                           
        public string EstatusEconomico { get; set; } //Rico o pobre
                                           
        public int Record { get; set; }  //Cuantas capturas tienen al año

        public string Entrenamiento { get; set; }       
                                           
        public string TipoArma { get; set; } //Tipo de arma que utiliza

        public string Personalidad {get; set;}  



    public string Saludar()
    {
        return $"Hola mi nombre es: {Nombre}, Mi apellido es {Apellido} Soy un cazarecompensas y mi personaliad es {Personalidad}";
                
    }

    public string Saludar(string nombreClave)
        {
            return $"Hola {nombreClave}, como estas";
        }

    public string Cobrar()
    {
        var bono = 2;
        var captura = Record * bono;
        EstatusEconomico = $"Mi ganancia es: {captura}";
        return $"Mi ganancia en total es de {EstatusEconomico}";
    }

    public string Cobrar(string nombreTesoro)
     {
         return $"Mi bono por cobrar es por un: {nombreTesoro} ";
     }

    public string Entrenar()
    {
        return $"Mi entrenamiento es: {Entrenamiento} Mi edad es {Edad} ";
       
    }

    public string Entrenar(string nombreEntrenamiento)
        {
            return $"Mi entrenamiento es {Entrenamiento} basado en {nombreEntrenamiento}";
        }
    public string Disparar()
    {
        var balas = 10;
        TipoArma = "pistola";
        Habilidad = "Agilidad con la pistola";
        var reduccionBalas = balas - 1;
       return $"Tengo {Habilidad}, Me quedan {reduccionBalas}, Balas de {TipoArma}";
      
    }

    public string Disparar(string nombreArma)
     {
            return $"He disparado con una arma {nombreArma}";
     }

    public string Disponible()
    {
        return $"En estos momentos estoy de viaje{Estado}";
     
    }

    public string Disponible(string nombreEstado)
     {
        return $"Mi estado es: {nombreEstado}";
     }
}
}
