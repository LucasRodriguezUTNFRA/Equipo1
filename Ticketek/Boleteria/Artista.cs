using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria
{
    public enum TipoArtista
    {
        Banda,
        Solista
    }
    public class Artista : Persona
    {
        string nombreArtistico;

        public Artista(string nombre, string apellido, int dni, DateTime fechaDeNacimiento, string nombreArtistico) : base(nombre, apellido, dni, fechaDeNacimiento)
        {
            
        }
    }
}
