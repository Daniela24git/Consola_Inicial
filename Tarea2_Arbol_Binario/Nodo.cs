using System.Collections.Generic;

namespace Tarea2_Arbol_Binario
{
    class Nodo
    {
        public int Id { get; set; }
        public string Numero { get; set; } //Buscar sinonimo de valor
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }
        public List<Nodo> Hijos { get; set; } = new List<Nodo>();
    }
}
