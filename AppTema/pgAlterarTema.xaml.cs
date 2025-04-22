using AppTema.Resources.Styles;

namespace AppTema;

public partial class pgAlterarTema : ContentPage
{
	public pgAlterarTema()
	{
		InitializeComponent();
	}

    private void btnClaroClick(object sender, EventArgs e)
    {
        Application.Current.Resources.MergedDictionaries.Clear();
        Application.Current.Resources.MergedDictionaries.Add(new LightTheme());
    }

    private void btnEscuroClick(object sender, EventArgs e)
    {
        Application.Current.Resources.MergedDictionaries.Clear();
        Application.Current.Resources.MergedDictionaries.Add(new DarkTheme());
    }
}