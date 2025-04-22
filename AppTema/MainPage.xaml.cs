using System.Security.Principal;

namespace AppTema
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            var usuarioLogado = UsuarioLogado.Instancia;
            //Validar usuário e senha
            if (txtUsuario.Text == null && txtSenha.Text == null)
            {

            }
            else
            {
                if (txtUsuario.Text == usuarioLogado.Usuario && txtSenha.Text == usuarioLogado.Senha)
                {
                    /*DisplayAlert("Informação!", "Acesso permitido.", "Ok");*/

                    //Vamos armazenar o usuario logado na classe singleton

                    //criando variavel para acessar a classe single

                    //Chamar a tela principal
                    Application.Current.MainPage.Navigation.PushAsync(new pgPaginaInicial());
                }
                else
                {
                    DisplayAlert("Atenção!", "Usuário ou Senha inválido", "Ok");
                }
            }
        }

        private void lblRegistrar_Tapped(object sender, TappedEventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new pgCadastro());
        }
    }

}
