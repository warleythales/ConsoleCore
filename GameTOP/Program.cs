using GameTopLib;
using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(
                new Jogador1(),
                new Jogador3());
            jogo.IniciarJogo();
        }
    }
    
}