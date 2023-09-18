using PokeApiNet;
using pokemon.CONTROLADOR;
using pokemon.VISTAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon
{

    public partial class Inicio : Form
    {

        public static Ctl_usuario ctl_usuario = new Ctl_usuario();
        
        public Inicio()
        {
            InitializeComponent();

            BTN_INICIAR.Enabled = false;

        }

        private void BTN_INICIAR_Click_1(object sender, EventArgs e)
        {

            if(!TXT_NOMBRE.Text.Trim().Equals(""))
            {
                Principal.usuario = TXT_NOMBRE.Text;
                Principal p = new Principal();
                TXT_NOMBRE.Text = "";
                p.Show();

                Hide();

            }
            else
            {
                MessageBox.Show("INGRESA TU NOMBRE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void TXT_NOMBRE_TextChanged(object sender, EventArgs e)
        {

            BTN_INICIAR.Enabled = TXT_NOMBRE.Text.Length > 3;

        }

        private void BTN_RANKING_Click(object sender, EventArgs e)
        {

            Puntajes p = new Puntajes();
            p.Show();

            Hide();

        }
    }
}
