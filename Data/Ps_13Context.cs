using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ps_13.Data
{
    public class Ps_13Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Ps_13Context() : base("name=Ps_13Context")
        {
        }

        public System.Data.Entity.DbSet<Ps_13.Models.Cricket_Teams> Cricket_Teams { get; set; }
    }
}
