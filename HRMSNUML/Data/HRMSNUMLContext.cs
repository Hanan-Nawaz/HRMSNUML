using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HRMSNUML.Data
{
    public class HRMSNUMLContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public HRMSNUMLContext() : base("name=HRMSNUMLContext")
        {
        }

        public System.Data.Entity.DbSet<HRMSNUML.Models.ConsultancyServices> ConsultancyServices { get; set; }
        public System.Data.Entity.DbSet<HRMSNUML.Models.Notification> Notification { get; set; }
        public System.Data.Entity.DbSet<HRMSNUML.Models.Designation> Designation { get; set; }
        public System.Data.Entity.DbSet<HRMSNUML.Models.IPRightCategory> IPRightCategory { get; set; }
        public System.Data.Entity.DbSet<HRMSNUML.Models.IPRight> IPRight { get; set; }

    }
}
