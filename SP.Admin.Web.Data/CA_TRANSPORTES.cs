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
    
    public partial class CA_TRANSPORTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_TRANSPORTES()
        {
            this.CA_MEDIOS_TRANSPORTES = new HashSet<CA_MEDIOS_TRANSPORTES>();
            this.DP_DEVOLUCIONES_PROVEEDOR = new HashSet<DP_DEVOLUCIONES_PROVEEDOR>();
            this.TR_TRANSFERENCIAS = new HashSet<TR_TRANSFERENCIAS>();
            this.TT_TIENDA_TRANSPORTE = new HashSet<TT_TIENDA_TRANSPORTE>();
        }
    
        public int TRN_KEYTRN { get; set; }
        public string TRN_DESCRI { get; set; }
        public string TRN_DOMICI { get; set; }
        public string TRN_NUMEXT { get; set; }
        public string TRN_NUMINT { get; set; }
        public string TRN_COLONI { get; set; }
        public string TRN_CODPOS { get; set; }
        public int CIU_KEYCIU { get; set; }
        public bool TRN_CONVEN { get; set; }
        public System.DateTime TRN_FEULAC { get; set; }
        public System.DateTime TRN_FECALT { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_CIUDADES CA_CIUDADES { get; set; }
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CA_MEDIOS_TRANSPORTES> CA_MEDIOS_TRANSPORTES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_DEVOLUCIONES_PROVEEDOR> DP_DEVOLUCIONES_PROVEEDOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TR_TRANSFERENCIAS> TR_TRANSFERENCIAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TT_TIENDA_TRANSPORTE> TT_TIENDA_TRANSPORTE { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}