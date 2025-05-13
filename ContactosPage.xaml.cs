using System.Collections.ObjectModel;

namespace AgendaPersonal;

public partial class ContactosPage : ContentPage
{
	public ContactosPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

    public ObservableCollection<Contacto> Contactos => ContactoService.Contactos;
}
