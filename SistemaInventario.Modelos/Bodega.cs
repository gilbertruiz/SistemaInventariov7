using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }


        [Required (ErrorMessage ="Nombre es Requerido")]
        [MaxLength (50, ErrorMessage ="El Nombre no puede ser mayor a 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La Descripcion es Requerido")]
        [MaxLength(100, ErrorMessage = "La Descripcion no puede ser mayor a 100 caracteres")]
        public string Descripcion { get; set; }

        [Required (ErrorMessage ="Estado es requerido")]
        public bool Estado { get; set;}


    }
}
