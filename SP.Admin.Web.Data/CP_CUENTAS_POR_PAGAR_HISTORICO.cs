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
    
    public partial class CP_CUENTAS_POR_PAGAR_HISTORICO
    {
        public int CPH_KEYCPH { get; set; }
        public int CEC_KEYCEC { get; set; }
        public int PRV_KEYPRV { get; set; }
        public System.DateTime CPH_FECREC { get; set; }
        public System.DateTime CPH_FECFAC { get; set; }
        public Nullable<System.DateTime> CPH_FECPAG { get; set; }
        public decimal CPH_SUBTOT { get; set; }
        public decimal CPH_IMPIVA { get; set; }
        public decimal CPH_IMPTOT { get; set; }
        public decimal CPH_ITOTAL { get; set; }
        public decimal CPH_IMPDES { get; set; }
        public string CPH_SAPDOC { get; set; }
        public string CPH_REFERE { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_CENTROS_COSTOS CA_CENTROS_COSTOS { get; set; }
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_PROVEEDORES CA_PROVEEDORES { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
