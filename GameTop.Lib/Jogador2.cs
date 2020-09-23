using System;
using GameTop.Interface;

namespace GameTop.Lib {

    public class Jogador2 : iJogador
    {

        public string Chuta()
        {
            return "Maradona chutou";    
        }

        public string Corre()
        {
            return "Maradona correu";    
        }

        public string Passa()
        {
            return "Maradona passou";    
        }

    }
}