using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace AgendaPersonal
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
    }
    public static class ContactoService
    {
        public static ObservableCollection<Contacto> Contactos { get; } = new ObservableCollection<Contacto>();
    }
}
