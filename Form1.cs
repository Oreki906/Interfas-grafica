using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alejandro;

namespace prueba2 
{
    public partial class Form1 : Form
    {
        private TextBox txtSolonumeros;
        public Form1()
        {
            InitializeComponent();

            Button boton = bipolar.hacerboton("verificar",50, 150, Boton_Click);
            Controls.Add(boton);

            txtSolonumeros = bipolar.generarTexBox(50, 50, bipolar.TipoDato.Ambos);//cargar elexion de caracters letras, numeros o ambos
            Controls.Add(txtSolonumeros);

           
            
        }
        

        public void Boton_Click(object sender, EventArgs e)
        {
            
         string rfc = txtSolonumeros.Text;
            bool esValido =Verificar.RFCvalido(rfc);


         string cadena = real.Text;
            bool esvalido = Verificar.cadenanumeros(cadena);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
