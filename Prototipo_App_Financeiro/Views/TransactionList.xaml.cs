
namespace Prototipo_App_Financeiro.Views;

public partial class TransactionList : ContentPage
{
	public TransactionList()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		//Navigation.PushAsync(new TransactionAdd());
		App.Current.MainPage = new TransactionAdd();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        App.Current.MainPage = new TransactionEdit();
    }
}