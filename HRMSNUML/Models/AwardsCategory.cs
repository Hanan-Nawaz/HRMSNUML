using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMSNUML.Models
{
    public class AwardsCategory
    {

        [Key]
        public int AwardCategoryId { get; set; }

        public string Title { get; set; }

        public byte Status { get; set; }

    }
}