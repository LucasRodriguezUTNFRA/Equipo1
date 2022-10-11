using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria.Entidades
{
    public class Empleado : Persona
    {
        public Empleado(string nombre, string apellido, int dni, DateTime fechaDeNacimiento) : base(nombre, apellido, dni, fechaDeNacimiento)
        {

        }
    }
}
