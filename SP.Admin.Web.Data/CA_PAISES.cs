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
    
    public partial class CA_PAISES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_PAISES()
        {
            this.CA_ESTADOS = new HashSet<CA_ESTADOS>();
        }
    
        public int PAI_KEYPAI { get; set; }
        public string PAI_NOMBRE { get; set; }
        public System.DateTime PAI_FEULAC { get; set; }
        public System.DateTime PAI_FECALT { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_ESTADOS> CA_ESTADOS { get; set; }
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
