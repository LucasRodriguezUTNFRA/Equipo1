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
            Show show = new Show(new Establecimiento(10, "Luna Park"), artista, DateTime.Now + TimeSpan.FromDays(3), 10, 1000);
            // When
            Administracion.AgregarEspectadorAlShow(cliente, show, Categoria.Vip, Ubicacion.Campo);
            // Then
            Assert.IsTrue(show.CantidadEspectadores > 0);
            Assert.AreEqual(cliente, show.espectadores[0]);
        }

        [TestMethod]
        public void DevolverUnaEntradaValida()
        {
            // Given - Arrange
            Cliente cliente = new Cliente("Nombre", "Apellido", 12345678, DateTime.Parse("15/05/1980"));
            Artista artista = new Artista("Luis", "Miguel", 10000000, DateTime.Parse("19/04/1970"), "Luismi");
            Show show = new Show(new Establecimiento(10, "Luna Park"), artista, DateTime.Now + TimeSpan.FromDays(3), 10, 1000);
            // When - Act
            Entrada entrada = Administracion.AgregarEspectadorAlShow(cliente, show, Categoria.Gold, Ubicacion.Campo);
            // Then - Assert
            Assert.IsNotNull(entrada);
            Assert.AreEqual(show, entrada.Show);
            Assert.AreEqual(cliente, entrada.Cliente);
        }

        [TestMethod]
        [ExpectedException(typeof(ShowSinCapacidadException))]
        public void NotAgregarEspectadorAShowSinCapacidad()
        {
            // Given
            Cliente cliente = new Cliente("Nombre", "Apellido", 12345678, DateTime.Parse("15/05/1980"));
            Artista artista = new Artista("Luis", "Miguel", 10000000, DateTime.Parse("19/04/1970"), "Luismi");
            Show show = new Show(new Establecimiento(10, "Luna Park"), artista, DateTime.Now + TimeSpan.FromDays(3), 10, 1000);
            // When
            // Then
            Administracion.AgregarEspectadorAlShow(cliente, show, Categoria.Gold, Ubicacion.Campo);
        }

        [TestMethod]
        public void AgregarEstablecimiento()
        {
            // Given
            Establecimiento establecimiento = new Establecimiento(100, "Teatro Opera");
            // When
            Administracion.AgregarEstablecimiento(establecimiento);
            // Then
            Assert.IsNotNull(Administracion.Establecimientos);
            Assert.AreEqual(Administracion.Establecimientos, Administracion.Establecimientos[0]);

        }

        [TestMethod]
        public void AgregarCliente()
        {
            // Given
            Cliente cliente = new Cliente("Nombre", "Apellido", 1003333, DateTime.Parse("10/03/1960"));
            // When
            Administracion.AgregarCliente(cliente);
            // Then
            Assert.IsNotNull(Administracion.Clientes);
            Assert.AreEqual(cliente, Administracion.Clientes[0]);
        }
    }
}