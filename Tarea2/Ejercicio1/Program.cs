using Tarea2.Ejercicio1;

//Heli Daniel García Varela.
// 4°B     12/03/2022
//Tarea 2: Ejercicio.

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



