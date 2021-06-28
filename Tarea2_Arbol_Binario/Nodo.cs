using System.Collections.Generic;

namespace Tarea2_Arbol_Binario
{
    class Nodo
    {
        public int CodigoUnico { get; set; }
        public string Numero { get; set; } 
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }
        public List<Nodo> Hijos { get; set; } = new List<Nodo>();
    }
}
