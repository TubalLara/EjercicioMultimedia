using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiccionarioMultimedia
{
    public class MultimediaLista:IOperaciones<Multimedia>
    {
        private List<Multimedia> lista;

        public MultimediaLista()
        {
            lista = new List<Multimedia>();
        }
        
        public void Add(Multimedia data)
        {
            lista.Add(data);
        }

        public void Listar()
        {
            foreach (var multimedia in lista)
            {
                multimedia.Detalle();
            }
        }

        public Multimedia GetObjeto(int busqueda)
        {
            foreach (var multimedia in lista)
            {
                if (multimedia.Codigo == busqueda)
                    return multimedia;
            }
            return null;

            //ESTO PARA ABAJO SERÏA CON linq, sustituyendo el foreach anterior
            //var ele=lista.FirstOrDefault(o => o.Codigo == busqueda);//esta función devuelve la primera coincidencia y sino hay el default
            //return ele;
        }
    }
}
