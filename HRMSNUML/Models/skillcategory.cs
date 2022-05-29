using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMSNUML.Models
{
    public class skillcategory
    {

        [Key]
        public int SkillCategoryId { get; set; }

        public string Title { get; set; }
    }
}