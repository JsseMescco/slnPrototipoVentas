using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;
using CapaEntidad;
using CapaNegocio;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //================================================Authors==============================================================//
        [WebMethod(Description = "ListarAuthors")]
        public DataSet ListarAuthors()
        {
            authorsBL AuthorsBL = new authorsBL();
            return AuthorsBL.listar();
        }
        [WebMethod(Description = "AgregarAuthors")]
        public string[] AgregarAuthors(string Au_id, string Au_lname, string Au_fname, string Phone, string Address, string City, string State, string Zip, byte Contract)
        {
            authorsBL AuthorsBL = new authorsBL();
            authors Author = new authors();

            Author.Au_Id = Au_id;
            Author.Au_lname = Au_lname;
            Author.Au_fname = Au_fname;
            Author.Phone = Phone;
            Author.Addres = Address;
            Author.City = City;
            Author.State = State;
            Author.Zip = Zip;
            Author.Contract = Contract;

            string[] val = { AuthorsBL.Agregar(Author).ToString(), AuthorsBL.Mensaje };
            return val;
        }
        [WebMethod(Description = "ActualizarAuthors")]
        public string[] ActualizarAuthors(string Au_id, string Au_lname, string Au_fname, string Phone, string Address, string City, string State, string Zip, byte Contract)
        {
            authorsBL AuthorsBL = new authorsBL();
            authors Author = new authors();

            Author.Au_Id = Au_id;
            Author.Au_lname = Au_lname;
            Author.Au_fname = Au_fname;
            Author.Phone = Phone;
            Author.Addres = Address;
            Author.City = City;
            Author.State = State;
            Author.Zip = Zip;
            Author.Contract = Contract;

            string[] val = { AuthorsBL.Actualizar(Author).ToString(), AuthorsBL.Mensaje };
            return val;
        }
        [WebMethod(Description = "EliminarAuthors")]
        public string[] EliminarAuthors(string Codigo)
        {
            authorsBL AuthorsBL = new authorsBL();
            string[] val = { AuthorsBL.Eliminar(Codigo).ToString(), AuthorsBL.Mensaje };
            return val;
        }
        //================================================SALES==============================================================//
        [WebMethod(Description = "ListarSales")]
        public DataSet ListarSales()
        {
            salesBL SalesBL = new salesBL();
            return SalesBL.listar();
        }
        [WebMethod(Description = "AgregarSales")]
        public string[] AgregarSales(string stor_id, string ord_num, DateTime ord_date, int qty, string payterms, string title_id)
        {
            salesBL SalesBL = new salesBL();
            sales Sale = new sales();

            Sale.Stor_id = stor_id;
            Sale.Ord_num = ord_num;
            Sale.Ord_date = ord_date;
            Sale.Qty = qty;
            Sale.Payterms = payterms;
            Sale.Title_id = title_id;

            string[] val = { SalesBL.Agregar(Sale).ToString(), SalesBL.Mensaje };
            return val;
        }
        [WebMethod(Description = "ActualizarSales")]
        public string[] ActualizarSales(string stor_id, string ord_num, DateTime ord_date, int qty, string payterms, string title_id)
        {
            salesBL SalesBL = new salesBL();
            sales Sale = new sales();

            Sale.Stor_id = stor_id;
            Sale.Ord_num = ord_num;
            Sale.Ord_date = ord_date;
            Sale.Qty = qty;
            Sale.Payterms = payterms;
            Sale.Title_id = title_id;

            string[] val = { SalesBL.Actualizar(Sale).ToString(), SalesBL.Mensaje };
            return val;
        }
        [WebMethod(Description = "EliminarSales")]
        public string[] EliminarSales(string Codigo)
        {
            salesBL SalesBL = new salesBL();
            string[] val = { SalesBL.Eliminar(Codigo).ToString(), SalesBL.Mensaje };
            return val;
        }
        //================================================STORES==============================================================//
        [WebMethod(Description = "ListarStores")]
        public DataSet ListarStores()
        {
            storesBL StoresBL = new storesBL();
            return StoresBL.listar();
        }
        [WebMethod(Description = "AgregarStores")]
        public string[] AgregarStores(string StoreId, string StoreName, string storeAdress, string city, string state, string zip)
        {
            storesBL StoresBL = new storesBL();
            stores Store = new stores();

            Store.Stor_id = StoreId;
            Store.Stor_name = StoreName;
            Store.Stor_address = storeAdress;
            Store.City = city;
            Store.State = state;
            Store.Zip = zip;

            string[] val = { StoresBL.Agregar(Store).ToString(), StoresBL.Mensaje };
            return val;
        }
        [WebMethod(Description = "ActualizarStores")]
        public string[] ActualizarStores(string StoreId, string StoreName, string storeAdress, string city, string state, string zip)
        {
            storesBL StoresBL = new storesBL();
            stores Store = new stores();

            Store.Stor_id = StoreId;
            Store.Stor_name = StoreName;
            Store.Stor_address = storeAdress;
            Store.City = city;
            Store.State = state;
            Store.Zip = zip;

            string[] val = { StoresBL.Actualizar(Store).ToString(), StoresBL.Mensaje };
            return val;
        }
        [WebMethod(Description = "EliminarStores")]
        public string[] EliminarStores(string Codigo)
        {
            storesBL StoresBL = new storesBL();
            string[] val = { StoresBL.Eliminar(Codigo).ToString(), StoresBL.Mensaje };
            return val;
        }
        //================================================TITLEAUTHOR==============================================================//
        [WebMethod(Description = "ListarTitleAuthors")]
        public DataSet ListarTitleAuthors()
        {
            titleauthorBL TitleauthorBL = new titleauthorBL();
            return TitleauthorBL.listar();
        }
        [WebMethod(Description = "AgregarTitleAuthors")]
        public string[] AgregarTitleAuthors(string au_id, string title_id, int au_ord, int royaltyper)
        {
            titleauthorBL TitleauthorBL = new titleauthorBL();
            titleauthor Titleauthor = new titleauthor();

            Titleauthor.Au_Id = au_id;
            Titleauthor.Title_id = title_id;
            Titleauthor.Au_ord = au_ord;
            Titleauthor.Royaltyper = royaltyper;

            string[] val = { TitleauthorBL.Agregar(Titleauthor).ToString(), TitleauthorBL.Mensaje };
            return val;
        }
        [WebMethod(Description = "ActualizarTitleAuthors")]
        public string[] ActualizarTitleAuthors(string au_id, string title_id, int au_ord, int royaltyper)
        {
            titleauthorBL TitleauthorBL = new titleauthorBL();
            titleauthor Titleauthor = new titleauthor();

            Titleauthor.Au_Id = au_id;
            Titleauthor.Title_id = title_id;
            Titleauthor.Au_ord = au_ord;
            Titleauthor.Royaltyper = royaltyper;

            string[] val = { TitleauthorBL.Actualizar(Titleauthor).ToString(), TitleauthorBL.Mensaje };
            return val;
        }
        [WebMethod(Description = "EliminarTitleAuthors")]
        public string[] EliminarTitleAuthors(string Codigo)
        {
            titleauthorBL TitleauthorBL = new titleauthorBL();
            string[] val = { TitleauthorBL.Eliminar(Codigo).ToString(), TitleauthorBL.Mensaje };
            return val;
        }
        //================================================TITLES==============================================================//
        [WebMethod(Description = "ListarTitle")]
        public DataSet ListarTitles()
        {
            titleBL TitleBL = new titleBL();
            return TitleBL.listar();
        }
    }
}
