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
    
    public partial class CA_PRODUCTO_IMAGENES
    {
        public int IMG_KEYIMG { get; set; }
        public string PRD_PRDMST { get; set; }
        public int IMG_ORDEN { get; set; }
        public byte[] IMG_IMGBIN { get; set; }
        public System.DateTime IMG_FEULAC { get; set; }
        public System.DateTime IMG_FECALT { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_PRODUCTOS CA_PRODUCTOS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}