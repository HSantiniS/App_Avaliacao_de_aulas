namespace AppAvaliacoes.Views;

public partial class UserAccountPage : ContentPage
{
	public UserAccountPage(UserAccountViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
