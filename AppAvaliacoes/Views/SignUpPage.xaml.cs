namespace AppAvaliacoes.Views;

public partial class SignUpPage : ContentPage
{
    public SignUpPage(SignUpViewModel viewModel)
	{
		InitializeComponent(); 
		BindingContext = viewModel;
	}

    private async void LogInBtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Shell.Current.GoToAsync("..");
        }catch(Exception ex) { }
    }
}
