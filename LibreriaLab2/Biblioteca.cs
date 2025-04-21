public class Biblioteca
    {
        private List<Libro> Libros;

        public Biblioteca()
        {
            Libros = new List<Libro>();
        }

        public void AddLibros(string nombre, string autor, int año, string genero)
        {
            Libro libros = new Libro(nombre, autor, año, genero);
            
            Libros.Add(libros);
        }

        public void AddLibros(Libro libro)
        {
            Libros.Add(libro);
        }
        


        public bool isAvailable(string nombre)
        {
            return Libros.Any(libro => 
            libro.GetTitle().Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }

        public List<Libro> Getlibros()
        {
            return Libros;
        }

        public int GetCount()
        {
            return Libros.Count;
        }
    }