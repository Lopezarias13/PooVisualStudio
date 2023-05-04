using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3Comp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //capacidad- espacio disponible- encendida
            Computadora compu = new Computadora(100, 50, true);
            Console.WriteLine("Ingrese la cantidad de datos a añadir");
            int datos = int.Parse(Console.ReadLine());
            compu.aniadirDatos(datos);
            Console.WriteLine("Ingrese la cantidad de datos a eliminar");
            datos = int.Parse(Console.ReadLine());
            compu.eliminarDatos(datos);
            
            Console.ReadKey();
        }
    }
}
