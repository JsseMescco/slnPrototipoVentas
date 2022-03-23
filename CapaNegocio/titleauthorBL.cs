using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class titleauthorBL : Interface.Ititleauthor
    {
        //Atributo que devuelve mensaje del PA
        private string mensaje;

        //propiedad de solo lectura
        public string Mensaje
        {
            get { return mensaje; }

        }

        //utilizar los archivos cs de la capa de datos
        Datos datos = new DatosSQL();


        public bool Actualizar(titleauthor titleauthor)
        {
            DataRow fila = datos.TraerDataRow("spActualizar_titleauthor", titleauthor.Title_id, titleauthor.Au_Id, titleauthor.Au_ord, titleauthor.Royaltyper);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["codError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(titleauthor titleauthor)
        {
            DataRow fila = datos.TraerDataRow("spAgregar_titleauthor", titleauthor.Title_id, titleauthor.Au_Id, titleauthor.Au_ord, titleauthor.Royaltyper);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["codError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscar_titleauthor", texto, criterio);
        }
        public bool Eliminar(string title_id)
        {
            DataRow fila = datos.TraerDataRow("spEliminar_titleauthor", title_id);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["codError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet listar()
        {
            return datos.TraerDataSet("spListar_titleauthor");
        }
    }
}
