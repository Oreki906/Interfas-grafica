namespace AgendaPersonal;

public partial class CrearContactoPage : ContentPage
{
	public CrearContactoPage()
	{
		InitializeComponent();
	}
    private void Guardar(object sender, EventArgs e)
    {
        var nuevoContacto = new Contacto
        {
            Nombre = nombreEntry.Text,
            Telefono = telefonoEntry.Text,
            Correo = correoEntry.Text,
            Direccion = direccionEntry.Text
        };

        ContactoService.Contactos.Add(nuevoContacto);

        // Opcional: mostrar mensaje
        DisplayAlert("Éxito", "Contacto guardado", "OK");

        // Opcional: Navegar a la lista de contactos
        Navigation.PushAsync(new ContactosPage());
    }

}