using System;
using System.Linq;

namespace Tarea2_Arbol_Binario
{
    class ControladorArbol
    {
        private int nivelActual;

        public string Arbol(Nodo nodo)
        {
            
            if (!nodo.Hijos.Any())
                return nodo.Numero;
            
            return $"({ Arbol(nodo.Hijos[0])} {nodo.Numero}{ Arbol(nodo.Hijos[1])})";

        }


        internal int NumeroHojas(Nodo nodo)
        {
            
            if (SoyUnaHoja(nodo))
                return 1;
            int totalHojas = 0;
            foreach (var hijo in nodo.Hijos)
            {
                totalHojas += NumeroHojas(hijo);
            }

            return totalHojas;

            }

        private static bool SoyUnaHoja(Nodo nodo)
        {
            return !nodo.Hijos.Any();
        }

        internal int NumeroNodos(Nodo nodo)
        {
            if (SoyUnaHoja(nodo))
                return 1;

            int totalNodos = 0;
            foreach (var nodod in nodo.Hijos)
            {
                totalNodos += NumeroNodos(nodod);
            }

            return totalNodos + 1;
        }

        internal int Niveles(Nodo nodo)
        {
            if (SoyUnaHoja(nodo))
                return 0;

            int totalNiveles = 0;
            foreach (var Nodo in nodo.Hijos)
            {
                totalNiveles = Niveles(Nodo);
            }

            return totalNiveles + 2;
        }
    }
}

       
