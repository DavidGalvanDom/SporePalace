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
    
    public partial class CA_MEDIOS_CONTACTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_MEDIOS_CONTACTO()
        {
            this.CA_MEDIOS_CLIENTE = new HashSet<CA_MEDIOS_CLIENTE>();
            this.CA_MEDIOS_CLIENTE_FACTURACION = new HashSet<CA_MEDIOS_CLIENTE_FACTURACION>();
            this.CA_MEDIOS_PROVEEDOR = new HashSet<CA_MEDIOS_PROVEEDOR>();
            this.CA_MEDIOS_TIENDA = new HashSet<CA_MEDIOS_TIENDA>();
            this.CA_MEDIOS_TRANSPORTES = new HashSet<CA_MEDIOS_TRANSPORTES>();
        }
    
        public int MEC_KEYMEC { get; set; }
        public string MEC_DESCRI { get; set; }
        public System.DateTime MEC_FEULAC { get; set; }
        public System.DateTime MEC_FECALT { get; set; }
        public int EST_KEYEST { get; set; }
        public int USR_KEYUSR { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_MEDIOS_CLIENTE> CA_MEDIOS_CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_MEDIOS_CLIENTE_FACTURACION> CA_MEDIOS_CLIENTE_FACTURACION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_MEDIOS_PROVEEDOR> CA_MEDIOS_PROVEEDOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_MEDIOS_TIENDA> CA_MEDIOS_TIENDA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_MEDIOS_TRANSPORTES> CA_MEDIOS_TRANSPORTES { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
