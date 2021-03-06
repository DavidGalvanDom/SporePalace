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
    
    public partial class CA_PROMOCIONES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_PROMOCIONES()
        {
            this.CA_PROMOCIONES_RANGOS_DETALLE = new HashSet<CA_PROMOCIONES_RANGOS_DETALLE>();
            this.CA_PROMOCIONES_DETALLE = new HashSet<CA_PROMOCIONES_DETALLE>();
            this.CA_PROMOCIONES_FORMAS_PAGO = new HashSet<CA_PROMOCIONES_FORMAS_PAGO>();
            this.CA_PROMOCIONES_TIENDAS = new HashSet<CA_PROMOCIONES_TIENDAS>();
            this.TD_TRANSACCIONES_DETALLE = new HashSet<TD_TRANSACCIONES_DETALLE>();
        }
    
        public int PRO_KEYPRO { get; set; }
        public int TPC_KEYTPC { get; set; }
        public int PRT_KEYPRT { get; set; }
        public string PRO_CVEPRO { get; set; }
        public string PRO_DESCRI { get; set; }
        public System.DateTime PRO_FECINI { get; set; }
        public System.DateTime PRO_FECFIN { get; set; }
        public System.DateTime PRO_FEULAC { get; set; }
        public System.DateTime PRO_FECALT { get; set; }
        public Nullable<int> PRO_CANCOM { get; set; }
        public Nullable<int> PRO_CANCOB { get; set; }
        public Nullable<decimal> PRO_PORDES { get; set; }
        public int PRO_PRIORI { get; set; }
        public bool PRO_AUTO { get; set; }
        public bool PRO_APLPOR { get; set; }
        public int PRO_APLICA { get; set; }
        public bool PRO_COMBINA { get; set; }
        public Nullable<decimal> PRO_PDESCM { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_PROMOCIONES_RANGOS_DETALLE> CA_PROMOCIONES_RANGOS_DETALLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_PROMOCIONES_DETALLE> CA_PROMOCIONES_DETALLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_PROMOCIONES_FORMAS_PAGO> CA_PROMOCIONES_FORMAS_PAGO { get; set; }
        public virtual CA_PROMOCIONES_RANGOS CA_PROMOCIONES_RANGOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_PROMOCIONES_TIENDAS> CA_PROMOCIONES_TIENDAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TD_TRANSACCIONES_DETALLE> TD_TRANSACCIONES_DETALLE { get; set; }
        public virtual CA_PROMOCIONES_TIPO CA_PROMOCIONES_TIPO { get; set; }
        public virtual CA_TIPOS_CLIENTES CA_TIPOS_CLIENTES { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}
