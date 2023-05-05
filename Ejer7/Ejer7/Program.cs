using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*7. Crea un programa en C# que solicite tres nombres de personas al usuario y los almacene en un array de objetos de tipo Persona. Habrán dos personas de tipo Estudiante y una persona de tipo Profesor.
Para ello crea una clase Persona que tenga una propiedad Nombre de tipo string, un constructor que reciba el nombre como parámetro y sobrescriba el método ToString().

Después cree dos clases más que hereden de la clase Persona, se llamarán Estudiante y Profesor. La clase Estudiante tiene un método Estudiar que escribe por consola que el estudiante está estudiando. La clase Profesor tendrá un método Explicar que escribe en consola que el profesor está explicando. Recuerde crear además dos constructores en las clases hijas que llamen al constructor padre de la clase Persona.

Finalice el programa leyendo las personas (el profesor y los alumnos) y ejecute los métodos de Explicar y Estudiar.

Entrada
Juan
Sara
Carlos
Salida
Explicar
Estudiar
Estudiar*/

namespace Ejer7
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[3];
            //{ new Estudiante("Juan"), new Estudiante("Sara"), new Profesor("Carlos") };
            Profesor per1 = new Profesor("Juan");
            personas[0] = per1;
            Estudiante per2 = new Estudiante("Sara");
            personas[1] = per2;
            Estudiante per3 = new Estudiante("Carlos");
            personas[2] = per3;

            Console.WriteLine(per1.ToString());
            per1.Explicar();
            Console.WriteLine(per2.ToString());
            per2.Estudiar();
            Console.WriteLine(per3.ToString());
            per3.Estudiar();

            Console.ReadKey();
        }
    }
}
