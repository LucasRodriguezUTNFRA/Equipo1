using Boleteria;

namespace TestTicketekEquipo1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(null, null, -1, -1)]
        public void ShouldNoAgregarEspectadorAlShow(Cliente unCliente, Show unShow, Categoria unaCategoria, Ubicacion unaUbicacion)
        {
            //public static Entrada AgregarEspectadorAlShow(Cliente unCliente, Show unShow, Categoria unaCategoria, Ubicacion unaUbicacion)

            Entrada entrada = Administracion.AgregarEspectadorAlShow(unCliente, unShow, unaCategoria, unaUbicacion);


            //Given


            //When


            //Them
            Assert.IsNull(entrada);

        }
    }
}