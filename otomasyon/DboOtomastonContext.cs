using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasyon
{
    internal class DboOtomasyonContext:DbContext
    {
        public DbSet<employee> employees { get; set; }
    }
}
