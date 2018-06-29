using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            Tabuleiro tab = new Tabuleiro(8, 8);
                 
            P = new Posicao(3, 4);
            Console.WriteLine("Posição: " + P);
            Console.ReadLine();

        }
    }
}
