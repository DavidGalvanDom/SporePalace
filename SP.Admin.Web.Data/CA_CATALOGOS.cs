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
    
    public partial class CA_CATALOGOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_CATALOGOS()
        {
            this.CA_CATALOGOS_DETALLE = new HashSet<CA_CATALOGOS_DETALLE>();
        }
    
        public int CTG_KEYCTG { get; set; }
        public string CTG_CVECTG { get; set; }
        public string CTG_DESCRI { get; set; }
        public System.DateTime CTG_FEULAC { get; set; }
        public System.DateTime CTG_FECALT { get; set; }
        public int EST_KEYEST { get; set; }
        public int USR_KEYUSR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_CATALOGOS_DETALLE> CA_CATALOGOS_DETALLE { get; set; }
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}