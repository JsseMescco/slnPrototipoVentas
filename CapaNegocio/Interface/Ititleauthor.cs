using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;

namespace CapaNegocio.Interface
{
    interface Ititleauthor
    {
        DataSet listar();
        bool Agregar(CapaEntidad.titleauthor TitleAuthor);
        DataSet Buscar(string texto, string criterio);
        bool Eliminar(string codigo);
        bool Actualizar(CapaEntidad.titleauthor TitleAuthor);
    }
}
