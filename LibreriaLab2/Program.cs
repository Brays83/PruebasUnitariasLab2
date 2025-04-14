// See https://aka.ms/new-console-template for more information



Biblioteca biblioteca = new Biblioteca();
biblioteca.AddLibros("El Quijote");
biblioteca.AddLibros("El Principito");
biblioteca.AddLibros("Cien años de soledad");
biblioteca.AddLibros("El amor en los tiempos del cólera");

Console.WriteLine("Libros en la librería:");
foreach (var libro in biblioteca.Getlibros())
{
    Console.WriteLine(libro);
}

Console.WriteLine("¿Está disponible 'El Quijote'? " + biblioteca.isAvailable("El Quijote"));
Console.WriteLine("¿Está disponible 'El Gran Gatsby'? " + biblioteca.isAvailable("El Gran Gatsby"));