namespace AppAvaliacoes.Views;

public partial class IotAvaliationsDetailPage : ContentPage
{
	public IotAvaliationsDetailPage(IotAvaliationsDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
