// See https://aka.ms/new-console-template for more information



Biblioteca biblioteca = new Biblioteca();
biblioteca.AddLibros("El Quijote", "Miguel de Cervantes", 1605, "Novela");
biblioteca.AddLibros("Cien años de soledad", "Gabriel García Márquez", 1967, "Novela");
biblioteca.AddLibros("El Gran Gatsby", "F. Scott Fitzgerald", 1925, "Novela");

Console.WriteLine("Libros en la librería:");
foreach (var libro in biblioteca.Getlibros())
{
    Console.WriteLine(libro);
}

Console.WriteLine("¿Está disponible 'El Quijote'? " + biblioteca.isAvailable("El Quijote"));
Console.WriteLine("¿Está disponible 'El Gran Gatsby'? " + biblioteca.isAvailable("El Gran Gatsby"));