using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Ejercicio2
{
    internal class Producto
    {
        private string _nombre;
        private string _categoria;
        private double _precio;
        private int _existencias;

        public Producto(string nombre, string categoria, double precio, int existencias)
        {
            _nombre = nombre;
            _categoria = categoria;
            _precio = precio;
            _existencias = existencias;
        }

        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }

        public string Categoria
        {
            set { _categoria = value; } 
            get { return _categoria; }
        }

        public double Precio
        {
            set { _precio = value; }
            get { return _precio; }
        }

        public int Existencias
        {
            set { _existencias = value; }
            get { return _existencias; }
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre}, Categoría: {this.Categoria}, Precio: {this.Precio}, Existencias: {this.Existencias}";
        }
    }
}
