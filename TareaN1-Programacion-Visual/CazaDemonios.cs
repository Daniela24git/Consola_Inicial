using System;

namespace ConsoleApp4


{
    class CazaDemonios
    {
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public string Experiencia { get; set; }
        public string Virtudes { get; set; }
        public int Victorias { get; set; }
        public string Personalidad { get; set; }
        public string TipoArma { get; set; }
        public string Criatura { get; set; }
        public string Poderes { get; set; }



        public string Saludo()
        {
            return $"Hola mi nombre es: {Nombre}, Mi apodo es {Apodo}";

        }

        public string Saludo(string apodoGuerrero)
        {
            return $"Hola {apodoGuerrero} tu ayudaras a cazaDemonios?";
        }

        public string Ranking()
        {
            return $"Mi practica es: {Experiencia} Mi triunfo se basa en: {Victorias}";

        }

        public string Ranking(string numeroVictorias)
        {
            return $"Mi victorias son {numeroVictorias}";

        }

        public string Invocacion()
        {
            Poderes = "Invocar";

            return $"Mi poder es: {Poderes}";
        }

        public string Invocacion(string nombreCriatura)
        {
            return $"Mi compañero criatura es {nombreCriatura}";
        }
    }
}


