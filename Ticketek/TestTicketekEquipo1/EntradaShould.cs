using Boleteria.Entidades;
using Boleteria.Enums;

namespace BoleteriaTest
{
    [TestClass]
    public  class EntradaShould
    {
        [TestMethod]
        [DataRow(UbicacionEntrada.Campo, CategoriaEntrada.Vip, 1000, 3500)]
        [DataRow(UbicacionEntrada.Campo, CategoriaEntrada.Gold, 500, 2500)]
        [DataRow(UbicacionEntrada.Platea, CategoriaEntrada.Gold, 1500, 4500)]
        [DataRow(UbicacionEntrada.Campo, CategoriaEntrada.Clasic, 2000, 3500)]
        public void CalcularBienElPrecio(UbicacionEntrada ubicacion, CategoriaEntrada categoria, float precioBase, float precioEsperado)
        {
            // Given
            Cliente cliente = new Cliente("Nombre", "Apellido", 12345678, DateTime.Parse("15/05/1980"));
            Artista artista = new Artista("Luis", "Miguel", 10000000, DateTime.Parse("19/04/1970"), "Luismi");
            Show show = new Show(new Establecimiento(10, "Luna Park"), artista, DateTime.Now + TimeSpan.FromDays(3), 10, precioBase);
            // Whens
            Entrada entrada = new Entrada(show, cliente, categoria, ubicacion);
            // Then
            Assert.AreEqual(precioEsperado, entrada.PrecioTotalEnPesos);
        }
    }
}
