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
    
    public partial class CA_ZONAS_GEOGRAFICAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_ZONAS_GEOGRAFICAS()
        {
            this.CA_SUPERVISORES_ZONA = new HashSet<CA_SUPERVISORES_ZONA>();
            this.CA_TIENDAS = new HashSet<CA_TIENDAS>();
        }
    
        public int ZON_KEYZON { get; set; }
        public string ZON_CVEZON { get; set; }
        public string ZON_DESCRI { get; set; }
        public System.DateTime ZON_FEULAC { get; set; }
        public System.DateTime ZON_FECALT { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_SUPERVISORES_ZONA> CA_SUPERVISORES_ZONA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_TIENDAS> CA_TIENDAS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
