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
    
    public partial class EP_ESTATUS_PROCESOS
    {
        public int EPR_KEYIDE { get; set; }
        public int EST_KEYEST { get; set; }
        public int PRO_KEYPRO { get; set; }
        public int PRO_ORDENA { get; set; }
        public string PRO_BLOQUE { get; set; }
        public System.DateTime EPR_FEULAC { get; set; }
        public System.DateTime EPR_FECALT { get; set; }
        public int USR_KEYUSR { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_PROCESOS CA_PROCESOS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
