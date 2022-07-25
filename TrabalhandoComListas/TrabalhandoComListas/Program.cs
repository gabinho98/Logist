using System;

namespace TrabalhandoComListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Jogo j1 = new Jogo();
            j1.Id = 1;
            j1.Nome = "Magistic";
            j1.Descricao = "Cartas Mágicas";
            j1.Console = tipoConsole.Pc;
            j1.Genero = tipoGenero.Estrategia;

            Console.WriteLine( j1.Nome);

        }
    }
}
