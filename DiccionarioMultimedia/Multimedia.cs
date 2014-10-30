using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiccionarioMultimedia
{
    public abstract class Multimedia
    {
        public String Titulo { get; set; }
        public String Autor { get; set; }
        public int Codigo { get; set; }//lo crea entero para luego hacer algún incremental

        public Multimedia()
        {
            
        }
        public Multimedia(String titulo, String autor, int codigo)
        {
            Titulo = titulo;
            Autor = autor;
            Codigo = codigo;

        }

        public abstract void Detalle();

    }
}
