using System;
using System.Collections;

namespace Tarea2_Arbol_Binario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola arbol Binario!");

            Nodo raiz = new Nodo()
            {
                Numero = "/",
                Hijos =
                {
                    new Nodo
                    {
                        Numero = "+",
                        Hijos =
                        {

                           new Nodo
                           {
                            Numero = "3" //hoja
                           },
                           new Nodo
                           {
                            Numero = "4" //hoja
                           }
                        }

                    },

                           new Nodo
                           {
                               Numero = "-",
                               Hijos =
                               {
                                   new Nodo
                                   {
                                       Numero = "5" //hoja
                                   },
                                   new Nodo
                                   {
                                       Numero = "8" //hoja
                                   }
                               }
                           },

                            new Nodo
                           {
                               Numero = "*",
                               Hijos =
                               {
                                   new Nodo
                                   {
                                       Numero = "4"
                                   },
                                   new Nodo
                                   {
                                       Numero = "2"
                                   }
                               }
                           },

                }

            };

            //Resultado equivalente = (4 + 3) * (5 - 8) 

            ManejadorArbol manejadorArbol = new ManejadorArbol();
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz));

            Console.WriteLine($"El valor total de numero de hojas es: {manejadorArbol.NumeroHojas(raiz)}");

            Console.WriteLine($"El valor total de numero de nodos es:{manejadorArbol.NumeroNodos(raiz)}");

            Console.WriteLine($"El valor total de numero de niveles es {manejadorArbol.Niveles(raiz)}");

        /*Queue queue = new Queue();
        queue.Enqueue(new Nodo(});
        Nodo nodo = (Nodo)queue.Dequeue();
        Nodo nodo1 = (Nodo)queue.Peek();
        private static object queue;*/
    }

    }
}
