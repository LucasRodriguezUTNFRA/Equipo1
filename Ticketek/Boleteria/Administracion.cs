using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria
{
    public static class Administracion
    {
        static List<Show> shows;
        static List<Artista> artistas;
        static List<Entrada> entradas;

        //persona
        static List<Cliente> clientes;
        static List<Empleado> empleados;

        static Administracion()
        {
            shows = new List<Show>();
            artistas = new List<Artista>();
            entradas = new List<Entrada>();
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
        }
     
    }
}
