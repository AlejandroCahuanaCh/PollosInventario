using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public partial class TipoPrecio
    {
        public TipoPrecio()
        {
            ProductoPrecios = new HashSet<ProductoPrecio>();
        }

        public int Idtipoprecio { get; set; }
        public string Descripcion { get; set; } = null!;
        public string LogUsuarioCreacion { get; set; } = null!;
        public string LogUsuarioModificacion { get; set; } = null!;
        public DateTime LogFechaCreacion { get; set; }
        public DateTime LogFechaModificacion { get; set; }
        public byte LogEstado { get; set; }

        public virtual ICollection<ProductoPrecio> ProductoPrecios { get; set; }
    }
}
