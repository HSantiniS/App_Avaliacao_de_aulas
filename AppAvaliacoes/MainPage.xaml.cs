using AppAvaliacoes.ViewModels;

namespace AppAvaliacoes.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    private async void SignUpBtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Shell.Current.GoToAsync(nameof(SignUpPage));
        }
        catch (Exception ex)
        {

        }
    }

    private async void EntrarBtn_Clicked(object sender, EventArgs e)
    {
        

        try
        {
            await Shell.Current.GoToAsync(nameof(SignUpPage));
        } catch (Exception ex) { }
    }
}
