using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationTechnology.Models
{
    public class Module
    {
        public virtual int ModuleID { get; set; }
        public virtual string ModuleCode { get; set; }
        public virtual string ModuleTitle { get; set; }
        public virtual string ModuleDescription { get; set; }
        public virtual string ModuleTeacher { get; set; }
        public virtual int CourseID { get; set; }
        public virtual Course Course { get; set; }
    }
}