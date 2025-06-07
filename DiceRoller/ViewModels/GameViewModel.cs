using CommunityToolkit.Mvvm.ComponentModel;
using DiceRoller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.ViewModels
{ //partial --> foi feito en outro lugar.
    public partial class GameViewModel : ObservableObject  // é nescessario importar, installar novamente para funcionar.
    {    //partial em toda a ViewModel

        //Toolkit realiza o get e set
        //(notificar em classe Observable,alterações)
        //fazendo anotações: 

        [ObservableProperty]//cria uma propriedade get;set  informações que quero interagir
        private string diceImage;

        [ObservableProperty]
        private string nomeUsuario;

        [ObservableProperty]
        private int selectedValue;

        [ObservableProperty]
        private string resultado;
       
        public GameViewModel() {
            DiceImage = "dice1.png";
            NomeUsuario = "Eu";
            JogarCommand = new Command(Jogar); // jogarCommand executa jogar
        }

        public ICommand JogarCommand { private set; get; } //vincula com public void Jogar()
       

        //implementear um Model, Button
        
        //comando que representa a logica de Sortear
        public void Jogar()
        {
            //Sortear um número --- conversa com o 
            Dice dice = new Dice();
            dice.Sortear();
            if (dice.FaceParaCima == SelectedValue)
            {
                Resultado = "Vitória";
            }
            else
            {
                Resultado = "Derrota";
            }
            //Verificar qual face esta selecionada
            //Verifica se o usuario escolheu certo
            //Exibir uma mensagem na tela
        }
    }
}
