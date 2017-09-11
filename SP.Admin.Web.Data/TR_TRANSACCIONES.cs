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
    
    public partial class TR_TRANSACCIONES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TR_TRANSACCIONES()
        {
            this.CE_CREDITO_EMPLEADOS = new HashSet<CE_CREDITO_EMPLEADOS>();
            this.NC_NOTA_CREDITO = new HashSet<NC_NOTA_CREDITO>();
            this.RF_REFERE_FACELEC = new HashSet<RF_REFERE_FACELEC>();
            this.TD_TRANSACCIONES_DETALLE = new HashSet<TD_TRANSACCIONES_DETALLE>();
            this.TP_TIPO_PAGO_IMPORTE = new HashSet<TP_TIPO_PAGO_IMPORTE>();
            this.VE_VENTAS_EMPLEADOS = new HashSet<VE_VENTAS_EMPLEADOS>();
        }
    
        public int TRA_KEYIDE { get; set; }
        public int TRA_KEYTRA { get; set; }
        public string TDO_KEYTDO { get; set; }
        public int TIE_KEYTIE { get; set; }
        public int CRE_KEYCRE { get; set; }
        public Nullable<int> CLI_KEYCLI { get; set; }
        public Nullable<int> EMP_KEYEMP { get; set; }
        public int TRA_CANTID { get; set; }
        public Nullable<decimal> TRA_SUBTOT { get; set; }
        public decimal TRA_IMPIVA { get; set; }
        public decimal TRA_IMPTOT { get; set; }
        public string TRA_CODFAC { get; set; }
        public System.DateTime TRA_FECSYS { get; set; }
        public string TRA_SERFAC { get; set; }
        public Nullable<int> TRA_FOLFAC { get; set; }
        public string TRA_STSAPL { get; set; }
        public System.DateTime TRA_FECMOV { get; set; }
        public int EST_KEYEST { get; set; }
        public int USR_KEYUSR { get; set; }
    
        public virtual CA_CAJAS_REGISTRADORAS CA_CAJAS_REGISTRADORAS { get; set; }
        public virtual CA_CLIENTES CA_CLIENTES { get; set; }
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_TIPO_DOCUMENTO CA_TIPO_DOCUMENTO { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CE_CREDITO_EMPLEADOS> CE_CREDITO_EMPLEADOS { get; set; }
        public virtual CT_CANCELACION_TICKET CT_CANCELACION_TICKET { get; set; }
        public virtual NC_AUTORIZA_DEV_EFECTIVO NC_AUTORIZA_DEV_EFECTIVO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NC_NOTA_CREDITO> NC_NOTA_CREDITO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RF_REFERE_FACELEC> RF_REFERE_FACELEC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TD_TRANSACCIONES_DETALLE> TD_TRANSACCIONES_DETALLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TP_TIPO_PAGO_IMPORTE> TP_TIPO_PAGO_IMPORTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VE_VENTAS_EMPLEADOS> VE_VENTAS_EMPLEADOS { get; set; }
    }
}