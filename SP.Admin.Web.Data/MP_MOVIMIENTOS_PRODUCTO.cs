//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SP.Admin.Web.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class MP_MOVIMIENTOS_PRODUCTO
    {
        public int MOP_KEYIDE { get; set; }
        public string PRD_KEYPRD { get; set; }
        public int TIE_KEYTIE { get; set; }
        public System.DateTime MOP_PRIREC { get; set; }
        public Nullable<System.DateTime> MOP_PRIVTA { get; set; }
        public Nullable<System.DateTime> MOP_ULTREC { get; set; }
        public Nullable<System.DateTime> MOP_ULTVTA { get; set; }
        public Nullable<System.DateTime> MOP_ULTTRA { get; set; }
        public Nullable<System.DateTime> MOP_RECTRA { get; set; }
        public System.DateTime MOP_FECALT { get; set; }
        public System.DateTime MOP_FEULAC { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_PRODUCTOS_DETALLE CA_PRODUCTOS_DETALLE { get; set; }
        public virtual CA_TIENDAS CA_TIENDAS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
