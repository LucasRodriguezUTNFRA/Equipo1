using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria
{
    enum Ubicacion
    { 
        Platea,
        Campo
    }
    enum Categoria
    {
        Gold,
        Vip,
        Clasic
    }

    public class Entrada
    {
        static int id;
        Show show;
        float precioBase;
        //precioTot prop

        //id de la clase
        static Entrada()
        {
            id = 0;
        }
    }
}
