using GameTOPInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameTopLib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Teste Chuta \n";
        }

        public string Corre()
        {
            return "Teste Corre \n";
        }

        public string Passe()
        {
            return "Teste Passe \n";
        }
    }
}
