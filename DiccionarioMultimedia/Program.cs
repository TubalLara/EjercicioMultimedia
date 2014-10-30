using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiccionarioMultimedia
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperaciones<Multimedia> ope = new MultimediaLista();
            int codigo = 0;
            do
            {
             Console.WriteLine("1.Alta 2.Listar 3.Buscar 4.Salir");
                Int32.TryParse(Console.ReadLine(), out codigo);

                switch (codigo)
                {
                    case 1:
                        Alta();
                        break;
                    case 2:
                        Listar();
                        break;
                    case 3:
                        Buscar();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                }

            } while (codigo !=4);

        }
    }
}
