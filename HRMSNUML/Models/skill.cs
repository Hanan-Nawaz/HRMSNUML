using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMSNUML.Models
{
    public class skill
    {
        [Key]
        public int SkillId { get; set; }

        public int skillCategoryID { get; set; }

        public int SkillSubCategoryId { get; set; }
        public string BreifBiography { get; set; }

    }
}