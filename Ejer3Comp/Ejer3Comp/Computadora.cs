using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3Comp
{
    internal class Computadora
    {
        int capacidad_disco;
        int espacio_disponible;
        bool encendida;

        public Computadora(int capacidad_disco, int espacio_disponible, bool encendida)
        {
            this.Capacidad_disco = capacidad_disco;
            this.Espacio_disponible = espacio_disponible;
            this.Encendida = encendida;
        }

        public int Capacidad_disco { get => capacidad_disco; set => capacidad_disco = value; }
        public int Espacio_disponible { get => espacio_disponible; set => espacio_disponible = value; }
        public bool Encendida { get => encendida; set => encendida = value; }
        //– aniadirDatos(int datos): añade información al disco duro,
        //si supera el espacio disponible del disco,
        //el tamaño del disco será el máximo posible.
        //Solo si esta encendida la Computadora.


        public void aniadirDatos(int datos)
        {
            if (encendida)
            {
                if (datos > espacio_disponible)// si supera el espacio disponible del disco, el tamaño del disco será el máximo posible.

                {
                    espacio_disponible = 0;
                }
                else
                {
                    espacio_disponible -= datos;
                }
            }
            else { Console.WriteLine("La computadora esta apagada"); }
        }
        public void eliminarDatos(int datos)
        {
            if(encendida)
            {
                if (datos < espacio_disponible)
                {
                    espacio_disponible += datos;
                }
                else
                {
                    espacio_disponible = capacidad_disco;
                }
            }
        }
        public void encender()
        {
            encendida = true;
        }
    }
}
