 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*5.  Cree un clase Foto la cual tendrá los siguientes campos:
-Id foto
-Tamaño en MB
-Fecha Creación
-Comentarios

Cree su respectivo constructor y propiedades

Sobrescriba el método toString(). El cual muestre en pantalla la información almacenada de la foto
A continuación cree una clase Álbum la cual deberá tener los siguientes campos
-Id
-Nombre
-Fecha Creación
-Lista de Fotos

Cree su respectivo constructor y propiedades
Crearemos los siguientes métodos:
– aniadirFoto(Foto f): Permite añadir una nueva foto 
– mostrarFoto(): Muestra la lista de las foto registradas
– vaciarAlbum(): Elimina todos las fotos registradas
– eliminarFoto(Foto f).
-TamanoAlbum(): Muestra el tamaño en GB del álbum.*/

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
