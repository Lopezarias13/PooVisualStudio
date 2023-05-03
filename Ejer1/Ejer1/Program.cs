using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. ejercicio 1. Crea una clase Vehiculo con las siguientes propiedades:
– Id, Marca, Modelo, KM, Precio, Año

Debemos crear un constructor donde le pasemos los valores. Crea sus get y set de cada propiedad.
Sobrescriba el metodo toString(). El cual muestre en pantalla la marca, el modelo el año y el precio del vehículo*/

namespace Ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo(1, "Ford", "Fiesta", 10000, 10000, 2010);
            Console.WriteLine(v1.ToString());
            Console.ReadKey();
        }
    }
}
