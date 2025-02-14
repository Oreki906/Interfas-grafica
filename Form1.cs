using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Interfas_grafica_dinamica
{
    public partial class Form1 : Form
    {
        private FlowLayoutPanel flowLayoutPanel;
        private TextBox textBox;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRuta.Text))//asegura que alla algo en el texvox
            {
                string ruta=txtRuta.Text;//extrae la ruta
                flowLayoutPanel = new FlowLayoutPanel();//crea el panel donde apareceran las imagenes
                //flowlayautopanel es un control que organiza los controles de flujo orita seran las imagenes
                flowLayoutPanel.Dock = DockStyle.Fill;//dok para que utilise un espacio especifico y fill para que sea todo el espacio
                this.Controls.Add(flowLayoutPanel);// hay que darle el control del formulario
                SacarImagenes(ruta);//llamo al metodo de sacar las imagenes

                //hacer invisibles los de inicio
                btnIniciar.Visible = false;
                txtRuta.Visible = false;
            }
            else
            {
                MessageBox.Show("no se a especificado una ruta");//si no hay ruta 
            }

        }

        public void SacarImagenes(string ver)// metodo para sacar las imagenes
        {

            //el directori viene del .IO debuelve las rutas de las imagenes (no solo sirve para imagenes)
            //el var es para no especificar un tipo de variable
            //el forec es para revisar cada imagen
            foreach(var verimagen in Directory.GetFiles(ver,"*png",SearchOption.AllDirectories))//el profe ayudo con eso 
            {

                var nombre = Path.GetFileName(verimagen);
                //crear los espacios para las imagenes, opcion 2 si la prueba de los botones sale mal


                var pictureBox = new PictureBox
                {
                    //son las propiedades de la imagen que se van a mostrar, tamaño al azar de prueba y error
                    Image = Image.FromFile(verimagen),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(120,120),
                    

                };
                //evento al hacer clic en una imagen sigue el hacer grande la imagen
                pictureBox.Click += (sender, e) => verimagengrande(verimagen, nombre);
                flowLayoutPanel.Controls.Add(pictureBox);
            }
        }

        //metodo para ver la imagen grande
        //es basicamente lo mismo que el anterior peri sin usar el controlado de la organizacion 
        //orientado a una sola imagen en lugar de n  
        public void verimagengrande(string ver, string nombre)
        {
            //generar el formulario donde se vera la imagen grande
            var imagengrande = new Form
            //medidas y color del form 
            {
                Width = 800,
                Height = 600,
                BackColor= Color.Black,
                Text = nombre

            };
            //generar el espacio para la imagen seleccionada 
            var pictureBox = new PictureBox
            {
                Image = Image.FromFile(ver),
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            //agreagr y mostar la imagen 
            imagengrande.Controls.Add(pictureBox);
            imagengrande.Show();
           
        }
        //pendiente: que se muestre el nombre de la uimagen en el titulo de la pestaña grande 

    }
}
