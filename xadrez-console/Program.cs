﻿using System;
using tabuleiro;
using xadrez;
namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarpeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarpeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarpeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));


            Tela.imiprimirTabuleiro(tab);




            Console.ReadLine();




        }
    }
}