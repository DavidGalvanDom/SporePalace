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
    
    public partial class CA_TIPOS_CAMBIOS
    {
        public int CAM_KEYCAM { get; set; }
        public int MON_KEYMON { get; set; }
        public decimal CAM_CANTID { get; set; }
        public System.DateTime CAM_FECCAM { get; set; }
        public System.DateTime CAM_FEULAC { get; set; }
        public System.DateTime CAM_FECALT { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_MONEDAS CA_MONEDAS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
