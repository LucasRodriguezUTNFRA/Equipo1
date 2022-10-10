using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria
{
    public static class Administracion
    {
        static List<Show> shows;
        static List<Artista> artistas;
        static List<Entrada> entradas;

        //persona
        static List<Cliente> clientes;
        static List<Empleado> empleados;

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

        public static Entrada AgregarEspectadorAlShow(Cliente unCliente, Show unShow, Categoria unaCategoria, Ubicacion unaUbicacion)
        {
            // Validar si el show tiene una capacidad disponible

            unShow.espectadores.Add(unCliente);

            return new Entrada(unShow, unCliente, unaCategoria, unaUbicacion);
        }
        static void CargarArtistas()
        {
            artistas.Add(new Artista("Luis", "Miguel", 16437443, new DateTime(1970, 04, 19, 23, 00, 00), "Luismi"));
            artistas.Add(new Artista("Gonzalo", "Conde", 36411333, new DateTime(1998, 08, 29, 22, 00, 00), "Bizarrap"));
            artistas.Add(new Artista("Marshall", "Mathers", 20337332, new DateTime(1972, 10, 17, 21, 00, 00), "EMINEM"));
        }        

    }
}
