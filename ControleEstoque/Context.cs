using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque
{

    public class Context:DbContext
    {
        public Context(): base("BD")
        {

        }
        public DbSet<DtoUser> usuario { get; set; }

        public DbSet<DtoProduct> produto { get; set; }
    }
}
