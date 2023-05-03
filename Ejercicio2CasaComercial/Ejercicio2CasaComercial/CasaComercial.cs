using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2CasaComercial
{
    internal class CasaComercial
    {
        string nombre, email;
        int totalVehiculos;
        List<Vehiculo> vehiculos; //esto es un atributo de la clase CasaComercial que es una lista de objetos de la clase Vehiculo

        public CasaComercial(string nombre, string email, int totalVehiculos, List<Vehiculo> vehiculos)
        {
            this.Nombre = nombre;
            this.Email = email;
            this.TotalVehiculos = totalVehiculos;
            this.Vehiculos = vehiculos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public int TotalVehiculos { get => totalVehiculos; set => totalVehiculos = value; }
        internal List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }

        // añadir los métodos:

        public void aniadirVehiculo(Vehiculo v)
        {
            try
            {
                //añadimos el vehiculo a la lista
                this.vehiculos.Add(v);
                //aumentamos el total de vehiculos
                this.totalVehiculos +=1;
                Console.WriteLine("Se ha añadido el vehiculo correctamente");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al añadir el vehiculo: " + e.Message);
                Console.ReadLine();
                throw;
            }
        }
        public void mostrarVehiculos()
        {
            try
            {
                //mostramos la lista de vehiculos
                foreach (var v in this.vehiculos)
                {
                    Console.WriteLine(v.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al mostrar los vehiculos: " + e.Message);
                Console.ReadLine();
                throw;
            }
        }  
        public void vaciarVehiculo()
        {
            Console.WriteLine("Esta seguro que desea vaciar la lista de vehiculos? (s/n)");
            string respuesta = Console.ReadLine();
            if (respuesta == "s" || respuesta == "S")
            {
               vehiculos = new List<Vehiculo>();
               this.totalVehiculos = 0;
               Console.WriteLine("Se ha vaciado la lista de vehiculos correctamente");
            }
            else
            {
                Console.WriteLine("No se ha vaciado la lista de vehiculos");
                Console.ReadLine();
            }
        }
        public void eleminarVehiculo(Vehiculo v)
        {
            vehiculos.Remove(v);
            this.totalVehiculos -= 1;
            Console.WriteLine("Se ha eliminado el vehiculo correctamente");
            Console.ReadLine();
        }
    }
}
