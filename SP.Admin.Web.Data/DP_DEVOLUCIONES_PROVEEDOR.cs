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
    
    public partial class DP_DEVOLUCIONES_PROVEEDOR
    {
        public int DEV_KEYDEV { get; set; }
        public int PRV_KEYPRV { get; set; }
        public string DEV_REFERE { get; set; }
        public int DEV_CANDEV { get; set; }
        public decimal DEV_IMPSUB { get; set; }
        public decimal DEV_IMPIVA { get; set; }
        public decimal DEV_IMPTOT { get; set; }
        public System.DateTime DEV_FECCAP { get; set; }
        public Nullable<System.DateTime> DEV_FECAPL { get; set; }
        public Nullable<System.DateTime> DEV_FECCAN { get; set; }
        public byte[] DEV_DOCUME { get; set; }
        public Nullable<int> TRN_KEYTRN { get; set; }
        public string DEV_NOGUIA { get; set; }
        public System.DateTime DEV_FECALT { get; set; }
        public System.DateTime DEV_FEULAC { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_PROVEEDORES CA_PROVEEDORES { get; set; }
        public virtual CA_TRANSPORTES CA_TRANSPORTES { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
    }
}