using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRMSNUML.Models
{
    public class Award
    {
        [Key]
        public int Award_Id { get; set; }

        public string Award_Title { get; set; }

        public DateTime Award_Date { get; set; }

        public int Award_CategoryID { get; set; }

        public string Award_Description { get; set; }

        public string Award_Type { get; set; }

        public string Award_Picture { get; set; }

        [NotMapped]
        public HttpPostedFileBase File { get; set; }
    }
}