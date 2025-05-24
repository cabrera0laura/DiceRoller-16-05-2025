using DiceRoller.ViewModels;

namespace DiceRoller.Views;

public partial class GameView : ContentPage
{
	public GameView()
	{
		BindingContext = new GameViewModel();
		InitializeComponent();
		//viewmodel da conexção com a interface.

	}
}