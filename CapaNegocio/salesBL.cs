using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;

namespace CapaNegocio
{
    public class salesBL : Interface.Isales
    {
        //Atributo que devuelve mensaje del PA
        private string mensaje;

        //propiedad de solo lectura
        public string Mensaje
        {
            get { return mensaje; }

        }

        Datos datos = new DatosSQL();

        public DataSet listar()
        {
            return datos.TraerDataSet("spListar_sales");
        }

        public bool Agregar(sales Sales)
        {
            DataRow fila = datos.TraerDataRow("spAgregar_sales", Sales.Stor_id, Sales.Ord_num, Sales.Ord_date, Sales.Qty, Sales.Payterms, Sales.Title_id);
            mensaje = fila["mensaje"].ToString();
            byte codErr = Convert.ToByte(fila["codError"]);
            if (codErr == 0) return false;
            else return true;
        }

        public bool Actualizar(sales Sales)
        {
            DataRow fila = datos.TraerDataRow("spActualizar_sales", Sales.Stor_id, Sales.Ord_num, Sales.Ord_date, Sales.Qty, Sales.Payterms, Sales.Title_id);
            mensaje = fila["mensaje"].ToString();
            byte codErr = Convert.ToByte(fila["codError"]);
            if (codErr == 0) return false;
            else return true;
        }
        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscar_sales", criterio, texto);
        }

        public bool Eliminar(string codigo)
        {
            DataRow fila = datos.TraerDataRow("spEliminar_sales", codigo);
            mensaje = fila["mensaje"].ToString();
            byte codErr = Convert.ToByte(fila["codError"]);
            if (codErr == 0) return false;
            else return true;
        }
    }
}
