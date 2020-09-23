using System;
using GameTop.Interface;

namespace GameTop{
        public class JogoFODA{

            private readonly iJogador _jogadorA;
            private readonly iJogador _jogadorB;

            public JogoFODA(iJogador _jogador1, iJogador _jogador2){
                _jogadorA = _jogador1;
                _jogadorB = _jogador2;
            }

            public void IniciarJogo(){
                Console.WriteLine(_jogadorA.Chuta());
                Console.WriteLine(_jogadorA.Corre());
                Console.WriteLine(_jogadorA.Passa());

                Console.WriteLine(_jogadorB.Chuta());
                Console.WriteLine(_jogadorB.Corre());
                Console.WriteLine(_jogadorB.Passa());
            }
        }

}