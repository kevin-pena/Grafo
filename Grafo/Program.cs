using System;
using System.Collections.Generic;

class Grafo
{
    private int numNodos;
    private Dictionary<int, List<int>> listaAdyacencia;

    public Grafo(int numNodos)
    {
        this.numNodos = numNodos;
        listaAdyacencia = new Dictionary<int, List<int>>();
        for (int i = 0; i < numNodos; i++)
        {
            listaAdyacencia.Add(i, new List<int>());
        }
    }

    public void AgregarArista(int nodoOrigen, int nodoDestino)
    {
        listaAdyacencia[nodoOrigen].Add(nodoDestino);
        listaAdyacencia[nodoDestino].Add(nodoOrigen); // Si es un grafo no dirigido
    }

    public void ImprimirGrafo()
    {
        foreach (var nodo in listaAdyacencia)
        {
            Console.Write($"Nodo {nodo.Key}: ");
            foreach (var vecino in nodo.Value)
            {
                Console.Write($"{vecino} ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        int numNodos = 5;
        Grafo grafo = new Grafo(numNodos);

        grafo.AgregarArista(0, 1);
        grafo.AgregarArista(0, 4);
        grafo.AgregarArista(1, 2);
        grafo.AgregarArista(1, 3);
        grafo.AgregarArista(1, 4);
        grafo.AgregarArista(2, 3);
        grafo.AgregarArista(3, 4);

        Console.WriteLine("Representación del Grafo:");
        grafo.ImprimirGrafo();
    }
}
