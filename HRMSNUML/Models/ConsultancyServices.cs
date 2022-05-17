using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRMSNUML.Models
{
    public class ConsultancyServices
    {
        [Key]
        public int CS_Id { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        [MaxLength(200, ErrorMessage = "Maximum 200 characters allowed")]
        public string CS_Title { get; set; }

        [Required(ErrorMessage = "Start Date is Required")]
        [DataType(DataType.DateTime)]
        public DateTime CS_StartDate { get; set; }

        [Required(ErrorMessage = "End Date is Required")]
        [DataType(DataType.DateTime)]
        public DateTime CS_EndDate { get; set; }

        [Required(ErrorMessage = "Company Name is Required")]
        [MaxLength(50, ErrorMessage = "Maximum 50 characters allowed")]
        public string CS_CompanyName { get; set; }

        [Required(ErrorMessage = " Description is Required")]
        [MaxLength(400, ErrorMessage = "Maximum 400 characters allowed")]
        public string CS_Description { get; set; }

        public string CS_Picture { get; set; }

        [NotMapped]
        public HttpPostedFileBase File { get; set; }
    }
}