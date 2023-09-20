using pokemon.OBJETO;
using pokemon.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon.CONTROLADOR
{
    public class Ctl_usuario
    {
        private List<Usuario> list_usuario;
        private string ruta;
        public Ctl_usuario() 
        {

            list_usuario = new List<Usuario>();

            ruta = Path.Combine(Directory.GetCurrentDirectory(), "Datos");

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

        public void CrearCarpeta()
        {

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);

            }

        }

        public void Guardar_Archivo()
        {

            StreamWriter sw = new StreamWriter(ruta+"\\usuarios.txt", false);

            foreach (Usuario user in list_usuario)
            {

                sw.WriteLine(user.Nombre+";"+user.Puntuacion);
            }

            sw.Close();
        }
        public void Cargar_Archivo()
        {

            StreamReader sr = new StreamReader(File.OpenRead(ruta + "\\usuarios.txt"));

            string linea;
            while ((linea = sr.ReadLine()) != null)
            {
                Usuario user = new Usuario()
                {
                    Nombre = linea.Split(';')[0],
                    Puntuacion = Convert.ToInt32(linea.Split(';')[1])

                };
                list_usuario.Add(user);

            }

            sr.Close();

        }

    }
}
