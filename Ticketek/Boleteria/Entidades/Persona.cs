using System.Text;

namespace Boleteria.Entidades
{
    public abstract class Persona
    {
        //cliente, artista, empleado
        string nombre;
        string apellido;
        int dni;
        DateTime fechaDeNacimiento;

        protected Persona(string nombre, string apellido, int dni, DateTime fechaDeNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public string NombreCompleto { get => nombre + " " + apellido; }
        public int Edad { get => (DateTime.Now - fechaDeNacimiento).Days / 365; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public int Dni { get => dni; set => dni = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DNI: {Dni}");
            sb.AppendLine($"Nombre completo: {NombreCompleto}");
            sb.AppendLine($"Edad: {Edad}");
            return sb.ToString();
        }
    }
}