using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class stores
    {

        //ATRIBUTOS
        private string stor_id;
        private string stor_name;
        private string stor_address;
        private string city;
        private string state;
        private string zip;

        public string Stor_id { get => stor_id; set => stor_id = value; }
        public string Stor_name { get => stor_name; set => stor_name = value; }
        public string Stor_address { get => stor_address; set => stor_address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
    }
}
