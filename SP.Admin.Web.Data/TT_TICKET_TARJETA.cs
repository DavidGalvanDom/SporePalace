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
    
    public partial class TT_TICKET_TARJETA
    {
        public int TIT_KEYTIT { get; set; }
        public int TRA_KEYTRA { get; set; }
        public int TIE_KEYTIE { get; set; }
        public string TDO_KEYTDO { get; set; }
        public int FPA_KEYFPA { get; set; }
        public string TIT_NUMAUT { get; set; }
        public string TIT_NUMTAR { get; set; }
        public decimal TIT_IMPORT { get; set; }
        public System.DateTime TIT_FECMOV { get; set; }
        public string TIT_REFFIN { get; set; }
        public int USR_KEYUSR { get; set; }
        public int EST_KEYEST { get; set; }
    
        public virtual CA_ESTATUS CA_ESTATUS { get; set; }
        public virtual CA_USUARIOS CA_USUARIOS { get; set; }
        public virtual TP_TIPO_PAGO_IMPORTE TP_TIPO_PAGO_IMPORTE { get; set; }
    }
}