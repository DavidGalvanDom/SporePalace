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
    
    public partial class RF_REFERE_FACELEC
    {
        public int RFE_KEYRFE { get; set; }
        public Nullable<int> TRA_KEYTRA { get; set; }
        public int TIE_KEYTIE { get; set; }
        public string TDO_KEYTDO { get; set; }
        public string RFE_REFECO { get; set; }
        public string RFE_NSERIE { get; set; }
        public Nullable<int> RFE_FOLFAC { get; set; }
        public decimal RFE_SUBTOT { get; set; }
        public decimal RFE_IMPIVA { get; set; }
        public decimal RFE_IMPTOT { get; set; }
        public System.DateTime RFE_FECFAC { get; set; }
        public string RFE_SERNCR { get; set; }
        public Nullable<int> RFE_FOLNCR { get; set; }
        public string RFE_CODFAC { get; set; }
        public System.DateTime RFE_FECALT { get; set; }
        public System.DateTime RFE_FEULAC { get; set; }
        public int EST_KEYEST { get; set; }
        public int USR_KEYUSR { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
        public virtual TR_TRANSACCIONES TR_TRANSACCIONES { get; set; }
    }
}