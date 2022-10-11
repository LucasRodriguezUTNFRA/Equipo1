using Boleteria;

namespace TestTicketekEquipo1
{
    [TestClass]
    public  class EntradaShould
    {
        [TestMethod]
        [DataRow(Ubicacion.Campo, Categoria.Vip, 1000, 3500)]
        [DataRow(Ubicacion.Campo, Categoria.Gold, 500, 2500)]
        [DataRow(Ubicacion.Platea, Categoria.Gold, 1500, 4500)]
        [DataRow(Ubicacion.Campo, Categoria.Clasic, 2000, 3500)]
        public void CalcularBienElPrecio(Categoria categoria, Ubicacion ubicacion, float precioBase, float precioEsperado)
        {
            // Given
            Cliente cliente = new Cliente("Nombre", "Apellido", 12345678, DateTime.Parse("15/05/1980"));
            Artista artista = new Artista("Luis", "Miguel", 10000000, DateTime.Parse("19/04/1970"), "Luismi");
            Show show = new Show("Luna Park", artista, DateTime.Now + TimeSpan.FromDays(3), 10, precioBase);
            // When
            Entrada entrada = new Entrada(show, cliente, categoria, ubicacion);
            // Then
            Assert.AreEqual(precioEsperado, entrada.PrecioTotalEnPesos);
        }
    }
}
