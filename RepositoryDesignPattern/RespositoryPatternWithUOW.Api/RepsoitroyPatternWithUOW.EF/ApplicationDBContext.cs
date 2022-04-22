using Microsoft.EntityFrameworkCore;
using RepsoitroyPatternWithUOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepsoitroyPatternWithUOW.EF
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        DbSet<Author> Authors { get; set; }
        DbSet<Book> Books { get; set; }
    }
}

