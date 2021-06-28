using System;
using System.Linq;

namespace Tarea2_Arbol_Binario
{
    class ManejadorArbol
    {
        private int nivelActual;

        public string ImprimirArbol(Nodo nodo)
        {
            //Analiza el comportamiento de una hoja
            if (!nodo.Hijos.Any())
                return nodo.Numero;
            //Analizo cuando no soy hoja
            return $"({ ImprimirArbol(nodo.Hijos[0])} {nodo.Numero}{ ImprimirArbol(nodo.Hijos[1])})";

        }

        internal int NumeroHojas(Nodo nodo)
        {
            //Analizo cuando no tengo hojas
            if (SoyUnaHoja(nodo))
                return 1;
            int totalHojas = 0;
            foreach (var hijoActual in nodo.Hijos)
            {
                totalHojas += NumeroHojas(hijoActual);
            }

            return totalHojas;

            // var hojasHijo1 = NumeroHojas(nodo.Hijos[0]);
            //var hojasHijo2 = NumeroHojas(nodo.Hijos[1]);
            // var hojasHijo3 = NumeroHojas(nodo.Hijos[2]);


            // var hojasHijoUltimo = NumeroHojas(nodo.Hijos[nodo.Hijos.Count - 1]);

            //return hojasHijo1 + hojasHijo2 + hojasHijo3 + hojasHijoUltimo;
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
            foreach (var nodoActual in nodo.Hijos)
            {
                totalNodos += NumeroNodos(nodoActual);
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

       
