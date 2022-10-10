using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria
{
    public class Cliente : Persona
    {
        int cantidadRecitales;

        public Cliente(string nombre, string apellido, int dni, DateTime fechaDeNacimiento) : base(nombre, apellido, dni, fechaDeNacimiento)
        {
            this.cantidadRecitales = 0;
        }
    }
}
