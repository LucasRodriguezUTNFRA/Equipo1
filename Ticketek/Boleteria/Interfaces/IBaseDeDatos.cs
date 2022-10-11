using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boleteria.Entidades;

namespace Boleteria.Interfaces
{
    public interface IBaseDeDatos
    {

        List<Artista> Artistas { get; }
        List<Cliente> Clientes { get; }
        List<Empleado> Empleados { get; }

        void GuardarPersona(Persona persona);
    }
}
