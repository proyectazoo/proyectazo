//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiagramaDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ventas
    {
        public int ID_Ventas { get; set; }
        public int Codigo_Producto { get; set; }
        public Nullable<System.DateTime> Fecha_Venta { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Nombre_Vendedor { get; set; }
        public string Sucursal { get; set; }
    }
}
