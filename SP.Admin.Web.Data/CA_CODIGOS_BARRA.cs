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
    
    public partial class CA_CODIGOS_BARRA
    {
        public int COB_KEYIDE { get; set; }
        public string PRD_KEYPRD { get; set; }
        public int RAN_KEYRAN { get; set; }
        public string RAD_KEYTAL { get; set; }
        public string COB_COBUPC { get; set; }
        public string COB_COBNOR { get; set; }
        public System.DateTime COB_FECALT { get; set; }
        public System.DateTime COB_FEULAC { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_PRODUCTO_RANGO_TALLAS CA_PRODUCTO_RANGO_TALLAS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
