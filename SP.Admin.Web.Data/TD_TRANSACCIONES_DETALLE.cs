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
    
    public partial class TD_TRANSACCIONES_DETALLE
    {
        public int TRA_KEYIDE { get; set; }
        public int TRA_KEYTRA { get; set; }
        public string TDO_KEYTDO { get; set; }
        public string PRD_KEYPRD { get; set; }
        public int RAN_KEYRAN { get; set; }
        public string RAD_KEYTAL { get; set; }
        public int TIE_KEYTIE { get; set; }
        public int USR_KEYVTA { get; set; }
        public int TRD_CANTID { get; set; }
        public decimal TRD_PRECIO { get; set; }
        public decimal TRD_PCOSTO { get; set; }
        public decimal TRD_PORDES { get; set; }
        public decimal TRD_IMPDES { get; set; }
        public System.DateTime TRD_FECMOV { get; set; }
        public Nullable<int> PRO_KEYPRO { get; set; }
        public int EST_KEYEST { get; set; }
        public int USR_KEYUSR { get; set; }
    
        public virtual BC_BIT_CAMBIOS_PRECIOS_TIENDA BC_BIT_CAMBIOS_PRECIOS_TIENDA { get; set; }
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_PRODUCTO_RANGO_TALLAS CA_PRODUCTO_RANGO_TALLAS { get; set; }
        public virtual CA_PROMOCIONES CA_PROMOCIONES { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS1 { get; set; }
        public virtual NE_NEGATIVOS NE_NEGATIVOS { get; set; }
        public virtual TR_TRANSACCIONES TR_TRANSACCIONES { get; set; }
    }
}