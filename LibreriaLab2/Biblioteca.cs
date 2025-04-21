public class Biblioteca
    {
        private List<string> Libros;

        public Biblioteca()
        {
            Libros = new List<string>();
        }

        public void AddLibros(string libros)
        {
            Libros.Add(libros);
        }

        public bool isAvailable(string libros)
        {
            return Libros.Contains(libros);
        }

        public List<string> Getlibros()
        {
            return Libros;
        }

        public int GetCount()
        {
            return Libros.Count;
        }
    }