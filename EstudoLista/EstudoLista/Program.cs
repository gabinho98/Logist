using System;
using System.Collections.Generic;

namespace EstudoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> listaInt = new List<int>();
            listaInt.Add(10);
            listaInt.Add(20);
            listaInt.Add(5);
            listaInt.Add(1);
            listaInt.Add(50);

            List<int> outraLista = new List<int>();
            outraLista.Add(500);
            outraLista.Add(545);

            outraLista.Add(2200);

            listaInt.AddRange(outraLista);
            listaInt.Sort();

            for (int i = 0;i<listaInt.Count; i++)
            {
                Console.WriteLine(listaInt[i]);
            }
        }
    }
}
