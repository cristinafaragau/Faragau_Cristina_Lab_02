using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Faragau_Cristina_Lab_02.Models;

namespace Faragau_Cristina_Lab_02.Data
{
    public class Faragau_Cristina_Lab_02Context : DbContext
    {
        public Faragau_Cristina_Lab_02Context (DbContextOptions<Faragau_Cristina_Lab_02Context> options)
            : base(options)
        {
        }

        public DbSet<Faragau_Cristina_Lab_02.Models.Book> Book { get; set; } = default!;

        public DbSet<Faragau_Cristina_Lab_02.Models.Publisher> Publisher { get; set; }

        public DbSet<Faragau_Cristina_Lab_02.Models.Author> Authors { get; set; }

        public DbSet<Faragau_Cristina_Lab_02.Models.Category> Category { get; set; }

        public DbSet<Faragau_Cristina_Lab_02.Models.Member> Member { get; set; }

        public DbSet<Faragau_Cristina_Lab_02.Models.Borrowing> Borrowing { get; set; }
    }
}
