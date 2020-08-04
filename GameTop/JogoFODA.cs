using GameTop.Interface;

namespace GameTop
{
    public class JogoFODA
    {
        private readonly iJogador _jogadorA;

        private readonly iJogador _jogadorB;

        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            _jogadorA = jogador1;
            _jogadorB = jogador2;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Passa());

            System.Console.Write("\nPróximo jogador!!\n\n");

            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Passa());
        }
    }
}