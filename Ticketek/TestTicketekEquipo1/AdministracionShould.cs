using Boleteria;

namespace TestTicketekEquipo1
{
    [TestClass]
    public class AdministracionShould
    {
        [TestMethod]
        [DataRow(null, null, -1, -1)]
        public void NotAgregarEspectadorAlShow(Cliente unCliente, Show unShow, Categoria unaCategoria, Ubicacion unaUbicacion)
        {
            //public static Entrada AgregarEspectadorAlShow(Cliente unCliente, Show unShow, Categoria unaCategoria, Ubicacion unaUbicacion)

            Entrada entrada = Administracion.AgregarEspectadorAlShow(unCliente, unShow, unaCategoria, unaUbicacion);


            //Given


            //When


            //Them
            Assert.IsNull(entrada);

        }

        [TestMethod]
        public void AgregarEspectadorAlShow()
        {
            // Given
            Cliente cliente = new Cliente("Nombre", "Apellido", 12345678, DateTime.Parse("15/05/1980"));
            Artista artista = new Artista("Luis", "Miguel", 10000000, DateTime.Parse("19/04/1970"), "Luismi");
            Show show = new Show("Luna Park", artista, DateTime.Now + TimeSpan.FromDays(3), 10, 1000);
            // When
            Administracion.AgregarEspectadorAlShow(cliente, show, Categoria.Vip, Ubicacion.Campo);
            // Then
            Assert.IsTrue(show.CantidadEspectadores > 0);
            Assert.AreEqual(cliente, show.espectadores[0]);
        }

        [TestMethod]
        [DataRow(Ubicacion.Campo, Categoria.Vip, 1000, 3500)]
        [DataRow(Ubicacion.Campo, Categoria.Gold, 500, 2500)]
        [DataRow(Ubicacion.Platea, Categoria.Gold, 1500, 4500)]
        [DataRow(Ubicacion.Campo, Categoria.Clasic, 2000, 3500)]
        public void DevolverUnaEntradaValida(Ubicacion ubicacion, Categoria categoria, float precioBase, float precioEsperado)
        {
            // Given - Arrange
            Cliente cliente = new Cliente("Nombre", "Apellido", 12345678, DateTime.Parse("15/05/1980"));
            Artista artista = new Artista("Luis", "Miguel", 10000000, DateTime.Parse("19/04/1970"), "Luismi");
            Show show = new Show("Luna Park", artista, DateTime.Now + TimeSpan.FromDays(3), 10, precioBase);
            // When - Act
            Entrada entrada = Administracion.AgregarEspectadorAlShow(cliente, show, categoria, ubicacion);
            // Then - Assert
            Assert.IsNotNull(entrada);
            Assert.AreEqual(show, entrada.Show);
            Assert.AreEqual(cliente, entrada.Cliente);
            Assert.AreEqual(precioEsperado, entrada.PrecioTotalEnPesos);
        }


    }
}