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
    
    public partial class CA_CAUSAS_NEGADOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_CAUSAS_NEGADOS()
        {
            this.PN_PRODUCTOS_NEGADOS = new HashSet<PN_PRODUCTOS_NEGADOS>();
        }
    
        public int CAN_KEYCAN { get; set; }
        public string CAN_DESCRI { get; set; }
        public System.DateTime CAN_FEULAC { get; set; }
        public System.DateTime CAN_FECALT { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PN_PRODUCTOS_NEGADOS> PN_PRODUCTOS_NEGADOS { get; set; }
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
