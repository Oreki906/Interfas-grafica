namespace AgendaPersonal
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RecuperarContrasenaPage), typeof(RecuperarContrasenaPage));
        }
    }
}
