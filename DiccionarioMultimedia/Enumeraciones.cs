using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiccionarioMultimedia
{
    public enum Idioma //esto es para establecer valores constantes a usar en la aplicación
    {
        Español,//estos van a ser los únicos idiomas que van a ser válidos. Por defecto su valor va por orden del 0 a lo que sea
        Ingeles,//podría asignarles valor con =34 por ejemplo, esto me quita el problema de que alguien por ejemplo ponga castellano en vez de español, etc
        Frances,
        Chino
        
    }

    public enum Formato//esto ya son tipos de datos Formato e Idioma
    {
        Mp3,
        Wav,
        Ogg
    }
    
    
    
    
    
}


