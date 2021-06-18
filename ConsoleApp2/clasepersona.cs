
class Persona
{

    public string datosPersona(string nombre, string apellido, string dirección)
    {
        return "Nombres: " + nombre + " " + apellido + " " + dirección + ".";
    }
    public string datosNum(int edad, int peso, double altura)
    {
        return "Tienes: " + edad + " años\n Tu peso es:" + peso + " Kg.\n Tu estatura es: " + altura + "cm.";
    }
    public string datosCiud(string LugarNac, string pais, string ciudad)
    {
        return "Estado civil: " + LugarNac + "\n Pais: " + pais + "\n Ciudad: " + ciudad + ".";
    }

}
