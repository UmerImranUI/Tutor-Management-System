//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseProject.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class teacher_salary_details
    {
        public int teacher_salary_details_id { get; set; }
        public Nullable<int> teacher_salary_id { get; set; }
        public Nullable<int> teacher_course_id { get; set; }
        public Nullable<bool> paid { get; set; }
    
        public virtual teacher_courses teacher_courses { get; set; }
        public virtual teacher_salaries teacher_salaries { get; set; }
    }
}
