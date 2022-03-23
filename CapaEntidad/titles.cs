using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class titles
    {
        //atributos
        private string title_id;
        private string title;
        private string type;
        private string pub_id;
        private decimal price;
        private decimal advance;
        private int royalty;
        private int ytd_sales;
        private string notes;
        private DateTime pubdate;

        public string Title_id { get => title_id; set => title_id = value; }
        public string Title { get => title; set => title = value; }
        public string Type { get => type; set => type = value; }
        public string Pub_id { get => pub_id; set => pub_id = value; }
        public decimal Price { get => price; set => price = value; }
        public decimal Advance { get => advance; set => advance = value; }
        public int Royalty { get => royalty; set => royalty = value; }
        public int Ytd_sales { get => ytd_sales; set => ytd_sales = value; }
        public string Notes { get => notes; set => notes = value; }
        public DateTime Pubdate { get => pubdate; set => pubdate = value; }

        //propiedades
    }
}
