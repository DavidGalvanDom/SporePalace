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
    
    public partial class CF_PARAMETRO_ORDEN_COMPRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CF_PARAMETRO_ORDEN_COMPRA()
        {
            this.CF_ORDEN_COMPRA_DETALLE = new HashSet<CF_ORDEN_COMPRA_DETALLE>();
        }
    
        public int POC_KEYPOC { get; set; }
        public string POC_CVEPOC { get; set; }
        public string POC_DESCRI { get; set; }
        public System.DateTime POC_FEULAC { get; set; }
        public System.DateTime POC_FECALT { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CF_ORDEN_COMPRA_DETALLE> CF_ORDEN_COMPRA_DETALLE { get; set; }
    }
}
