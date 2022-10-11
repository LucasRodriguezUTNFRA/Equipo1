namespace Boleteria
{
    public class Establecimiento
    {
        //agregar datos jijijaja
        private int capacidadTotal;
        private string nombre;

        public Establecimiento(int capacidadTotal, string nombre)
        {
            this.capacidadTotal = capacidadTotal;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombre}. Capacidad: {this.capacidadTotal} personas.";
        }
    }
}