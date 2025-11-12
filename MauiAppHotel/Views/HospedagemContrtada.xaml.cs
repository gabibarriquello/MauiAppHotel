namespace MauiAppHotel.Views;

public partial class HospedagemContrtada : ContentPage

{
	public HospedagemContrtada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		}catch (Exception ex)
		{
			DisplayAlert("Ops", "Algo deu errado, tente novamente", "OK");
		}



    }
}