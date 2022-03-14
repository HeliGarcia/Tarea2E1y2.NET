using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Ejercicio1
{
    internal class Pelicula
    {
        public String _nombre;
        public String _genero;

        public Pelicula(String nombre, String genero)
        {
            this._nombre = nombre;
            this._genero = genero;
        }

        public string nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }

        public string genero
        {
            set { _genero = value; }
            get { return _genero; }
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombre}, Género: {this.genero} ";
        }
    }
}
