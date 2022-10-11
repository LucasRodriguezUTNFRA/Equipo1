using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria.Entidades
{
    public class Artista : Persona
    {
        string nombreArtistico;

        public Artista(string nombre, string apellido, int dni, DateTime fechaDeNacimiento, string nombreArtistico) : base(nombre, apellido, dni, fechaDeNacimiento)
        {
            this.nombreArtistico = nombreArtistico;
        }
        public override string ToString()
        {
            return base.ToString() + $"Nombre artistico: {nombreArtistico}";
        }
    }
}
