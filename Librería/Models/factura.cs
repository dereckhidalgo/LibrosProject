//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Librería.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class factura
    {
        public int idFactura { get; set; }
        public string nombreCliente { get; set; }
        public Nullable<System.DateTime> fechaFactura { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<int> idLibro { get; set; }
    }
}
