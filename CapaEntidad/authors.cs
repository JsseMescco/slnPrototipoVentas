using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class authors //HOLA :D
    {
        private string au_Id;
        private string au_lname;
        private string au_fname;
        private string phone;
        private string addres;
        private string city;
        private string state;
        private string zip;
        private Byte contract; 

        public string Au_Id { get => au_Id; set => au_Id = value; }
        public string Au_lname { get => au_lname; set => au_lname = value; }
        public string Au_fname { get => au_fname; set => au_fname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Addres { get => addres; set => addres = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public byte Contract { get => contract; set => contract = value; }
    }
}
  