namespace ConsoleApp4

// Mis clases se enfocan en el libro llamado Batallas Epicas en donde existen cazarecompensas, cazademonios, y cazatesoros,
//tienen muchos guerreros que luchan por el bienestar de un pueblo tranquilo y que muchos demonios quieren destruir.


{
    class Combatiente
    {
        public string Apodo { get; set; } 

        public int Edad { get; set; }

        public string TipodeGuerrero { get; set; }

        public string Experiencia { get; set; }

        public string Triunfos { get; set; }

        public string Habilidades { get; set; }

        public string Debilidades { get; set; }

        public string TipoArmada { get; set; }

        public string Defensa { get; set; }

        public string Poderes { get; set; }

        public string Saludo()
        {
            return $"Hola mi apodo es: {Apodo},tengo {Edad}, años y soy un guerrero CazaDemonios ";
        }

        public string Saludo(string nombreGuerrero)
        {
            return $"Hola me presento mi nombre es: {nombreGuerrero}";
        }

        public string Ataque()
        {
            return $"Mi habilidad para atacar es: {Habilidades} Mi debilidad es:{Debilidades}";

        }

        public string Ataque(string nombreDestreza)
        {
            return $"Mi destreza es {nombreDestreza}";
        }

        public string Proteger()
        {
            return $"Yo soy tipo de guerrero {TipodeGuerrero}, Mi defensa para protejerme es {Defensa}, Mis poderes son {Poderes}";
        }

        public string Proteger(string poderDefinitivo)
        {
            return $"Mi ataque definitivo es {poderDefinitivo}";
        }

        public string Entrenar()
        {
            return $"Yo entreno con {TipoArmada}";
        }

        public string Entrenar(string formaEntrenar)
        {
            return $"Mi forma de entrenar es: {formaEntrenar}";
        }

        public string ObtenerTitulos()
        {
            return $"Mi experiencia es {Experiencia}, y mi titulo es {Triunfos}";
        }

        public string ObtenerTitulos(string nombreTitulos)
        {
            return $"Mis titulos son basados en mi experiencia de combate: {nombreTitulos}";
        }

    }
}


