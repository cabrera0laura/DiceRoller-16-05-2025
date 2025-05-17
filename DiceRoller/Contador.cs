
using System.Security.Cryptography.X509Certificates;

namespace DiceRoller
{
    public class Contador
    {
        public int Sequencia;
        public int Pontos;
        public int Limite;
        public String Venceu;

        //              classe --> nomeCLasse    
        public void Jogar(Dice dadoJogador, int numeroSelecionado )
        {
            // manipular a informação do atributo

            // comparar se o resultado (facePraCima) e o mesmo que foi selecionado
            
            // Se for igual o  jogador venceu
            if (dadoJogador.FaceParaCima == numeroSelecionado)
            {
                // Se ele tinha vencido o duelo anterior, soma 1 na sequencia    
                Sequencia++;
                // soma +1 ponto
                Pontos++;
            }
            else
            {
                // Se não, 0 a sequencia.
                Sequencia = 0;
            }
            
            
         
        }
    }
}
