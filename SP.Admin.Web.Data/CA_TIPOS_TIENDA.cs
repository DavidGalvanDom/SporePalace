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
    
    public partial class CA_TIPOS_TIENDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_TIPOS_TIENDA()
        {
            this.CA_TIENDAS = new HashSet<CA_TIENDAS>();
            this.TR_TRANSFERENCIAS_CONFIGURACION = new HashSet<TR_TRANSFERENCIAS_CONFIGURACION>();
            this.TR_TRANSFERENCIAS_CONFIGURACION1 = new HashSet<TR_TRANSFERENCIAS_CONFIGURACION>();
        }
    
        public int TTI_KEYTTI { get; set; }
        public string TTI_CVETTI { get; set; }
        public string TTI_DESCRI { get; set; }
        public System.DateTime TIT_FEULAC { get; set; }
        public System.DateTime TIT_FECALT { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_TIENDAS> CA_TIENDAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TR_TRANSFERENCIAS_CONFIGURACION> TR_TRANSFERENCIAS_CONFIGURACION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TR_TRANSFERENCIAS_CONFIGURACION> TR_TRANSFERENCIAS_CONFIGURACION1 { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
