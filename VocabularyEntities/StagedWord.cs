//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VocabularyEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class StagedWord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StagedWord()
        {
            this.Histories = new HashSet<History>();
        }
    
        public int UserKey { get; set; }
        public int WordId { get; set; }
        public int PassedCount { get; set; }
    
        public virtual User User { get; set; }
        public virtual Word Word { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<History> Histories { get; set; }
    }
}
