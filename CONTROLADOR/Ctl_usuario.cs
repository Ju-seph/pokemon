using pokemon.OBJETO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon.CONTROLADOR
{
    public class Ctl_usuario
    {
        private List<Usuario> list_usuario;
        public Ctl_usuario() 
        {

            list_usuario = new List<Usuario>();
        
        }

        public void Add_Usuario(Usuario user)
        {

            list_usuario.Add(user);

        }

        public Usuario Buscar_Usuario(string nombre)
        {

            return list_usuario.Find(n => n.Nombre.Equals(nombre));

        }


        public int Id_Usuario(string nombre)
        {
            return list_usuario.FindIndex(n => n.Nombre.Equals(nombre));
        }


        public void Editar_Usuario(int id, Usuario ranking)
        {

            list_usuario[id] = ranking;

        }

        
        public void Ver_Resultados(DataGridView TABLA)
        {

            TABLA.Rows.Clear();

            foreach(Usuario ranking in list_usuario)
            {

                TABLA.Rows.Add(ranking.Nombre,ranking.Puntuacion);

            }

        }

    }
}
