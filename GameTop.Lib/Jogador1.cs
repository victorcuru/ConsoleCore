using System;
using GameTop.Interface;

namespace GameTop.Lib{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome; 

        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        public string Chuta()
        {
           return $"{_Nome} está Chutando";
        }

        public string Corre()
        {
           return $"{_Nome} está Correndo";
        }

         public string Passa()
        {
            return $"{_Nome} está Passando";
        }
    }

}