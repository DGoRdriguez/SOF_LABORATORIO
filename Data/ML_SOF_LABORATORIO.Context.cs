﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BD_AKONTROL_SOF_LABORATORIO : DbContext
    {
        public BD_AKONTROL_SOF_LABORATORIO()
            : base("name=BD_AKONTROL_SOF_LABORATORIO")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_RAUDITORIA> TBL_RAUDITORIA { get; set; }
        public virtual DbSet<TBL_RCOMPANIA> TBL_RCOMPANIA { get; set; }
        public virtual DbSet<TBL_REMPLEADO> TBL_REMPLEADO { get; set; }
        public virtual DbSet<TBL_RPERFIL> TBL_RPERFIL { get; set; }
        public virtual DbSet<TBL_RTIPO_IDENTIFICACION> TBL_RTIPO_IDENTIFICACION { get; set; }
        public virtual DbSet<TBL_RUSUARIO> TBL_RUSUARIO { get; set; }
        public virtual DbSet<TBL_UUSUARIO_PERFIL> TBL_UUSUARIO_PERFIL { get; set; }
    
        public virtual ObjectResult<Nullable<bool>> SPR_GET_ESTADO_COMPANIA(Nullable<long> pI_COM_NID)
        {
            var pI_COM_NIDParameter = pI_COM_NID.HasValue ?
                new ObjectParameter("PI_COM_NID", pI_COM_NID) :
                new ObjectParameter("PI_COM_NID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("SPR_GET_ESTADO_COMPANIA", pI_COM_NIDParameter);
        }
    
        public virtual ObjectResult<SPR_GET_USUARIO_Result> SPR_GET_USUARIO(string pI_CUSUARIO, string pI_CCLAVE)
        {
            var pI_CUSUARIOParameter = pI_CUSUARIO != null ?
                new ObjectParameter("PI_CUSUARIO", pI_CUSUARIO) :
                new ObjectParameter("PI_CUSUARIO", typeof(string));
    
            var pI_CCLAVEParameter = pI_CCLAVE != null ?
                new ObjectParameter("PI_CCLAVE", pI_CCLAVE) :
                new ObjectParameter("PI_CCLAVE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SPR_GET_USUARIO_Result>("SPR_GET_USUARIO", pI_CUSUARIOParameter, pI_CCLAVEParameter);
        }
    }
}
