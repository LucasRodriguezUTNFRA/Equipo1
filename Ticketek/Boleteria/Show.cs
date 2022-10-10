using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria
{
    public class Show
    {
        //Establecimiento lugarUsado;
        string lugarUsado;
        Artista artista;
        List<Persona> espectadores; // = new List<Persona>();
        DateTime fechaDeShow;
        int duracion;

        public Show(string lugarUsado, Artista artista, List<Persona> espectadores, DateTime fechaDeShow, int duracion)
        {
            this.lugarUsado = lugarUsado;
            this.artista = artista;
            this.espectadores = espectadores;
            this.fechaDeShow = fechaDeShow;
            this.duracion = duracion;
        }
    }
}
