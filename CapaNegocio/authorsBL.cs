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
    public class authorsBL : Interface.Iauthors
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
            return datos.TraerDataSet("spListar_Authors");
        }

        public bool Agregar(authors Author)
        {
            DataRow fila = datos.TraerDataRow("spAgregar_Authors", Author.Au_Id, Author.Au_fname, Author.Au_lname, Author.Phone, Author.Addres, Author.City, Author.State, Author.Zip, Author.Contract);
            mensaje = fila["mensaje"].ToString();
            byte codErr = Convert.ToByte(fila["codError"]);
            if (codErr == 0) return false;
            else return true;
        }

        public bool Actualizar(authors Author)
        {
            DataRow fila = datos.TraerDataRow("spActualizar_Authors", Author.Au_Id, Author.Au_fname, Author.Au_lname, Author.Phone, Author.Addres, Author.City, Author.State, Author.Zip, Author.Contract);
            mensaje = fila["mensaje"].ToString();
            byte codErr = Convert.ToByte(fila["codError"]);
            if (codErr == 0) return false;
            else return true;
        }
        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscar_Authors", criterio, texto);
        }

        public bool Eliminar(string codigo)
        {
            DataRow fila = datos.TraerDataRow("spEliminar_Authors", codigo);
            mensaje = fila["mensaje"].ToString();
            byte codErr = Convert.ToByte(fila["codError"]);
            if (codErr == 0) return false;
            else return true;
        }

       
    }
}
