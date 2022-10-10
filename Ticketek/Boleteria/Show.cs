﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria
{
    public class Show
    {
        //Establecimiento lugarUsado;
        public string lugarUsado;
        public Artista artista;
        public List<Persona> espectadores; // = new List<Persona>();
        public DateTime fechaDeShow;
        public int duracion;
        public float precioBase;

        public Show(string lugarUsado, Artista artista, DateTime fechaDeShow, int duracion, float precioBase)
        {
            this.lugarUsado = lugarUsado;
            this.artista = artista;
            this.espectadores = new List<Persona>();
            this.fechaDeShow = fechaDeShow;
            this.duracion = duracion;
            this.precioBase = precioBase;
        }

        public override string ToString()
        {
            return $"Establecimiento: {lugarUsado}, Artista: {artista}, Fecha: {fechaDeShow}, Duracion: {duracion} horas";
        }
    }
}
