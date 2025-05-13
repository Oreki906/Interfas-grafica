namespace AgendaPersonal;

    public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
    }

protected override bool OnBackButtonPressed()
{
    Application.Current.Quit();
    return true;
}

    private async void TapGestureRecognizerPwd_Tapped(object sender, TappedEventArgs e)
{
    try
    {
        // Verifica si Shell está inicializado
        if (Shell.Current != null)
        {
            await Shell.Current.GoToAsync("RecuperarContrasenaPage");
        }
        else
        {
            await Navigation.PushAsync(new RecuperarContrasenaPage());
        }
    }
    catch (Exception ex)
    {
        await DisplayAlert("Error", $"No se pudo abrir: {ex.Message}", "OK");
    }
}
    private async void TapGestureRecognizerReg_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            if (Shell.Current != null)
            {
                await Shell.Current.GoToAsync("registro"); 
            }
            else
            {
                await Navigation.PushAsync(new RegistroPage());
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"No se pudo abrir: {ex.Message}", "OK");
        }
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        if (IsCredentialCorrect(Username.Text, Password.Text))
        {
            try
            {
                // Guarda el estado de autenticación
                Preferences.Set("UsuarioActual", Username.Text.Trim());
                await SecureStorage.SetAsync("hasAuth", "true");

                // Cambia toda la MainPage de la aplicación
                Application.Current.MainPage = new AppShell();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
        else
        {
            await DisplayAlert("Error", "Credenciales incorrectas", "OK");
        }
    }


    bool IsCredentialCorrect(string username, string password)
{
    return Username.Text == "admin" && Password.Text == "1234";
}



    }

