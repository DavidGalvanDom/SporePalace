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
    
    public partial class CA_CATALOGOS_DETALLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_CATALOGOS_DETALLE()
        {
            this.CT_CANCELACION_TICKET = new HashSet<CT_CANCELACION_TICKET>();
        }
    
        public int CTD_KEYCTD { get; set; }
        public int CTG_KEYCTG { get; set; }
        public string CTD_VALCTD { get; set; }
        public System.DateTime CTD_FEULAC { get; set; }
        public System.DateTime CTD_FECALT { get; set; }
        public int EST_KEYEST { get; set; }
        public int USR_KEYUSR { get; set; }
    
        public virtual CA_CATALOGOS CA_CATALOGOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_CANCELACION_TICKET> CT_CANCELACION_TICKET { get; set; }
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
