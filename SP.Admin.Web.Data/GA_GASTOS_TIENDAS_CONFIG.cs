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
    
    public partial class GA_GASTOS_TIENDAS_CONFIG
    {
        public int TIE_KEYTIE { get; set; }
        public int GAS_KEYGAS { get; set; }
        public int ANI_KEYANI { get; set; }
        public short MES_KEYMES { get; set; }
        public decimal GTC_TOPGAS { get; set; }
        public System.DateTime GTC_FECALT { get; set; }
        public System.DateTime GTC_FEULAC { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual AM_ANIOS_MESES AM_ANIOS_MESES { get; set; }
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_GASTOS CA_GASTOS { get; set; }
        public virtual CA_TIENDAS CA_TIENDAS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
