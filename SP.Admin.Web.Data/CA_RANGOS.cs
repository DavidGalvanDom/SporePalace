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
    
    public partial class CA_RANGOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_RANGOS()
        {
            this.CA_PRODUCTOS = new HashSet<CA_PRODUCTOS>();
            this.CA_RANGOS_DETALLE = new HashSet<CA_RANGOS_DETALLE>();
        }
    
        public int RAN_KEYRAN { get; set; }
        public string RAN_CVERAN { get; set; }
        public string RAN_DESCRI { get; set; }
        public System.DateTime RAN_FEULAC { get; set; }
        public System.DateTime RAN_FECALT { get; set; }
        public int EST_KEYEST { get; set; }
        public int USR_KEYUSR { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_PRODUCTOS> CA_PRODUCTOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_RANGOS_DETALLE> CA_RANGOS_DETALLE { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
