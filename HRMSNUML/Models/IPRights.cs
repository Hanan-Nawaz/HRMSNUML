using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRMSNUML.Models
{
    public class IPRights
    {
        [Key]
        public int IPID { get; set; }

        [Required]
        public string IPInventerName { get; set; }

        [Required]
        public string IPLeadInventer { get; set; }

        public int DesignationId { get; set; }

        [Required]
        public string IPTitle { get; set; }

        public int IPRightCategoryId { get; set; }

        [Required]
        public int IPDevelopmentStatus { get; set; }

        [Required]
        public string IPKey_S_Aspects { get; set; }

        public string IPCommericalPartner { get; set; }

        public string IPFormCopy { get; set; }

        [Required]
        public string IPType { get; set; }

        [Required]
        public string IPF_Support { get; set; }
        public string IPDescription { get; set; }

        public string IPStatus { get; set; }

        [DataType("datetime2")]
        public DateTime IPApprovalDate { get; set; }

        [DataType("datetime2")]
        public DateTime IPRegisterDate { get; set; }

        [NotMapped]
        public HttpPostedFileBase File { get; set; }
    }
}