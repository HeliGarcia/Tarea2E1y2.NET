using Tarea2.Ejercicio1;
using Tarea2.Ejercicio2;

//Heli Daniel García Varela.
// 4°B     12/03/2022
//Tarea 2: Ejercicio.
Console.WriteLine("Prueba del Ejercicio 1:\n");

Organizador organizador = new Organizador(100);

Pelicula peli1 = new Pelicula("Toy Story", "Animada");
Pelicula peli2 = new Pelicula("Shrek 2", "Animada");
Pelicula peli3 = new Pelicula("Los Vengadores", "Acción");
Pelicula peli4 = new Pelicula("John Wick", "Acción");
Pelicula peli5 = new Pelicula("Insidious", "Terror");
Pelicula peli6 = new Pelicula("Toy Story 2", "Animada");
Pelicula peli7 = new Pelicula("Me before you", "Romance");
Pelicula peli8 = new Pelicula("Ladrona de libros", "Drama");
Pelicula peli9 = new Pelicula("Midsommar", "Terror");
Pelicula peli10 = new Pelicula("About Time", "Romance");

organizador.agregarPelicula(peli1);
organizador.agregarPelicula(peli2);
organizador.agregarPelicula(peli3);
organizador.agregarPelicula(peli4);
organizador.agregarPelicula(peli5);
organizador.agregarPelicula(peli6);
organizador.agregarPelicula(peli7);
organizador.agregarPelicula(peli8);
organizador.agregarPelicula(peli9);
organizador.agregarPelicula(peli10);

organizador.MostrarPelis(organizador.ordenarAlfabeticamente());

Console.WriteLine("\n");
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Heli Daniel García Varela.
// 4°B     12/03/2022
//Tarea 2: Ejercicio 2.

Console.WriteLine("Prueba del Ejercicio 2:\n");

Contador contador = new Contador();

Producto producto1 = new Producto("Fabuloso", "Limpieza", 28.50, 50);
Producto producto2 = new Producto("Almohada", "Hogar", 135.99, 20);
Producto producto3 = new Producto("Trapeador", "Limpieza", 45.90, 5);
Producto producto4 = new Producto("Baterías", "Hogar", 12, 30);
Producto producto5 = new Producto("Jabón de manos", "Baño", 13.50, 45);
Producto producto6 = new Producto("Champú", "Baño", 48.90, 8);
Producto producto7 = new Producto("Lámpara de escritorio", "Hogar", 79.99, 20);
Producto producto8 = new Producto("Pala", "Jardín", 28.50, 50);
Producto producto9 = new Producto("Manguera", "Jardín", 28.50, 50);
Producto producto10 = new Producto("Sartén", "Cocina", 64.50, 10);
Producto producto11 = new Producto("Sal de mesa", "Cocina", 16.50, 12);
Producto producto12 = new Producto("Mantequilla", "Cocina", 29, 10);
Producto producto13 = new Producto("Escoba", "Limpieza", 34, 4);


Venta venta1 = new Venta(producto1, 2);
Venta venta2 = new Venta(producto3, 1);
Venta venta3 = new Venta(producto2, 2);
Venta venta4 = new Venta(producto1, 1);
Venta venta5 = new Venta(producto5, 3);
Venta venta6 = new Venta(producto4, 10);
Venta venta7 = new Venta(producto9, 2);
Venta venta8 = new Venta(producto10, 1);
Venta venta9 = new Venta(producto11, 2);
Venta venta10 = new Venta(producto12, 1);
Venta venta11 = new Venta(producto13, 2);
Venta venta12 = new Venta(producto6, 1);
Venta venta13 = new Venta(producto7, 1);
Venta venta14 = new Venta(producto8, 1);
Venta venta15 = new Venta(producto10, 1);

contador.agregarVenta(venta1);
contador.agregarVenta(venta2);
contador.agregarVenta(venta3);
contador.agregarVenta(venta4);
contador.agregarVenta(venta5);
contador.agregarVenta(venta6);
contador.agregarVenta(venta7);
contador.agregarVenta(venta8);
contador.agregarVenta(venta9);
contador.agregarVenta(venta10);
contador.agregarVenta(venta11);
contador.agregarVenta(venta12);
contador.agregarVenta(venta13);
contador.agregarVenta(venta14);
contador.agregarVenta(venta15);

contador.imprimirTotales(contador.calcularVentasXProducto());