//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class TBL_RAUDITORIA
    {
        public long AUD_NID { get; set; }
        public System.DateTime AUD_DFECHA { get; set; }
        public long USU_NID { get; set; }
        public string AUD_CDESCRIPCION { get; set; }
        public string AUD_CTABLA_AFECTADA { get; set; }
    
        public virtual TBL_RUSUARIO TBL_RUSUARIO { get; set; }
    }
}
