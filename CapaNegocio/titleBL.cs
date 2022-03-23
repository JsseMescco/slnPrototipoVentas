using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;

namespace CapaNegocio
{
    public class titleBL : Interface.Ititles
    {
        Datos datos = new DatosSQL();
        public DataSet listar()
        {
            return datos.TraerDataSet("spListarTitles");
        }
    }
}
