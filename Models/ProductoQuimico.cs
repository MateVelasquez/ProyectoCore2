using System;
using System.Collections.Generic;

namespace ProyectoCore.Models
{
    public partial class ProductoQuimico
    {
        public byte IdProductoQuimico { get; set; }
        public byte IdTrabajador { get; set; }
        public byte IdExportacion { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Costo { get; set; }

        public virtual Exportacion IdExportacionNavigation { get; set; } = null!;
        public virtual Trabajador IdTrabajadorNavigation { get; set; } = null!;
    }
}
