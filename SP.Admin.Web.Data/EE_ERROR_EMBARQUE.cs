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
    
    public partial class EE_ERROR_EMBARQUE
    {
        public int EEE_KEYIDE { get; set; }
        public System.DateTime EEE_FECERR { get; set; }
        public int TER_KEYTER { get; set; }
        public int DEP_KEYDEP { get; set; }
        public string EEE_DESCRI { get; set; }
        public Nullable<System.DateTime> EEE_FECSOL { get; set; }
        public string EEE_SOLUCI { get; set; }
        public System.DateTime EEE_FEULAC { get; set; }
        public System.DateTime EEE_FECALT { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_DEPARTAMENTOS CA_DEPARTAMENTOS { get; set; }
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_TIPOS_ERRORES CA_TIPOS_ERRORES { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
