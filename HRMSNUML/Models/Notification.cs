using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRMSNUML.Models
{
    public class Notification
    {
        [Key]
        public int NTF_Id { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        [MaxLength(200, ErrorMessage = "Maximum 200 characters allowed")]
        public string NTF_Title { get; set; }

        [Required(ErrorMessage = "Date is Required")]
        [DataType(DataType.DateTime)]
        public DateTime NTFDate { get; set; }

        [Required(ErrorMessage = "Remarks is Required")]
        [MaxLength(50, ErrorMessage = "Maximum 400 characters allowed")]
        public string NFT_Remarks { get; set; }

        public string NFT_Picture { get; set; }

        [NotMapped]
        public HttpPostedFileBase File { get; set; }
    }
}