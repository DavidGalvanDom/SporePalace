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
    
    public partial class CA_DIVISIONES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_DIVISIONES()
        {
            this.CA_PRODUCTOS = new HashSet<CA_PRODUCTOS>();
            this.CR_CICLICO_RESUMEN = new HashSet<CR_CICLICO_RESUMEN>();
        }
    
        public int DIV_KEYDIV { get; set; }
        public string DIV_CVEDIV { get; set; }
        public string DIV_DESCRI { get; set; }
        public System.DateTime DIV_FEULAC { get; set; }
        public System.DateTime DIV_FECALT { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_PRODUCTOS> CA_PRODUCTOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CR_CICLICO_RESUMEN> CR_CICLICO_RESUMEN { get; set; }
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}