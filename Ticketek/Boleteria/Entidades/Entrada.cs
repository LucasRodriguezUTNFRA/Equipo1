using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boleteria.Enums;

namespace Boleteria.Entidades
{
    public class Entrada
    {
        static int contador;
        int id;
        Show show;
        Cliente cliente;
        CategoriaEntrada categoria;
        UbicacionEntrada ubicacion;

        //id de la clase
        static Entrada()
        {
            contador = 0;
        }

        public Entrada(Show show, Cliente cliente, CategoriaEntrada categoria, UbicacionEntrada ubicacion)
        {
            id = contador++;
            this.show = show;
            this.cliente = cliente;
            this.categoria = categoria;
            this.ubicacion = ubicacion;
        }

        public Show Show
        {
            get => show;
        }

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
        }
        public float PrecioTotalEnPesos
        {
            get
            {
                return show.precioBaseEnPesos + (int)ubicacion * 1000 + (int)categoria * 500;
            }
        }

        public override string ToString()
        {
            return $"Precio final: {PrecioTotalEnPesos}, Show: {show}";
        }
    }
}
