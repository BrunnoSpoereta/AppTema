namespace AppTema;

public partial class pgCadastro : ContentPage
{
	public pgCadastro()
	{
		InitializeComponent();
	}

    private void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        var usuariologado = UsuarioLogado.Instancia;
        usuariologado.Email = txtEmail.Text;
        usuariologado.Usuario = txtUsuario.Text;
        usuariologado.Senha = txtSenha.Text;

        DisplayAlert("Informação", "Cadastro realizado com sucesso", "Ok");

        //Popasync() = voltar pagina anterior
        //PushAsync() = avançar para proxima pagina
        Application.Current.MainPage.Navigation.PopAsync();
    }

    private void btnVoltar_click(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushAsync(new MainPage());
    }
}