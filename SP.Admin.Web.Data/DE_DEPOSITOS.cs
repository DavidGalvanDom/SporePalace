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
    
    public partial class DE_DEPOSITOS
    {
        public int DEP_KEYDEP { get; set; }
        public int TIE_KEYTIE { get; set; }
        public int USR_KEYDEP { get; set; }
        public int BAN_KEYBAN { get; set; }
        public int MON_KEYMON { get; set; }
        public decimal DEP_IMPDEP { get; set; }
        public string DEP_FICDEP { get; set; }
        public System.DateTime DEP_FECDEP { get; set; }
        public string DEP_FECCIE { get; set; }
        public System.DateTime DEP_FECCAP { get; set; }
        public System.DateTime DEP_FECALT { get; set; }
        public System.DateTime DEP_FEULAC { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
        public string DEP_OBSERV { get; set; }
    
        public virtual CA_BANCOS CA_BANCOS { get; set; }
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_MONEDAS CA_MONEDAS { get; set; }
        public virtual CA_TIENDAS CA_TIENDAS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS1 { get; set; }
    }
}