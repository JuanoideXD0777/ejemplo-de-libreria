using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_forms.interfaces
{
    internal interface Irepositorio <T> //especifica las clases que van a implementar un metodo
    {
        List<T> Obtener_D();
    }
}
