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
    
    public partial class CR_CICLICO_RECAPITULACION
    {
        public int CRE_KEYIDE { get; set; }
        public string SEM_KEYSEM { get; set; }
        public int TIE_KEYTIE { get; set; }
        public int GEN_KEYGEN { get; set; }
        public int CRE_INFGEN { get; set; }
        public int CRE_INLGEN { get; set; }
        public string CRE_OBSERV { get; set; }
        public System.DateTime CRE_FEULAC { get; set; }
        public Nullable<System.DateTime> CRE_FECALT { get; set; }
        public int EST_KEYEST { get; set; }
        public int USR_KEYUSR { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_GENEROS CA_GENEROS { get; set; }
        public virtual CA_SEMANAS CA_SEMANAS { get; set; }
        public virtual CA_TIENDAS CA_TIENDAS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}