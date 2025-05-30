using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.ViewModels
{
    public partial class GameViewModel : ObservableObject  // é nescessario importar, installar novamente para funcionar.
    {    //partial em toda a ViewModel

        //Toolkit realiza o get e set
        //(notificar em classe Observable,alterações)
        //fazendo anotações: 

        [ObservableProperty]//cria uma propriedade get;set
        private string diceImage;

        [ObservableProperty]
        private string nomeUsuario;

       
        public GameViewModel() {
            DiceImage = "dice1.png";
            NomeUsuario = "Eu";
        }
        //implementear um Model, Button

    }
}
