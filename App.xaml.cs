namespace AgendaPersonal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Siempre comenzar con Login (elimina cualquier lógica previa)
            MainPage = new NavigationPage(new Login());
        }
    }
}
