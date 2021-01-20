using GameTOPInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameTOP
{
    public class JogoFoda
    {
        private readonly iJogador _jogadorA;

        private readonly iJogador _jogadorB;

        public JogoFoda(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;

            _jogadorB = jogadorB;
        }

        public void IniciarJogo()
        {
            Console.Write(_jogadorA.Corre());
            Console.Write(_jogadorA.Chuta());
            Console.Write(_jogadorA.Passe());

            Console.Write("\n PRÓXIMO JOGADOR \n");

            Console.Write(_jogadorB.Corre());
            Console.Write(_jogadorB.Chuta());
            Console.Write(_jogadorB.Passe());
        }
    }
}
