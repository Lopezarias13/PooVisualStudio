 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foto foto = new Foto(1, 2, DateTime.Now, "Comentario");
            Album album = new Album(1, "Album1", DateTime.Now, new List<Foto>());
            Console.WriteLine(album.ToString());
            album.AniadirFoto(foto);
            Console.WriteLine(album.ToString());
            album.MostrarFoto();
            album.VaciarAlbum();
            Console.WriteLine(album.ToString());

            

            



        }
    }
}
