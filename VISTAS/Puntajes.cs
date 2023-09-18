using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon.VISTAS
{
    public partial class Puntajes : Form
    {
        public Puntajes()
        {
            InitializeComponent();

            Inicio.ctl_usuario.Ver_Resultados(TABLA);

        }

        private void BTN_INICIO_Click(object sender, EventArgs e)
        {
            Dispose();
            Program.form.Show();
        }

        private void Puntajes_FormClosing(object sender, FormClosingEventArgs e)
        {

            Program.form.Show();

        }
    }
}
