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
    
    public partial class CA_PROMOCIONES_DETALLE
    {
        public int PMD_KEYIDE { get; set; }
        public string PRD_KEYPRD { get; set; }
        public int PRO_KEYPRO { get; set; }
        public Nullable<int> PRD_CANTID { get; set; }
        public System.DateTime PMD_FEULAC { get; set; }
        public System.DateTime PMD_FECALT { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_PRODUCTOS_DETALLE CA_PRODUCTOS_DETALLE { get; set; }
        public virtual CA_PROMOCIONES CA_PROMOCIONES { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
