using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ucare.Web.Models.Almacen.Categoria
{
    public class CategoriaViewModel
    {

        public int idcategoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }

    }
}
