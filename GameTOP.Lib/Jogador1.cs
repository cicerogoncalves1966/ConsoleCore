using GameTop.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        //Chuta
        public string Chuta()
        {
            return $"{_Nome} está Chutando!\n";
        }
        //Corre
        public string Corre()
        {
            return $"{_Nome} está Correndo!\n";
        }
        //Passa
        public string Passa()
        {
            return $"{_Nome} está Passando!\n";
        }
    }
}