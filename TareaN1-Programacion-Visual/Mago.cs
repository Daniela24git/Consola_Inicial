namespace ConsoleApp4

// Mis clases se enfocan en el libro llamado Batallas Epicas en donde existen cazarecompensas, cazademonios, y cazatesoros,
//tienen muchos guerreros que luchan por el bienestar de un pueblo tranquilo y que muchos demonios quieren destruir.


{
    class Mago
    {
        public string Nombre { get; set; } 

        public string TiempoLimiteVida { get; set; }

        public string TipodeMago { get; set; }

        public string Apodo { get; set; }

        public string Magia { get; set; } 

        public string Hazañas { get; set; }

        public string Transformacion { get; set; }

        public string Habilidad { get; set; }

        public string Armas { get; set; }

        public string Estado { get; set; }

        public string Saludo()
        {
            return $"Hola soy el mago {Nombre} Me conocen como {Apodo} y soy un tipo de mago {TipodeMago}";
        }

        public string Saludo(string nombreTipoMago)
        {
            return $"Me especializo en el tipo de: {nombreTipoMago}";
        }

        public string Convertir()
        {
            return $"Me puedo transformar en: {Transformacion}, y mi tiempo de limite de vida es {TiempoLimiteVida} ";
        }
        public string Convertir(string nombreTransformación)
        {
            return $"Mi tiempo de vida se agota cada vez que me transformo en {nombreTransformación}";
        }

        public string Conjurar()
        {
            return $"Mis hazañas son: {Hazañas}, Y puedo conjurar mi magia {Magia}";
        }

        public string Conjurar(string nombreMagia)
        {
            return $"Mis hazañas se basan en el uso de la magia: {nombreMagia}";
        }

        public string Atacar()
        {
            return $"Mi hablidad es: {Habilidad} y se basa en el uso de {Armas}";
        }

        public string Atacar(string nombreDestreza)
        {
            return $"Mi destreza para atacar es: {nombreDestreza}";
        }

        public string Dormir()
        {

            return $"Mi forma de descanzar es: {Estado}";
        }

        public string Dormir(string nombreEstado)
        {
            return $"Recupero mi poder al estar: {nombreEstado} ";
        }
    }
}






