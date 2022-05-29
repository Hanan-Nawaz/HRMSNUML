using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRMSNUML.Models
{
    public class SkillSubCategory
    {
        [Key]
        public int SkillSubCategoryId { get; set; }

        public string Title { get; set; }

        public virtual int SkillCategoryId { get; set; }

        [ForeignKey("SkillCategoryId")]
        public virtual skillcategory skillcategories { get; set; }
    }
}