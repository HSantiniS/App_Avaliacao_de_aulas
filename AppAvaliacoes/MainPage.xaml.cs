namespace AppAvaliacoes.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

	//Não está funcionando --> mudar página
	private async Task OnSignUpLabelClickedAsync( EventArgs e)
	{
        await Shell.Current.GoToAsync("SignUpPage");
    }

    private async Task EntrarBtn_ClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("PaAvaliationsPage");
    }
}
