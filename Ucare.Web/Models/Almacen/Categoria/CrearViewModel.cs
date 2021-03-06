﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ucare.Web.Models.Almacen.Categoria
{
    public class CrearViewModel
    {
        [Required]
        public int idcategoria { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre  no debe tener más de 50 cataracteres, ni menos de 3")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }

    }
}
