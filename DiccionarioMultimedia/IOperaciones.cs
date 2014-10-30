using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiccionarioMultimedia
{
    public interface IOperaciones<Tipo>//uso el generics, le digo que voy a usar algo que va a ser el Tipo
    {//este interface siempre que necesite añadir algo a algo, listar o búsquedas me va servir siempre, ya que es luego cuando lo implemento
        void Add(Tipo data);

        void Listar();

        Tipo GetObjeto(int busqueda);
    }
}
