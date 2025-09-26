using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDRA_SHOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "admin" && txtClave.Text == "123a")
            {

                // PASAR DE UN FORM A OTRO
                SHOP sHOP = new SHOP();
                this.Hide();
                sHOP.Show();
                MessageBox.Show(" \n Bienvenido ");

            }
            else
            {
                MessageBox.Show("LOS DATOS SON INCORRECTOS");
                txtUsuario.Clear();
                txtClave.Clear();
            }
        }
    }
}
