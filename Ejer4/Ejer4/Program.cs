using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clase Vehiculo
            Vehiculo vehiculo = new Vehiculo(1, " Land Rover", "Range Rover Evoque", 10000, 100000, 2019);
            Console.WriteLine(vehiculo.ToString());
            Console.WriteLine("--------------------------");

            //Clase Auto

            Console.WriteLine("Ingrese el id del vehiculo");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la marca del vehiculo");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del vehiculo");
            string modelo = Console.ReadLine();
            Console.WriteLine("Ingrese los km del vehiculo");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del vehiculo");
            decimal precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año del vehiculo");
            int annio = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese si el vehiculo tiene airbag");
            //bool airbag = bool.Parse(Console.ReadLine());
            
            Console.WriteLine("--------------------------");
            Auto auto = new Auto(id, marca, modelo, km, precio, annio, false);
            Console.WriteLine(auto.ToString());
            Console.WriteLine("--------------------------");


            //Clase Moto
            Moto moto = new Moto(2, "Honda", "CBR 1000 RR", 10000, 100000, 2019, false);
            Console.WriteLine(moto.ToString());

            Console.ReadKey();

        }
    }
}
