using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boleteria.Entidades;
using Boleteria.Interfaces;

namespace Boleteria
{
    public class BaseDeDatos : IBaseDeDatos
    {
        private List<Empleado> empleados;
        private List<Cliente> clientes;
        private List<Artista> artistas;

        public BaseDeDatos()
        {
            this.empleados = new List<Empleado>();
            this.clientes = new List<Cliente>();
            this.artistas = new List<Artista>();
        }

        public List<Artista> Artistas => artistas;

        public List<Cliente> Clientes => clientes;

        public List<Empleado> Empleados => empleados;

        public void GuardarPersona(Persona persona)
        {
            if (persona is Empleado empleado)
            {
                empleados.Add(empleado);
            }
            else if (persona is Cliente cliente)
            {
                clientes.Add(cliente);
            }
            else if (persona is Artista artista)
            {
                artistas.Add(artista);
            }
        }
    }
}
