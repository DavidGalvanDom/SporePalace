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
    
    public partial class CR_CICLICO_RESUMEN
    {
        public int CIR_KEYIDE { get; set; }
        public string SEM_KEYSEM { get; set; }
        public int TIE_KEYTIE { get; set; }
        public int DIV_KEYDIV { get; set; }
        public System.DateTime CIR_FEULAC { get; set; }
        public decimal CIR_DEVTRA { get; set; }
        public decimal CIR_DIFMEN { get; set; }
        public decimal CIR_DIFMAS { get; set; }
        public decimal CIR_VENSEM { get; set; }
        public decimal CIR_MERREC { get; set; }
        public decimal CIR_SALANT { get; set; }
        public string CIR_OBDIMA { get; set; }
        public string CIR_OBDIME { get; set; }
        public string CIR_OBVDIF { get; set; }
        public string CIR_OBDETR { get; set; }
        public string CIR_OBVESE { get; set; }
        public string CIR_OBMERE { get; set; }
        public string CIR_OBSAAN { get; set; }
        public string CIR_OBSAAC { get; set; }
        public string CIR_OBTOIG { get; set; }
        public System.DateTime CIR_FECALT { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_DIVISIONES CA_DIVISIONES { get; set; }
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_SEMANAS CA_SEMANAS { get; set; }
        public virtual CA_TIENDAS CA_TIENDAS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
