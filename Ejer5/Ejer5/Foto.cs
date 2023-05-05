using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5
{
    internal class Foto
    {
        int idFoto;
        int tamanoMB;
        DateTime fechaCreacion;
        string comentarios;

        public Foto(int idFoto, int tamanoMB, DateTime fechaCreacion, string comentarios)
        {
            this.IdFoto = idFoto;
            this.TamanoMB = tamanoMB;
            this.FechaCreacion = fechaCreacion;
            this.Comentarios = comentarios;
        }

        public int IdFoto { get => idFoto; set => idFoto = value; }
        public int TamanoMB { get => tamanoMB; set => tamanoMB = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }

        public override string ToString()
        {
            return $"Id: {IdFoto}\nTamaño: {TamanoMB} MB\nFecha de creación: {FechaCreacion}\nComentarios: {Comentarios}";
        }
    }
    class Album
    {
        int id;
        string nombre;
        DateTime fechaCreacion;
        List<Foto> fotos;
        public Album(int id, string nombre, DateTime fechaCreacion, List<Foto> fotos)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.FechaCreacion = fechaCreacion;
            this.Fotos = fotos;
        }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        internal List<Foto> Fotos { get => fotos; set => fotos = value; }
        public void AniadirFoto(Foto f)
        {
            Fotos.Add(f);
            Console.WriteLine("Se agrego la foto");
        }
        public void MostrarFoto()
        {
            foreach (Foto f in Fotos)
            {
                Console.WriteLine(f);
            }
        }
        public void VaciarAlbum()
        {
            Fotos.Clear();
        }
        public void EliminarFoto(Foto f)
        {
            Fotos.Remove(f);
        }
        public double TamanoAlbum()
        {
            double tamano = 0;
            foreach (Foto f in Fotos)
            {
                tamano += f.TamanoMB;
            }
            return tamano / 1024;
        }
    }   
}
