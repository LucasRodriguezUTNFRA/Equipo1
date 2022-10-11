using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria.Entidades
{
    public class Cliente : Persona
    {
        int cantidadRecitales;

        public Cliente(string nombre, string apellido, int dni, DateTime fechaDeNacimiento) : base(nombre, apellido, dni, fechaDeNacimiento)
        {
            cantidadRecitales = 0;
        }
    }
}
