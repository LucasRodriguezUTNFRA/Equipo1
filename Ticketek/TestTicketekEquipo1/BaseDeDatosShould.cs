using Boleteria;
using Boleteria.Entidades;
using Boleteria.Interfaces;

namespace BoleteriaTest
{
    [TestClass]
    public class BaseDeDatosShould
    {
        [TestMethod]
        public void TenerListasValidas()
        {
            // Given
            IBaseDeDatos baseDeDatos = new BaseDeDatos();
            // When
            List<Cliente> clientes = baseDeDatos.Clientes;
            List<Artista> artistas = baseDeDatos.Artistas;
            List<Empleado> empleados = baseDeDatos.Empleados;
            // Then
            Assert.IsNotNull(clientes);
            Assert.IsNotNull(artistas);
            Assert.IsNotNull(empleados);
        }

        [TestMethod]
        public void GuardarCliente()
        {
            // Given
            IBaseDeDatos baseDeDatos = new BaseDeDatos();
            Cliente cliente = new Cliente("Nombre", "Apellido", 41313131, DateTime.Now);
            // When
            baseDeDatos.GuardarPersona(cliente);
            // Then
            Assert.IsTrue(baseDeDatos.Clientes.Count > 0);
            Assert.AreEqual(cliente, baseDeDatos.Clientes[0]);
        }

        [TestMethod]
        public void GuardarArista()
        {
            // Given
            IBaseDeDatos baseDeDatos = new BaseDeDatos();
            Artista artista = new Artista("Nombre", "Apellido", 41313131, DateTime.Now, "Nombre artistico");
            // When
            baseDeDatos.GuardarPersona(artista);
            // Then
            Assert.IsTrue(baseDeDatos.Artistas.Count > 0);
            Assert.AreEqual(artista, baseDeDatos.Artistas[0]);
        }

        [TestMethod]
        public void GuardarEmpleado()
        {
            // Given
            IBaseDeDatos baseDeDatos = new BaseDeDatos();
            Empleado empleado = new Empleado("Nombre", "Apellido", 41313131, DateTime.Now);
            // When
            baseDeDatos.GuardarPersona(empleado);
            // Then
            Assert.IsTrue(baseDeDatos.Empleados.Count > 0);
            Assert.AreEqual(empleado, baseDeDatos.Empleados[0]);
        }
    }
}
