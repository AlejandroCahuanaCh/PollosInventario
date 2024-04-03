using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public partial class ProductoAlmacen
    {
        public ProductoAlmacen()
        {
            DetalleMovimientos = new HashSet<DetalleMovimiento>();
        }

        public int Idproductoalmacen { get; set; }
        public int Idproducto { get; set; }
        public int Idalmacen { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Peso { get; set; }
        public string LogUsuarioCreacion { get; set; } = null!;
        public string LogUsuarioModificacion { get; set; } = null!;
        public DateTime LogFechaCreacion { get; set; }
        public DateTime LogFechaModificacion { get; set; }
        public byte LogEstado { get; set; }

        public virtual Almacen IdalmacenNavigation { get; set; } = null!;
        public virtual Producto IdproductoNavigation { get; set; } = null!;
        public virtual ICollection<DetalleMovimiento> DetalleMovimientos { get; set; }
    }
}
