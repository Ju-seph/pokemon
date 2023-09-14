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
       

        public Inicio()
        {
            InitializeComponent();

        }

        private void BTN_INICIAR_Click(object sender, EventArgs e)
        {

            Principal p = new Principal();
            p.Show();

        }
    }
}
