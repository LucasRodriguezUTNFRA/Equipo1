using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria
{
    public enum Ubicacion
    {
        Platea,
        Campo
    }
    public enum Categoria
    {
        Gold,
        Vip,
        Clasic
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
        public float PrecioTotal
        {
            get { return show.precioBase * 2; }
        }

        public override string ToString()
        {
            return $"Precio final: {PrecioTotal}, Show: {show}";
        }
    }
}
