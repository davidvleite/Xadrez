﻿using System;
using tabuleiro;
using xadrez;
namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarpeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarpeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarpeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                tab.colocarpeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));

                Tela.imiprimirTabuleiro(tab);

            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.Write(pos);
            Console.ReadLine();




        }
    }
}