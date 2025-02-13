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
            if (!string.IsNullOrEmpty(txtRuta.Text))
            {
                string ruta=txtRuta.Text;
                flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Dock = DockStyle.Fill;//dok para que utilise un espacio especifico y fill para que sea todo el espacio


                //hacer invisibles los de inicio
                btnIniciar.Visible = false;
                txtRuta.Visible = false;
            }
            else
            {
                MessageBox.Show("no se a especificado una ruta");
            }

        }
    }
}
