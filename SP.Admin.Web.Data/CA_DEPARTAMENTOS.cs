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
    
    public partial class CA_DEPARTAMENTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_DEPARTAMENTOS()
        {
            this.EE_ERROR_EMBARQUE = new HashSet<EE_ERROR_EMBARQUE>();
        }
    
        public int DEP_KEYDEP { get; set; }
        public int CEC_KEYCEC { get; set; }
        public string DEP_CVEDEP { get; set; }
        public string DEP_DESCRI { get; set; }
        public System.DateTime DEP_FEULAC { get; set; }
        public System.DateTime DEP_FECALT { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_CENTROS_COSTOS CA_CENTROS_COSTOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EE_ERROR_EMBARQUE> EE_ERROR_EMBARQUE { get; set; }
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
