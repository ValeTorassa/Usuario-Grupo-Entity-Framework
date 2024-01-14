using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    internal interface ICrud<T> where T : class
    {
        string Agregar(T item);
        string Modificar(T item);
        string Eliminar(T item);

        IReadOnlyCollection<T> Listar();
    }
}
