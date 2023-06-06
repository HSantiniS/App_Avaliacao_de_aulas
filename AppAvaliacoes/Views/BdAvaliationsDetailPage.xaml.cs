namespace AppAvaliacoes.Views;

public partial class BdAvaliationsDetailPage : ContentPage
{
	public BdAvaliationsDetailPage(BdAvaliationsDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
