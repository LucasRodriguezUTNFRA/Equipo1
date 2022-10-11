using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria
{
    public enum Ubicacion
    {
        Campo = 1,
        Platea
    }
    public enum Categoria
    {
        Clasic = 1,
        Gold,
        Vip
    }

    public class Entrada
    {
        static int contador;
        int id;
        Show show;
        Cliente cliente;
        Categoria categoria;
        Ubicacion ubicacion;        

        //id de la clase
        static Entrada()
        {
            contador = 0;
        }

        public Entrada(Show show, Cliente cliente, Categoria categoria, Ubicacion ubicacion)
        {
            this.id = contador++;
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
                return this.cliente;
            }
        }
        public float PrecioTotalEnPesos
        {
            get
            {
                return this.show.precioBaseEnPesos + ((int)this.ubicacion * 1000) + ((int)this.categoria * 500);
            }
        }

        public override string ToString()
        {
            return $"Precio final: {PrecioTotalEnPesos}, Show: {show}";
        }
    }
}
