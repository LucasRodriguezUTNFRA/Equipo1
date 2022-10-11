using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boleteria.Entidades;
using Boleteria.Enums;
using Boleteria.Interfaces;

namespace Boleteria
{
    public static class Administracion
    {
        private static List<Show> shows;
        private static List<Entrada> entradas;
        private static IBaseDeDatos baseDeDatos;

        static Administracion()
        {
            shows = new List<Show>();
            entradas = new List<Entrada>();
            baseDeDatos = new BaseDeDatos();
            CargarArtistas();
        }

        public static IBaseDeDatos BaseDeDatos { get => baseDeDatos; }
        public static List<Show> Shows { get => shows;}
        public static List<Establecimiento> Establecimientos { get; set; }

        public static Entrada AgregarEspectadorAlShow(Cliente unCliente, Show unShow, CategoriaEntrada unaCategoria, UbicacionEntrada unaUbicacion)
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
            baseDeDatos.GuardarPersona(new Artista("Luis", "Miguel", 16437443, new DateTime(1970, 04, 19, 23, 00, 00), "Luismi"));
            baseDeDatos.GuardarPersona(new Artista("Gonzalo", "Conde", 36411333, new DateTime(1998, 08, 29, 22, 00, 00), "Bizarrap"));
            baseDeDatos.GuardarPersona(new Artista("Marshall", "Mathers", 20337332, new DateTime(1972, 10, 17, 21, 00, 00), "EMINEM"));
        }

    }
}
