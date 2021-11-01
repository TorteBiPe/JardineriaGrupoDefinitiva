using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace JardineriaGrupo.Models
{
    public partial class GamaProducto
    {
        public GamaProducto()
        {
            Productos = new HashSet<Producto>();
        }
        [Required]
        public string Gama { get; set; }
        [Required]
        public string DescripcionTexto { get; set; }
        public string DescripcionHtml { get; set; }
        public string Imagen { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
