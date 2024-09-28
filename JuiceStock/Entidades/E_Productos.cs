using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceStock.Entidades
{
    public class E_Productos
    {
        public int id_Prod {  get; set; }
        public string nombre_Prod { get; set; }
        public string categoria_Prod {  get; set; }
        public int precio_Prod {  get; set; }
        public int id_Prov { get; set; }
    }
}
