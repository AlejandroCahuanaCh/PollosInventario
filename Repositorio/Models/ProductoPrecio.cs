using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public partial class ProductoPrecio
    {
        public int Idproductoprecio { get; set; }
        public int Idproducto { get; set; }
        public int IdtipoPrecio { get; set; }
        public byte TipoDescuento { get; set; }
        public decimal? Valor { get; set; }
        public string LogUsuarioCreacion { get; set; } = null!;
        public string LogUsuarioModificacion { get; set; } = null!;
        public DateTime LogFechaCreacion { get; set; }
        public DateTime LogFechaModificacion { get; set; }
        public byte LogEstado { get; set; }

        public virtual Producto IdproductoNavigation { get; set; } = null!;
        public virtual TipoPrecio IdtipoPrecioNavigation { get; set; } = null!;
    }
}
