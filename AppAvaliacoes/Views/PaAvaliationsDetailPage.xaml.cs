namespace AppAvaliacoes.Views;

public partial class PaAvaliationsDetailPage : ContentPage
{
	public PaAvaliationsDetailPage(PaAvaliationsDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
