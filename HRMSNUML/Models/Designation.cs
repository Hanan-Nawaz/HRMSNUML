using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMSNUML.Models
{
    public class Designation
    {
        [Key]
        public int DesignationId { get; set; }

        public string Title { get; set; }

        public bool Status { get; set; }

        public string Scale { get; set; }

        public string DesignationType { get; set; }

        public string Category { get; set; }
    }
}