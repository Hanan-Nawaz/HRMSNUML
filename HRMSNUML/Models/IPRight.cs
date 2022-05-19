using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRMSNUML.Models
{
    public class IPRight
    {
        [Key]
        public int IPID { get; set; }

        [Required]
        public string IPInventerName { get; set; }

        [Required]
        public string IPLeadInventer { get; set; }

        [ForeignKey("DesignationId")]
        public int DesignationId { get; set; }
        public virtual Designation Designation { get; set; }

        [Required]
        public string IPTitle { get; set; }

        [ForeignKey("IPRightCategoryId")]
        public int IPCadtegoryId { get; set; }

        [Required]
        public int IPDevelopmentStatus { get; set; }

        [Required]
        public string IPKey_S_Aspects { get; set; }

        public string IPCommericalPartner{ get; set; }

        [Required]
        public string IPFormCopy { get; set; }

        [Required]
        public string IPType { get; set; }

        [Required]
        public string IPF_Support { get; set; }
        public string IPDescription { get; set; }

        [Required]
        public string IPStatus { get; set; }

        public DateTime IPApprovalDate { get; set; }
        public DateTime IPRegisterDate{ get; set; }

    }
}