namespace DiceRoller.Models
{
    public class Dice
    {
        //       private String faceParaBaixo;  
        //       public string FaceParaBaixo { get => faceParaBaixo; set => faceParaBaixo = value; } //*

        //Atributos -Properties
        public int FaceParaBaixo;
        public int FaceParaCima; // posso escrever diretamente o atributo com letra maiuscula o VS2022 entende. 
        public int QuantidadeDeFaces;
        public bool Resultado;

        public Dice(int faces)
        {
            QuantidadeDeFaces = faces;
        }

        //Métodos
        public void Sortear()
        {
            //Gero um numero aleatorio
            Random random = new Random();
            //jogo esse numero na face para cima
            FaceParaCima = random.Next(1, 7);

            //Soma magica = 1 + maior quantidadeDeFaces (7).
            FaceParaBaixo = 1+ QuantidadeDeFaces - FaceParaCima ;
            //Calcular a face para baixo
        }
    }
}
