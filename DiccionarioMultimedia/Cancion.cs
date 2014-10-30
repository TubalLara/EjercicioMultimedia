using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiccionarioMultimedia
{
    public class Cancion:Multimedia
    {
        public int Duracion { get; set; }

        public Formato Formato { get; set; }//como hice la enumeración ya sabe que hay un tipo de dato que es Idioma, y así está restringido a los que hemos dado

        public Cancion(String titulo, String autor, int codigo, int duracion, Formato formato) : base(titulo, autor, codigo)
        {
            Duracion = duracion;
            Formato = formato;
        }


        public override void Detalle()
        {
            Console.WriteLine("Una canción llamada {0} de {1} que dura {2} minutos y en {3}", Titulo, Autor, Duracion, Formato);
        }
    }
}
