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
    
    public partial class MI_MOVIMIENTOS_INVENTARIO
    {
        public int MOI_KEYMOI { get; set; }
        public string PRD_KEYPRD { get; set; }
        public string RAD_KEYTAL { get; set; }
        public Nullable<int> RAN_KEYRAN { get; set; }
        public string TMO_TPOMOV { get; set; }
        public string TMO_CVETMO { get; set; }
        public int TIE_KEYTIE { get; set; }
        public System.DateTime MOI_FECMOV { get; set; }
        public Nullable<int> MOI_CANTID { get; set; }
        public decimal MOI_PRECIO { get; set; }
        public decimal MOI_COSTO { get; set; }
        public string MOI_REFERE { get; set; }
        public decimal MOI_DESCTO { get; set; }
        public Nullable<System.DateTime> MOI_FECLLE { get; set; }
        public decimal MOI_COSPRO { get; set; }
        public string MOI_NUMDOC { get; set; }
        public string MOI_NOMPRO { get; set; }
        public int EST_KEYEST { get; set; }
        public int USR_KEYUSR { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_PRODUCTO_RANGO_TALLAS CA_PRODUCTO_RANGO_TALLAS { get; set; }
        public virtual CA_TIENDAS CA_TIENDAS { get; set; }
        public virtual CA_TIPOS_MOVIMIENTOS CA_TIPOS_MOVIMIENTOS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}