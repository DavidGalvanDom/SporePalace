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
    
    public partial class CA_INCIDENCIAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_INCIDENCIAS()
        {
            this.IN_INCIDENCIAS = new HashSet<IN_INCIDENCIAS>();
        }
    
        public int INC_KEYINC { get; set; }
        public string INC_CVEINC { get; set; }
        public string INC_DESCRI { get; set; }
        public System.DateTime INC_FECALT { get; set; }
        public System.DateTime INC_FEULAC { get; set; }
        public int EST_KEYEST { get; set; }
        public int USR_KEYUSR { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IN_INCIDENCIAS> IN_INCIDENCIAS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}