using Moq;
using NUnit.Framework;

public class LibreriaIntegracion
{
    private Biblioteca _libreria;
    private Mock<IBiblioteca> _mockBiblioteca;

    [SetUp]
    public void Setup()
    {
        _libreria = new Biblioteca();
        _mockBiblioteca = new Mock<IBiblioteca>();
    }

    [Test]
    public void AñadirLibro_ResultadoCorrecto()
    {
        // Arrange
        var libro1 = new Libro("El Quijote", "Miguel de Cervantes", 1605, "Novela");
        var libro2 = new Libro("El Principito", "Antoine de Saint-Exupéry", 1943, "Novela");

        // Act
        _libreria.AddLibros(libro1);
        _libreria.AddLibros(libro2);

        // Assert
        Assert.That(_libreria.GetCount(), Is.EqualTo(2), $"Esperaba 2 libros, pero se encontraron {_libreria.GetCount()}.");
        
        //Verificamos que se llamo la funcion
        _mockBiblioteca.Verify(lambda => lambda.AddLibros(libro1), Times.Once);
    }
}