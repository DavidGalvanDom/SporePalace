﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SIRESPAEntities : DbContext
    {
        public SIRESPAEntities()
            : base("name=SIRESPAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AD_PAR_APLINET_DETALLE> AD_PAR_APLINET_DETALLE { get; set; }
        public virtual DbSet<AM_ANIOS_MESES> AM_ANIOS_MESES { get; set; }
        public virtual DbSet<AP_APARTADOS> AP_APARTADOS { get; set; }
        public virtual DbSet<AP_APARTADOS_DETALLE> AP_APARTADOS_DETALLE { get; set; }
        public virtual DbSet<AP_APARTADOS_DETALLE_HISTORICO> AP_APARTADOS_DETALLE_HISTORICO { get; set; }
        public virtual DbSet<AP_APARTADOS_HISTORICO> AP_APARTADOS_HISTORICO { get; set; }
        public virtual DbSet<AS_ASISTENCIAS> AS_ASISTENCIAS { get; set; }
        public virtual DbSet<BC_BIT_CAMBIOS_PRECIOS_TIENDA> BC_BIT_CAMBIOS_PRECIOS_TIENDA { get; set; }
        public virtual DbSet<BC_BITACORA_CAMBIOS_PRECIOS> BC_BITACORA_CAMBIOS_PRECIOS { get; set; }
        public virtual DbSet<BC_BITACORA_COSTO> BC_BITACORA_COSTO { get; set; }
        public virtual DbSet<BI_BITACORA_CAM_VENDEDOR> BI_BITACORA_CAM_VENDEDOR { get; set; }
        public virtual DbSet<BP_BITACORA_POLIZAS> BP_BITACORA_POLIZAS { get; set; }
        public virtual DbSet<BP_BITACORA_PRECIO> BP_BITACORA_PRECIO { get; set; }
        public virtual DbSet<CA_ANIOS> CA_ANIOS { get; set; }
        public virtual DbSet<CA_BANCOS> CA_BANCOS { get; set; }
        public virtual DbSet<CA_CAJAS_REGISTRADORAS> CA_CAJAS_REGISTRADORAS { get; set; }
        public virtual DbSet<CA_CATALOGOS> CA_CATALOGOS { get; set; }
        public virtual DbSet<CA_CATALOGOS_DETALLE> CA_CATALOGOS_DETALLE { get; set; }
        public virtual DbSet<CA_CAUSAS_DEVOLUCIONES> CA_CAUSAS_DEVOLUCIONES { get; set; }
        public virtual DbSet<CA_CAUSAS_NEGADOS> CA_CAUSAS_NEGADOS { get; set; }
        public virtual DbSet<CA_CENTROS_COSTOS> CA_CENTROS_COSTOS { get; set; }
        public virtual DbSet<CA_CIUDADES> CA_CIUDADES { get; set; }
        public virtual DbSet<CA_CLIENTES> CA_CLIENTES { get; set; }
        public virtual DbSet<CA_CLIENTES_FACTURACION> CA_CLIENTES_FACTURACION { get; set; }
        public virtual DbSet<CA_CODIGOS_BARRA> CA_CODIGOS_BARRA { get; set; }
        public virtual DbSet<CA_COLORES> CA_COLORES { get; set; }
        public virtual DbSet<CA_COMPANIA> CA_COMPANIA { get; set; }
        public virtual DbSet<CA_CUENTAS_CONTABLES> CA_CUENTAS_CONTABLES { get; set; }
        public virtual DbSet<CA_DEPARTAMENTOS> CA_DEPARTAMENTOS { get; set; }
        public virtual DbSet<CA_DEVOLUCIONES_CLIENTES> CA_DEVOLUCIONES_CLIENTES { get; set; }
        public virtual DbSet<CA_DIVISIONES> CA_DIVISIONES { get; set; }
        public virtual DbSet<CA_ESTADOS> CA_ESTADOS { get; set; }
        public virtual DbSet<CA_ESTATUS> CA_ESTATUS { get; set; }
        public virtual DbSet<CA_FOLIOS> CA_FOLIOS { get; set; }
        public virtual DbSet<CA_FORMAS_PAGO> CA_FORMAS_PAGO { get; set; }
        public virtual DbSet<CA_GASTOS> CA_GASTOS { get; set; }
        public virtual DbSet<CA_GENEROS> CA_GENEROS { get; set; }
        public virtual DbSet<CA_HORARIOS> CA_HORARIOS { get; set; }
        public virtual DbSet<CA_IMPUESTOS> CA_IMPUESTOS { get; set; }
        public virtual DbSet<CA_INCIDENCIAS> CA_INCIDENCIAS { get; set; }
        public virtual DbSet<CA_LISTAS_PRECIOS> CA_LISTAS_PRECIOS { get; set; }
        public virtual DbSet<CA_LISTAS_PRECIOS_DETALLE> CA_LISTAS_PRECIOS_DETALLE { get; set; }
        public virtual DbSet<CA_LUGARES_ENTREGAS> CA_LUGARES_ENTREGAS { get; set; }
        public virtual DbSet<CA_MARCAS> CA_MARCAS { get; set; }
        public virtual DbSet<CA_MEDIOS_CLIENTE> CA_MEDIOS_CLIENTE { get; set; }
        public virtual DbSet<CA_MEDIOS_CLIENTE_FACTURACION> CA_MEDIOS_CLIENTE_FACTURACION { get; set; }
        public virtual DbSet<CA_MEDIOS_CONTACTO> CA_MEDIOS_CONTACTO { get; set; }
        public virtual DbSet<CA_MEDIOS_PROVEEDOR> CA_MEDIOS_PROVEEDOR { get; set; }
        public virtual DbSet<CA_MEDIOS_TIENDA> CA_MEDIOS_TIENDA { get; set; }
        public virtual DbSet<CA_MEDIOS_TRANSPORTES> CA_MEDIOS_TRANSPORTES { get; set; }
        public virtual DbSet<CA_MESES> CA_MESES { get; set; }
        public virtual DbSet<CA_MODELOS> CA_MODELOS { get; set; }
        public virtual DbSet<CA_MONEDA_DENOMINACION> CA_MONEDA_DENOMINACION { get; set; }
        public virtual DbSet<CA_MONEDAS> CA_MONEDAS { get; set; }
        public virtual DbSet<CA_MOTIVOS_CREDITO> CA_MOTIVOS_CREDITO { get; set; }
        public virtual DbSet<CA_OBJETIVOS_MENSUALES> CA_OBJETIVOS_MENSUALES { get; set; }
        public virtual DbSet<CA_PAISES> CA_PAISES { get; set; }
        public virtual DbSet<CA_PROCESOS> CA_PROCESOS { get; set; }
        public virtual DbSet<CA_PRODUCTO_IMAGENES> CA_PRODUCTO_IMAGENES { get; set; }
        public virtual DbSet<CA_PRODUCTO_RANGO_TALLAS> CA_PRODUCTO_RANGO_TALLAS { get; set; }
        public virtual DbSet<CA_PRODUCTOS> CA_PRODUCTOS { get; set; }
        public virtual DbSet<CA_PRODUCTOS_CVESAT> CA_PRODUCTOS_CVESAT { get; set; }
        public virtual DbSet<CA_PRODUCTOS_DETALLE> CA_PRODUCTOS_DETALLE { get; set; }
        public virtual DbSet<CA_PRODUCTOS_ESTATUS> CA_PRODUCTOS_ESTATUS { get; set; }
        public virtual DbSet<CA_PRODUCTOS_SIMILARES> CA_PRODUCTOS_SIMILARES { get; set; }
        public virtual DbSet<CA_PRODUCTS_YISUS> CA_PRODUCTS_YISUS { get; set; }
        public virtual DbSet<CA_PROMOCIONES> CA_PROMOCIONES { get; set; }
        public virtual DbSet<CA_PROMOCIONES_DETALLE> CA_PROMOCIONES_DETALLE { get; set; }
        public virtual DbSet<CA_PROMOCIONES_FORMAS_PAGO> CA_PROMOCIONES_FORMAS_PAGO { get; set; }
        public virtual DbSet<CA_PROMOCIONES_RANGOS> CA_PROMOCIONES_RANGOS { get; set; }
        public virtual DbSet<CA_PROMOCIONES_RANGOS_DETALLE> CA_PROMOCIONES_RANGOS_DETALLE { get; set; }
        public virtual DbSet<CA_PROMOCIONES_TIENDAS> CA_PROMOCIONES_TIENDAS { get; set; }
        public virtual DbSet<CA_PROMOCIONES_TIPO> CA_PROMOCIONES_TIPO { get; set; }
        public virtual DbSet<CA_PROVEEDORES> CA_PROVEEDORES { get; set; }
        public virtual DbSet<CA_PUESTOS> CA_PUESTOS { get; set; }
        public virtual DbSet<CA_RANGOS> CA_RANGOS { get; set; }
        public virtual DbSet<CA_RANGOS_DETALLE> CA_RANGOS_DETALLE { get; set; }
        public virtual DbSet<CA_RANGOS_PORCENTAJES_COMISION> CA_RANGOS_PORCENTAJES_COMISION { get; set; }
        public virtual DbSet<CA_RESPUESTA_APLINET> CA_RESPUESTA_APLINET { get; set; }
        public virtual DbSet<CA_SEMANAS> CA_SEMANAS { get; set; }
        public virtual DbSet<CA_SILUETAS> CA_SILUETAS { get; set; }
        public virtual DbSet<CA_SUPERVISORES_ZONA> CA_SUPERVISORES_ZONA { get; set; }
        public virtual DbSet<CA_TEMPORADAS> CA_TEMPORADAS { get; set; }
        public virtual DbSet<CA_TEXTO_TICKET> CA_TEXTO_TICKET { get; set; }
        public virtual DbSet<CA_TIENDAS> CA_TIENDAS { get; set; }
        public virtual DbSet<CA_TIENDAS_BANCOS> CA_TIENDAS_BANCOS { get; set; }
        public virtual DbSet<CA_TIENDAS_CONFIGURACION> CA_TIENDAS_CONFIGURACION { get; set; }
        public virtual DbSet<CA_TIPO_DOCUMENTO> CA_TIPO_DOCUMENTO { get; set; }
        public virtual DbSet<CA_TIPOS_CAMBIOS> CA_TIPOS_CAMBIOS { get; set; }
        public virtual DbSet<CA_TIPOS_CLIENTES> CA_TIPOS_CLIENTES { get; set; }
        public virtual DbSet<CA_TIPOS_DIAS> CA_TIPOS_DIAS { get; set; }
        public virtual DbSet<CA_TIPOS_ERRORES> CA_TIPOS_ERRORES { get; set; }
        public virtual DbSet<CA_TIPOS_HORARIOS> CA_TIPOS_HORARIOS { get; set; }
        public virtual DbSet<CA_TIPOS_MOVIMIENTOS> CA_TIPOS_MOVIMIENTOS { get; set; }
        public virtual DbSet<CA_TIPOS_ORDEN_COMPRA> CA_TIPOS_ORDEN_COMPRA { get; set; }
        public virtual DbSet<CA_TIPOS_PRODUCTOS> CA_TIPOS_PRODUCTOS { get; set; }
        public virtual DbSet<CA_TIPOS_TIENDA> CA_TIPOS_TIENDA { get; set; }
        public virtual DbSet<CA_TIPOS_TRANSFERENCIA> CA_TIPOS_TRANSFERENCIA { get; set; }
        public virtual DbSet<CA_TRANSPORTES> CA_TRANSPORTES { get; set; }
        public virtual DbSet<CA_USOS> CA_USOS { get; set; }
        public virtual DbSet<CA_USUARIOS> CA_USUARIOS { get; set; }
        public virtual DbSet<CA_ZONAS_GEOGRAFICAS> CA_ZONAS_GEOGRAFICAS { get; set; }
        public virtual DbSet<CC_CORTE_CAJA> CC_CORTE_CAJA { get; set; }
        public virtual DbSet<CD_CICLICO_DIFERENCIAS> CD_CICLICO_DIFERENCIAS { get; set; }
        public virtual DbSet<CD_CODIGO_DESCUENTO> CD_CODIGO_DESCUENTO { get; set; }
        public virtual DbSet<CD_CODIGOS_AUTORIZACION> CD_CODIGOS_AUTORIZACION { get; set; }
        public virtual DbSet<CD_CORTE_CAJA_DETALLE> CD_CORTE_CAJA_DETALLE { get; set; }
        public virtual DbSet<CE_CREDITO_EMPLEADOS> CE_CREDITO_EMPLEADOS { get; set; }
        public virtual DbSet<CF_CLIENTE_FRECUENTE> CF_CLIENTE_FRECUENTE { get; set; }
        public virtual DbSet<CF_ORDEN_COMPRA> CF_ORDEN_COMPRA { get; set; }
        public virtual DbSet<CF_ORDEN_COMPRA_DETALLE> CF_ORDEN_COMPRA_DETALLE { get; set; }
        public virtual DbSet<CF_PARAMETRO_ORDEN_COMPRA> CF_PARAMETRO_ORDEN_COMPRA { get; set; }
        public virtual DbSet<CP_CUENTAS_POR_PAGAR> CP_CUENTAS_POR_PAGAR { get; set; }
        public virtual DbSet<CP_CUENTAS_POR_PAGAR_HISTORICO> CP_CUENTAS_POR_PAGAR_HISTORICO { get; set; }
        public virtual DbSet<CR_CICLICO_RECAPITULACION> CR_CICLICO_RECAPITULACION { get; set; }
        public virtual DbSet<CR_CICLICO_RESUMEN> CR_CICLICO_RESUMEN { get; set; }
        public virtual DbSet<CT_CANCELACION_TICKET> CT_CANCELACION_TICKET { get; set; }
        public virtual DbSet<CU_CUPONES> CU_CUPONES { get; set; }
        public virtual DbSet<DE_DEPOSITOS> DE_DEPOSITOS { get; set; }
        public virtual DbSet<DP_DEVOLUCIONES_PROVEEDOR> DP_DEVOLUCIONES_PROVEEDOR { get; set; }
        public virtual DbSet<DP_DEVOLUCIONES_PROVEEDOR_DETALLE> DP_DEVOLUCIONES_PROVEEDOR_DETALLE { get; set; }
        public virtual DbSet<EE_ERROR_EMBARQUE> EE_ERROR_EMBARQUE { get; set; }
        public virtual DbSet<EP_ESTATUS_PROCESOS> EP_ESTATUS_PROCESOS { get; set; }
        public virtual DbSet<ER_ERRORES> ER_ERRORES { get; set; }
        public virtual DbSet<FE_FOLIO_FACTURA_ELECTRONICA> FE_FOLIO_FACTURA_ELECTRONICA { get; set; }
        public virtual DbSet<FL_FLETES> FL_FLETES { get; set; }
        public virtual DbSet<FS_FOLIOS_SALIDA> FS_FOLIOS_SALIDA { get; set; }
        public virtual DbSet<GA_GASTOS_TIENDAS> GA_GASTOS_TIENDAS { get; set; }
        public virtual DbSet<GA_GASTOS_TIENDAS_CONFIG> GA_GASTOS_TIENDAS_CONFIG { get; set; }
        public virtual DbSet<IN_INCIDENCIAS> IN_INCIDENCIAS { get; set; }
        public virtual DbSet<IN_INVENTARIOS> IN_INVENTARIOS { get; set; }
        public virtual DbSet<IN_INVENTARIOS_HISTORICO> IN_INVENTARIOS_HISTORICO { get; set; }
        public virtual DbSet<MA_MOVIMIENTOS_APARTADO> MA_MOVIMIENTOS_APARTADO { get; set; }
        public virtual DbSet<MI_MOVIMIENTOS_INVENTARIO> MI_MOVIMIENTOS_INVENTARIO { get; set; }
        public virtual DbSet<MP_MOVIMIENTOS_PRODUCTO> MP_MOVIMIENTOS_PRODUCTO { get; set; }
        public virtual DbSet<NC_AUTORIZA_DEV_EFECTIVO> NC_AUTORIZA_DEV_EFECTIVO { get; set; }
        public virtual DbSet<NC_NOTA_CREDITO> NC_NOTA_CREDITO { get; set; }
        public virtual DbSet<NE_NEGATIVOS> NE_NEGATIVOS { get; set; }
        public virtual DbSet<OC_ORDENES_COMPRA> OC_ORDENES_COMPRA { get; set; }
        public virtual DbSet<OC_ORDENES_COMPRA_DETALLE> OC_ORDENES_COMPRA_DETALLE { get; set; }
        public virtual DbSet<PA_PAR_APLINET> PA_PAR_APLINET { get; set; }
        public virtual DbSet<PN_PRODUCTOS_NEGADOS> PN_PRODUCTOS_NEGADOS { get; set; }
        public virtual DbSet<RE_RECIBO_ELECTRONICO> RE_RECIBO_ELECTRONICO { get; set; }
        public virtual DbSet<RE_RECIBO_ELECTRONICO_DETALLE> RE_RECIBO_ELECTRONICO_DETALLE { get; set; }
        public virtual DbSet<RF_REFERE_FACELEC> RF_REFERE_FACELEC { get; set; }
        public virtual DbSet<RO_ROLES> RO_ROLES { get; set; }
        public virtual DbSet<SE_COMPANIAS> SE_COMPANIAS { get; set; }
        public virtual DbSet<SE_SEC_PROCESOS_ESTATUS> SE_SEC_PROCESOS_ESTATUS { get; set; }
        public virtual DbSet<SI_SINCRONIZA> SI_SINCRONIZA { get; set; }
        public virtual DbSet<SP_SCRIPT_PUNTO_VENTA> SP_SCRIPT_PUNTO_VENTA { get; set; }
        public virtual DbSet<TC_TIENDAS_CIERRE> TC_TIENDAS_CIERRE { get; set; }
        public virtual DbSet<TD_TIENDAS_DOCUMENTOS> TD_TIENDAS_DOCUMENTOS { get; set; }
        public virtual DbSet<TD_TRANSACCIONES_DETALLE> TD_TRANSACCIONES_DETALLE { get; set; }
        public virtual DbSet<TF_TIENDAS_FORMAS_PAGO> TF_TIENDAS_FORMAS_PAGO { get; set; }
        public virtual DbSet<TH_TRAFICO_HISTORICO> TH_TRAFICO_HISTORICO { get; set; }
        public virtual DbSet<TP_TIPO_PAGO_IMPORTE> TP_TIPO_PAGO_IMPORTE { get; set; }
        public virtual DbSet<TR_TRANSACCIONES> TR_TRANSACCIONES { get; set; }
        public virtual DbSet<TR_TRANSFERENCIAS> TR_TRANSFERENCIAS { get; set; }
        public virtual DbSet<TR_TRANSFERENCIAS_CONFIGURACION> TR_TRANSFERENCIAS_CONFIGURACION { get; set; }
        public virtual DbSet<TR_TRANSFERENCIAS_DETALLE> TR_TRANSFERENCIAS_DETALLE { get; set; }
        public virtual DbSet<TT_TICKET_TARJETA> TT_TICKET_TARJETA { get; set; }
        public virtual DbSet<TT_TICKET_TARJETA_APARTADO> TT_TICKET_TARJETA_APARTADO { get; set; }
        public virtual DbSet<TT_TIENDA_TRANSPORTE> TT_TIENDA_TRANSPORTE { get; set; }
        public virtual DbSet<VE_VALES_EMPLEADOS> VE_VALES_EMPLEADOS { get; set; }
        public virtual DbSet<VE_VENTAS_EMPLEADOS> VE_VENTAS_EMPLEADOS { get; set; }
        public virtual DbSet<CA_PLANTILLAS_TALLA> CA_PLANTILLAS_TALLA { get; set; }
        public virtual DbSet<DT_TRANSFERENCIAS_DETALLE_HISTORICO> DT_TRANSFERENCIAS_DETALLE_HISTORICO { get; set; }
        public virtual DbSet<log_log> log_log { get; set; }
    }
}
