using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Ejercicio2
{
    internal class Contador
    {
        private int _numerodeVentasActual;
        private List<Venta> listaVentas = new List<Venta>();

        public Contador()
        {
            _numerodeVentasActual = 0;
        }

        public void agregarVenta(Venta venta)
        {
            if (!(venta is null))
            {
                _numerodeVentasActual = _numerodeVentasActual + 1;
                listaVentas.Add(venta);
            }
        }

        public List<int> calcularVentasXProducto()
        {
            List <int> totales = new List<int>();
            int totalprodLimpieza = 0;
            int totalprodJardin = 0;
            int totalprodCocina = 0;
            int totalprodBaño = 0;
            int totalprodHogar = 0;

            for (int i = 0; i < listaVentas.Count; i++)
            {
                if (listaVentas[i].Producto.Categoria == "Limpieza")
                {
                    totalprodLimpieza = totalprodLimpieza + listaVentas[i].Cantidad;
                }
                else if (listaVentas[i].Producto.Categoria == "Jardín")
                {
                    totalprodJardin = totalprodJardin + listaVentas[i].Cantidad;
                }
                else if (listaVentas[i].Producto.Categoria == "Cocina")
                {
                    totalprodCocina = totalprodCocina + listaVentas[i].Cantidad;
                }
                else if (listaVentas[i].Producto.Categoria == "Baño")
                {
                    totalprodBaño = totalprodBaño + listaVentas[i].Cantidad;
                }
                else if (listaVentas[i].Producto.Categoria == "Hogar")
                {
                    totalprodHogar = totalprodHogar + listaVentas[i].Cantidad;
                }
            }
            totales.Add(totalprodLimpieza);
            totales.Add(totalprodJardin);
            totales.Add(totalprodCocina);
            totales.Add(totalprodBaño);
            totales.Add(totalprodHogar);
            
            return totales;
        }

        public void imprimirTotales(List<int> totales)
        {
            Console.WriteLine("\nLos productos vendidos según la categoría fueron: ");
            List <string> listaCategorias = new List<string>();
            listaCategorias.Add("Limpieza: ");
            listaCategorias.Add("Jardín: ");
            listaCategorias.Add("Cocina: ");
            listaCategorias.Add("Baño: ");
            listaCategorias.Add("Hogar: ");
            if (_numerodeVentasActual != 0)
            {
                for (int posicion = 0; posicion < totales.Count(); posicion++)
                {
                    Console.WriteLine(listaCategorias[posicion]);
                    Console.WriteLine(totales[posicion] + "\n");
             
                }
            }

            else
            {
                Console.WriteLine("No hay ventas.\n");
            }
        }
    }
}
