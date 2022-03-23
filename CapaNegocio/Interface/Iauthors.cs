using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    public interface Iauthors
    {
        DataSet listar();
        bool Agregar(authors Author);
        DataSet Buscar(string texto, string criterio);
        bool Eliminar(string codigo);
        bool Actualizar(authors Author);
    }
}
