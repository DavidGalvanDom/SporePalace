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
    
    public partial class OC_ORDENES_COMPRA_DETALLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OC_ORDENES_COMPRA_DETALLE()
        {
            this.RE_RECIBO_ELECTRONICO_DETALLE = new HashSet<RE_RECIBO_ELECTRONICO_DETALLE>();
        }
    
        public int OCD_KEYIDE { get; set; }
        public int OCO_KEYOCO { get; set; }
        public int TIE_KEYTIE { get; set; }
        public string PRD_KEYPRD { get; set; }
        public int RAN_KEYRAN { get; set; }
        public string RAD_KEYTAL { get; set; }
        public int LUE_KEYLUE { get; set; }
        public decimal OCD_COSORD { get; set; }
        public decimal OCD_COSREC { get; set; }
        public decimal OCD_PREMAX { get; set; }
        public int OCD_CANORD { get; set; }
        public int OCD_CANREC { get; set; }
        public int OCD_CANCAN { get; set; }
        public Nullable<System.DateTime> OCD_FECREC { get; set; }
        public Nullable<System.DateTime> OCD_FECCAN { get; set; }
        public decimal OCD_DESCTO { get; set; }
        public Nullable<int> OCD_NFOLIO { get; set; }
        public string OCD_NSERIE { get; set; }
        public string OCD_REFERE { get; set; }
        public Nullable<int> OCD_KEYREN { get; set; }
        public string OCD_LOTE { get; set; }
        public string OCD_OBSERV { get; set; }
        public System.DateTime OCD_FECALT { get; set; }
        public System.DateTime OCD_FEULAC { get; set; }
        public int EST_KEYEST { get; set; }
        public int USR_KEYUSR { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_LUGARES_ENTREGAS CA_LUGARES_ENTREGAS { get; set; }
        public virtual CA_PRODUCTO_RANGO_TALLAS CA_PRODUCTO_RANGO_TALLAS { get; set; }
        public virtual CA_TIENDAS CA_TIENDAS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
        public virtual OC_ORDENES_COMPRA OC_ORDENES_COMPRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RE_RECIBO_ELECTRONICO_DETALLE> RE_RECIBO_ELECTRONICO_DETALLE { get; set; }
    }
}
