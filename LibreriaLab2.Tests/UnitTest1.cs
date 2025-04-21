namespace LibreriaLab2.Tests;
using NUnit.Framework;
using LibreriaLab2;

public class Tests
{
    private Biblioteca _libreria;

    [SetUp]
    public void Setup()
    {
        _libreria = new Biblioteca();
        
    }

    [Test]
    public void AñadirLibro_ResultadoCorrecto()
    {

        _libreria.AddLibros("El Quijote", "Miguel de Cervantes", 1605, "Novela");
        _libreria.AddLibros("El Principito", "Antoine de Saint-Exupéry", 1943, "Novela");

        var Cantidadlibros = _libreria.Getlibros;

        Assert.That(_libreria.GetCount(), Is.EqualTo(2), $"Esperaba 2 libros, pero se encontraron {_libreria.GetCount()}.");

        
    }
    [Test]
    public void AñadirLibro_ResultadoIncorrecto()
    {

    }


    [Test]
    public void ComprobarLibro_ResultadoCorrecto()
    {
        var libro = new Libro("El Quijote", "Miguel de Cervantes", 1605, "Novela");

        _libreria.AddLibros(libro);


        //Assert.That(valor a obtener, condicion, mensajeSiFalla);
        Assert.That(_libreria.isAvailable(libro.GetTitle()), Is.True, $"El libro {libro} debería estar disponible.");
 
        
    }
    [Test]
    public void ComprobarLibro_ResultadoIncorrecto()
    {
        
    }

}


