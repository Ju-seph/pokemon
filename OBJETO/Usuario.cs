using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon.OBJETO
{
    public class Usuario
    {

        private string nombre;
        private int puntuacion;

        public Usuario() {

            puntuacion = 0;
        
        }
        
        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntuacion { get => puntuacion; set => puntuacion = value; }

    }
}
