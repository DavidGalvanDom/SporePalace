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
    
    public partial class CA_GASTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_GASTOS()
        {
            this.GA_GASTOS_TIENDAS_CONFIG = new HashSet<GA_GASTOS_TIENDAS_CONFIG>();
            this.GA_GASTOS_TIENDAS = new HashSet<GA_GASTOS_TIENDAS>();
        }
    
        public int GAS_KEYGAS { get; set; }
        public Nullable<int> CCO_KEYCCO { get; set; }
        public string GAS_CVEGAS { get; set; }
        public string GAS_DESCRI { get; set; }
        public bool GAS_DEDUCI { get; set; }
        public System.DateTime GAS_FECALT { get; set; }
        public System.DateTime GAS_FEULAC { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_CUENTAS_CONTABLES CA_CUENTAS_CONTABLES { get; set; }
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GA_GASTOS_TIENDAS_CONFIG> GA_GASTOS_TIENDAS_CONFIG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GA_GASTOS_TIENDAS> GA_GASTOS_TIENDAS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
