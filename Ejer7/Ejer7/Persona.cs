using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7
{
    internal class Persona
    {
        string nombre;
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public override string ToString()
        {
            return "Nombre: " + nombre + "\n";
        }
    }
    class Estudiante : Persona
    {
        public Estudiante(string nombre) : base(nombre)
        {
        }
        public void Estudiar()
        {
            Console.WriteLine("Estudiar");
        }
    }
    class Profesor : Persona
    {
        public Profesor(string nombre) : base(nombre)
        {
        }
        public void Explicar()
        {
            Console.WriteLine("Explicar");
        }
    }
}
