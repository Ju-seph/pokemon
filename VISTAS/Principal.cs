using PokeApiNet;
using pokemon.CONTROLADOR;
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

        public Principal()
        {
            InitializeComponent();

            obtener_pikachu_aleatorio();
        }

        public async Task obtener_pikachu_nombre()
        {
            Pokemon pk = await ctl_pokemon.get_pokemonAsync("pikachu");

            IMAGEN.LoadAsync(pk.Sprites.Other.OfficialArtwork.FrontDefault);

        }

        public async Task obtener_pikachu_aleatorio()
        {

            Random r = new Random();
            int aleatorio = r.Next(1,100);

            Pokemon pk = await ctl_pokemon.get_pokemonAsync(aleatorio);

            IMAGEN.LoadAsync(pk.Sprites.Other.OfficialArtwork.FrontDefault);

            LBL_NOMBRE.Text = pk.Name;

        }

        private void Principal_KeyDown(object sender, KeyEventArgs e)
        {
            int actualX = LBL_NOMBRE.Location.X;
            int actualY = LBL_NOMBRE.Location.Y;


            switch (e.KeyCode)
            {

                case Keys.Up:
                    LBL_NOMBRE.Location = new Point(actualX, actualY-5);
                    break;

                case Keys.Down:
                    LBL_NOMBRE.Location = new Point(actualX, actualY+5);
                    break;

                case Keys.Left:
                    LBL_NOMBRE.Location = new Point(actualX - 5, actualY);
                    break;

                case Keys.Right:


                    if(actualX != Location.X)
                    {

                        LBL_NOMBRE.Location = new Point(actualX + 5, actualY);
                    }

                    break;

            }


        }
    }
}
