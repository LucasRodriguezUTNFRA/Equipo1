using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria.Entidades
{
    public class Show
    {
        //Establecimiento lugarUsado;
        public Establecimiento lugarUsado;
        public Artista artista;
        public List<Persona> espectadores; // = new List<Persona>();
        public DateTime fechaDeShow;
        public int duracionEnHoras;
        public float precioBaseEnPesos;

        public Show(Establecimiento lugarUsado, Artista artista, DateTime fechaDeShow, int duracion, float precioBase)
        {
            this.lugarUsado = lugarUsado;
            this.artista = artista;
            espectadores = new List<Persona>();
            this.fechaDeShow = fechaDeShow;
            duracionEnHoras = duracion;
            precioBaseEnPesos = precioBase;
        }

        public int CantidadEspectadores
        {
            get
            {
                return espectadores.Count;
            }
        }

        public override string ToString()
        {
            return $"Establecimiento: {lugarUsado}, Artista: {artista}, Fecha: {fechaDeShow}, Duracion: {duracionEnHoras} horas";
        }
    }
}
