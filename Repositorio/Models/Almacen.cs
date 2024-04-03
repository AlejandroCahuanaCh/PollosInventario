using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public partial class Almacen
    {
        public Almacen()
        {
            DetalleComprobantes = new HashSet<DetalleComprobante>();
            MovimientoIdalmacendestinoNavigations = new HashSet<Movimiento>();
            MovimientoIdalmacenorigenNavigations = new HashSet<Movimiento>();
            ProductoAlmacens = new HashSet<ProductoAlmacen>();
        }

        public int Idalmacen { get; set; }
        public string Descripcion { get; set; } = null!;
        public string LogUsuarioCreacion { get; set; } = null!;
        public string LogUsuarioModificacion { get; set; } = null!;
        public DateTime LogFechaCreacion { get; set; }
        public DateTime LogFechaModificacion { get; set; }
        public byte LogEstado { get; set; }

        public virtual ICollection<DetalleComprobante> DetalleComprobantes { get; set; }
        public virtual ICollection<Movimiento> MovimientoIdalmacendestinoNavigations { get; set; }
        public virtual ICollection<Movimiento> MovimientoIdalmacenorigenNavigations { get; set; }
        public virtual ICollection<ProductoAlmacen> ProductoAlmacens { get; set; }
    }
}
