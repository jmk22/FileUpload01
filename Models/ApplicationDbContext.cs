using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload01.Models
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<File> Uploads { get; set; }
    }
}
