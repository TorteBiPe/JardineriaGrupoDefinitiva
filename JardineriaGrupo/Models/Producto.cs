using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace JardineriaGrupo.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }
        [Required]
        public string CodigoProducto { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Gama { get; set; }
        [Required]
        public string Dimensiones { get; set; }
        [Required]
        public string Proveedor { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public short CantidadEnStock { get; set; }
        [Required]
        public decimal PrecioVenta { get; set; }
        [Required]
        public decimal? PrecioProveedor { get; set; }

        public virtual GamaProducto GamaNavigation { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
