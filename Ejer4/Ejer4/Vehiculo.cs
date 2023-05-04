using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4
{
    internal class Vehiculo
    {
        int id;
        string marca;
        string modelo;
        int km;
        decimal precio;
        int annio;

        public Vehiculo(int id, string marca, string modelo, int km, decimal precio, int annio)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Km = km;
            this.Precio = precio;
            this.Annio = annio;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Annio { get => annio; set => annio = value; }

        public override string ToString()
        {
            return $"Id: {Id}, Marca: {Marca}, Modelo: {Modelo}, Km: {Km}, Precio: {Precio}, Año: {Annio}";
        }
        public virtual decimal CalcularPrecio()
        {
            return Precio;
        }

    }
    class Auto : Vehiculo
    {
        bool airbag;
        public Auto(int id, string marca, string modelo, int km, decimal precio, int annio, bool airbag) : base(id, marca, modelo, km, precio, annio)
        {
            this.airbag = airbag;
        }
        public bool Airbag { get => airbag;}
        public override decimal CalcularPrecio()
        {
            if (airbag)
            {
                return base.CalcularPrecio() + 200;
            }
            else { return base.CalcularPrecio(); }
        }
        public override string ToString()
        {
            return "Modelo: " + Modelo + " Marca: " + Marca + " Año: " + Annio + " Precio: " + CalcularPrecio();
        }
    }
    class Moto : Vehiculo
    {
        bool sidecar;
        public Moto(int id, string marca, string modelo, int km, decimal precio, int annio, bool sidecar) : base(id, marca, modelo, km, precio, annio)
        {
            this.sidecar = sidecar;
        }
        public bool Sidecar { get => sidecar;}
        public override decimal CalcularPrecio()
        {
            if (sidecar)
            {
                return base.CalcularPrecio() + 50;
            }
            else { return base.CalcularPrecio(); }
        }
        public override string ToString()
        {
            return "Modelo: " + Modelo + " Marca: " + Marca + " Año: " + Annio + " Precio: " + CalcularPrecio();
        }
    }
}
