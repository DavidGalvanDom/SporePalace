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
    
    public partial class CA_MEDIOS_TIENDA
    {
        public int MTI_KEYMTI { get; set; }
        public int TIE_KEYTIE { get; set; }
        public int MEC_KEYMEC { get; set; }
        public string MTI_VALCON { get; set; }
        public System.DateTime MTI_FECALT { get; set; }
        public System.DateTime MTI_FEULAC { get; set; }
        public int EST_KEYEST { get; set; }
        public int USR_KEYUSR { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_MEDIOS_CONTACTO CA_MEDIOS_CONTACTO { get; set; }
        public virtual CA_TIENDAS CA_TIENDAS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}