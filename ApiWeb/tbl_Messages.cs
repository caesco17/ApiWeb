//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Messages
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Messages()
        {
            this.tbl_SendingMessages = new HashSet<tbl_SendingMessages>();
        }
    
        public long MessageId { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string SendTo { get; set; }
        public string MessageValue { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SendingMessages> tbl_SendingMessages { get; set; }
    }
}
