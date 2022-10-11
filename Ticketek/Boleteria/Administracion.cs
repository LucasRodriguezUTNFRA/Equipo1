using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria
{
    public static class Administracion
    {
        private static List<Show> shows;
        private static List<Artista> artistas;
        private static List<Entrada> entradas;
        private static List<Cliente> clientes;
        private static List<Empleado> empleados;

        static Administracion()
        {
            shows = new List<Show>();
            artistas = new List<Artista>();
            entradas = new List<Entrada>();
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
            CargarArtistas();
        }

        public static List<Show> Shows { get => shows;}
        public static List<Artista> Artistas { get => artistas;}
        public static List<Establecimiento> Establecimientos { get; set; }
        public static List<Cliente> Clientes { get; set; }

        public static void AgregarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public static Entrada AgregarEspectadorAlShow(Cliente unCliente, Show unShow, Categoria unaCategoria, Ubicacion unaUbicacion)
        {
            // Validar si el show tiene una capacidad disponible
            if (unCliente is null || unShow is null || unaCategoria < 0 || unaUbicacion < 0)
            {
                return null;
            }


            unShow.espectadores.Add(unCliente);

            return new Entrada(unShow, unCliente, unaCategoria, unaUbicacion);
        }

        public static void AgregarEstablecimiento(Establecimiento establecimiento)
        {
            throw new NotImplementedException();
        }

        static void CargarArtistas()
        {
            artistas.Add(new Artista("Luis", "Miguel", 16437443, new DateTime(1970, 04, 19, 23, 00, 00), "Luismi"));
            artistas.Add(new Artista("Gonzalo", "Conde", 36411333, new DateTime(1998, 08, 29, 22, 00, 00), "Bizarrap"));
            artistas.Add(new Artista("Marshall", "Mathers", 20337332, new DateTime(1972, 10, 17, 21, 00, 00), "EMINEM"));
        }

    }
}
