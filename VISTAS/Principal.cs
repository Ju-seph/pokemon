using PokeApiNet;
using pokemon.CONTROLADOR;
using pokemon.OBJETO;
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
    public partial class Principal : Form
    {
        Ctl_pokemon ctl_pokemon = new Ctl_pokemon();

        public static string usuario;
        private int score = 0;
        private string pokemon;
        private Usuario user;



        public Principal()
        {
            InitializeComponent();

            LBL_USUARIO.Text = usuario;

            user =  Inicio.ctl_usuario.Buscar_Usuario(usuario);

            LBL_SCORE.Text = "Score: " + score;

            ver_pokemon();
            
        }

        public async Task ver_pokemon()
        {

            Pokemon[] pk = await ctl_pokemon.get_ale_pokemon();

            Random ale = new Random();
            int num = ale.Next(0, pk.Length);
            IMG_POKEMON.LoadAsync(pk[num].Sprites.Other.OfficialArtwork.FrontDefault);
            pokemon = pk[num].Name;

            BTN_OPC1.Text = pk[0].Name;
            BTN_OPC2.Text = pk[1].Name;
            BTN_OPC3.Text = pk[2].Name;

        }

        private void BTN_OPC1_Click(object sender, EventArgs e)
        {
            update_score(BTN_OPC1.Text);
            ver_pokemon();
        }

        private void BTN_OPC2_Click(object sender, EventArgs e)
        {
            update_score(BTN_OPC2.Text);
            ver_pokemon();
        }

        private void BTN_OPC3_Click(object sender, EventArgs e)
        {
            update_score(BTN_OPC3.Text);
            ver_pokemon();
        }

        public void update_score(string texto_boton)
        {
            if (texto_boton.Equals(pokemon))
            {
                score += 10;

                LBL_SCORE.Text = "Score: " + score;

            }
            else
            {
                Perdiste();
            }


        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Estás Seguro de Salir?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if(result.Equals(DialogResult.Yes))
            {

                Perdiste();

            }


        }


        private void Perdiste()
        {
            MessageBox.Show("PERDISTE");

            if (user != null)
            {
                user.Puntuacion = score;
                int id = Inicio.ctl_usuario.Id_Usuario(usuario);
                Inicio.ctl_usuario.Editar_Usuario(id, user);

            }
            else
            {
                user = new Usuario();
                user.Nombre = usuario;
                user.Puntuacion = score;
                Inicio.ctl_usuario.Add_Usuario(user);
            }

            Dispose();
            Puntajes p = new Puntajes();
            p.Show();

        }


    }
}
