namespace MauiAppHotel.Views;

public partial class ContratacaodaHospedagem : ContentPage
{
	public ContratacaodaHospedagem()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Sobre());
    }
}