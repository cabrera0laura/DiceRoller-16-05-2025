using DiceRoller.ViewModels;

namespace DiceRoller.Views;

public partial class GameView : ContentPage
{
	public GameView()
	{
		BindingContext = new GameViewModel();
		InitializeComponent();
		//viewmodel da conex��o com a interface.

	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}