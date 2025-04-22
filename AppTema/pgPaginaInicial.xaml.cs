namespace AppTema;

public partial class pgPaginaInicial : ContentPage
{
	public pgPaginaInicial()
	{
		InitializeComponent();
	}

    private void btnAlterarTemaClick(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushAsync(new pgAlterarTema());
    }

    private void btnTelaVeiculoClick(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushAsync(new pgTemaVeiculo());
    }
}