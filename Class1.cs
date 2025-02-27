using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alejandro
{
    public class bipolar
    {
        public static Button hacerboton(string texto,int x, int y, EventHandler eventoClick)
        {
            Button btn = new Button //crea el boton
            {
                Text = texto,
                Location = new Point(x, y),//posisicion
                Size = new Size(120, 40),//tamaño
            };
            //cambia los cololres cuansdo el mause pasa por ensima del boton

            btn.MouseEnter += (sender, e) => btn.BackColor = Color.Red; 
            btn.MouseLeave += (sender, e) => btn.BackColor = Color.White;
            btn.Click += eventoClick;
            return btn;
        }
        public enum TipoDato 
        {//datos que se aceptaran
            Numero,
            Letras,
            Ambos 
        }

        public static TextBox generarTexBox(int x, int y,TipoDato tipoDato)
        {
            TextBox txt = new TextBox//crea el texbox
            {
                Location = new Point(x, y),
                Size = new Size(120, 40),
                BorderStyle = BorderStyle.FixedSingle //para al color 
            };

            // Evento para restringir
            txt.KeyPress += (sender, e) =>
            {
                bool entradaNoValida = false;
                if (tipoDato == TipoDato.Numero && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Bloquea letras si solo se permiten números
                    entradaNoValida = true;
                }
                else if (tipoDato == TipoDato.Letras && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true; // Bloquea números si solo se permiten letras
                    entradaNoValida = true;
                }
                // Si es Ambos no se hace nada
                if (entradaNoValida)
                {
                    e.Handled = true; // Bloquea la entrada
                    txt.BackColor = Color.LightCoral; // Pinta el fondo de rojo claro
                }
                else
                {
                    txt.BackColor = Color.White; // Restaura el color normal si la entrada se buelve valida 
                }
            };


            return txt;

        }

        
      

    }
    public class Verificar
    {
        public static  bool RFCvalido(string rfc)
        {
            rfc = String.Concat(rfc.Where(c => !Char.IsWhiteSpace(c)));     // Quita cualquier espacio en blanco
            rfc = rfc.ToUpper(); //cambia las letras a mayusculas

            if (Regex.IsMatch(rfc, "[A-z]{4}[0-9]{6}[A-z0-9]{3}") || Regex.IsMatch(rfc, "[A-z]{4}[0-9]{6}[A-z0-9]{2}"))
            {
                MessageBox.Show("El RFC " + rfc + " es válido");

                return true;
            }
            else
            {
                MessageBox.Show("El RFC no es válido");
                return false;
                
            }
           
        }

        public static bool cadenanumeros(string cadena)
        {
           int tamaño = cadena.Length;

            if (Regex.IsMatch(cadena, $"^[0-9]{{{tamaño}}}$"))
            {
                MessageBox.Show("la cadena solo contiene numeros");
                return true;
            }
            else
            {
                MessageBox.Show("la cadena contiene caracteres diferenstes a numeros");
                return false;
            }
        }
    }
}
