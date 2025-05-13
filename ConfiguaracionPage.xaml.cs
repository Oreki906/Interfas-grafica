namespace AgendaPersonal;

public partial class ConfiguaracionPage : ContentPage
{
	public ConfiguaracionPage()
	{
		InitializeComponent();
	}
    private void cambiartema(object sender, EventArgs e)
    {
        if (Application.Current?.UserAppTheme == AppTheme.Dark)
        {
            
            Application.Current.UserAppTheme = AppTheme.Light;
        }
        else
        {
           
            Application.Current!.UserAppTheme = AppTheme.Dark;
        }
    }

}