namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
                dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
	}

    private async void Sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }

}