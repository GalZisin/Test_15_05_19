//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exam_150519_5_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grade
    {
        public int COURSE_ID { get; set; }
        public int STUDENT_ID { get; set; }
        public Nullable<int> GRADE1 { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Student Student { get; set; }
    }
}
