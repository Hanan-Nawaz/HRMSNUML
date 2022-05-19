using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMSNUML.Models
{
    public class IPRightCategory
    {
        [Key]
        public int IPRightCategoryId { get; set; }

        public string Title { get; set; }
    }
}