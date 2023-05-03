using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2. Crea una clase CasaComercial que gestione una serie de vehículos.

Tendrá un list de objetos vehículos(anterior ejercicio), un nombre, un correo de contacto, y un total de vehículos.

Deberá tener su constructor y sus respectivas propiedades

Crearemos los siguientes métodos:
– aniadirVehiculo(Vehículo v): Permite añadir un nuevo vehículo y aumentar el total de vehículos
– mostrarVehiculos(): Muestra la lista de vehículos registrados
– vaciarVehiculo(): Elimina todos los vehículos registrados
– eliminarVehiculo(Vehiculo v)*/

namespace Ejercicio2CasaComercial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CasaComercial casaComercial = new CasaComercial("autolote el chele", "contacto@gmail.com",0,new List<Vehiculo>());
            casaComercial.aniadirVehiculo(new Vehiculo(1, "Toyota", "Corolla", 1000, 10000, 2010));

        }
    }
}
