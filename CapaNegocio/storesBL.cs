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
    public class storesBL : Interface.Istores
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
            return datos.TraerDataSet("spListarTienda");
        }

        public bool Agregar(stores Store)
        {
            DataRow fila = datos.TraerDataRow("spAgregarStore", Store.Stor_id, Store.Stor_name, Store.Stor_address, Store.City, Store.State, Store.Zip);
            mensaje = fila["mensaje"].ToString();
            byte codErr = Convert.ToByte(fila["codError"]);
            if (codErr == 0) return false;
            else return true;
        }

        public bool Actualizar(stores Store)
        {
            DataRow fila = datos.TraerDataRow("spActualizarTienda", Store.Stor_id, Store.Stor_name, Store.Stor_address, Store.City, Store.State, Store.Zip);
            mensaje = fila["mensaje"].ToString();
            byte codErr = Convert.ToByte(fila["codError"]);
            if (codErr == 0) return false;
            else return true;
        }
        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarTienda", texto, criterio);
        }

        public bool Eliminar(string codigo)
        {
            DataRow fila = datos.TraerDataRow("spEliminarTienda", codigo);
            mensaje = fila["mensaje"].ToString();
            byte codErr = Convert.ToByte(fila["codError"]);
            if (codErr == 0) return false;
            else return true;
        }

    }
}
