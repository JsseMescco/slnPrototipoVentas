using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class titleauthor
    {
        //atributos 
        private string au_Id;
        private string title_id;
        private int au_ord;
        private int royaltyper;

        //propiedades
        public string Au_Id { get => au_Id; set => au_Id = value; }
        public string Title_id { get => title_id; set => title_id = value; }
        public int Au_ord { get => au_ord; set => au_ord = value; }
        public int Royaltyper { get => royaltyper; set => royaltyper = value; }


    }
}
