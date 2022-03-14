using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2.Ejercicio1;


/*
 *Heli Daniel García Varela
 *4°B
 *Nota: He tenido problemas con el funcionamiento de mi computadora, ya que ha tenido un rendimiento muy malo últimamente, VisualStudio se traba y cierra
 *con frecuencia, lo que me ha dificultado hacer en teimpo y forma el programa.
 *También, debido a mi falta de práctica en C#, no sé manejar aún de la manera correcta los contenidos de las listas, por lo que no sé
 *cómo ordenarlos por orden alfabético o por algún otro tipo de orden.
 */

namespace Tarea2.Ejercicio1
{
    internal class Organizador
    {
        private int _limitePeliculas;
        private int _numeroActualPeliculas;
        private List<Pelicula> Estante = new List<Pelicula>();
        

        public Organizador(int limitePeliculas)
        {
            this._limitePeliculas = limitePeliculas;
            this._numeroActualPeliculas = -1;

        }

        public void agregarPelicula(Pelicula peli)
        {
            if (!lleno() && !(peli is null))
            {
                _numeroActualPeliculas = _numeroActualPeliculas + 1;
                Estante.Add(peli);
            }
        }

        public List<Pelicula> ordenarAlfabeticamente()
        {
            List<Pelicula> listaOrdenada = new List<Pelicula>();
            Estante.OrderBy(nombre => nombre._nombre);
            foreach (Pelicula peli in Estante)
            {
                listaOrdenada.Add(peli);
            }
            Console.WriteLine("\nSe ordenaron las películas en orden alfabetico.\n");
            return listaOrdenada;
        }


        public Boolean lleno()
        {
            if (_numeroActualPeliculas == (_limitePeliculas - 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Eliminar(Pelicula peli)
        {
            int posicion = 0;
            while (posicion <= _numeroActualPeliculas && peli.Equals(Estante[posicion]))
            {
                posicion = posicion + 1;
            }
            if (posicion > _numeroActualPeliculas)
            {
                Console.WriteLine("No se encontró la película.\n");
            }
            else
            {
                Console.WriteLine("Se eliminó: " + Estante[posicion] + "\n");
                _numeroActualPeliculas--;
                for (int movimiento = posicion; movimiento <= _numeroActualPeliculas; movimiento++)
                {
                    Estante[movimiento] = Estante[movimiento + 1];
                }
            }
        }

        public void MostrarPelis(List<Pelicula> Estante)
        {
            if (_numeroActualPeliculas != -1)
            {
                for (int posicion = _numeroActualPeliculas; posicion >= 0; posicion--)
                {//Imprime la lista.
                    Console.WriteLine(Estante[posicion] + "\n");
                }
            }

            else
            {
                Console.WriteLine("No hay películas en la estante.\n");
            }
        }
    }
}
