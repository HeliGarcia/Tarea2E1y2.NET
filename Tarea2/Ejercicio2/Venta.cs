using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2.Ejercicio2;

namespace Tarea2.Ejercicio2
{
    internal class Venta
    {
        private Producto _producto;
        private int _cantidad;

        public Venta(Producto producto, int cantidad)
        {
            _producto = producto;
            _cantidad = cantidad;
        }

        public Producto Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
    }
}
