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
    
    public partial class SI_SINCRONIZA
    {
        public int SIN_SINCID { get; set; }
        public int TIE_KEYTIE { get; set; }
        public byte[] SIN_SCRIPT { get; set; }
        public Nullable<int> SIN_TIPSCP { get; set; }
        public Nullable<System.DateTime> SIN_FECALT { get; set; }
        public Nullable<System.DateTime> SIN_FECSIN { get; set; }
        public Nullable<System.DateTime> SIN_FECACT { get; set; }
        public Nullable<int> SIN_STATUS { get; set; }
    
        public virtual CA_TIENDAS CA_TIENDAS { get; set; }
    }
}
