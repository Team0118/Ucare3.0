using System.ComponentModel.DataAnnotations;

namespace Ucare.Entidades.Almacen
{
    public class Categoria
    {
        public int idcategoria { get; set;}
        [Required]
        [StringLength(50, MinimumLength =3 ,ErrorMessage = "El nombre  no debe tener más de 50 cataracteres, ni menos de 3")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
        public bool estado { get; set; }



    }
}
