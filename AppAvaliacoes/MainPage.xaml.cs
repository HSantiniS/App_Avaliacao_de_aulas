namespace AppAvaliacoes.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    private void SignUpBtn_Clicked(object sender, EventArgs e)
    {

    }

    private void EntrarBtn_Clicked(object sender, EventArgs e)
    {

    }
}
