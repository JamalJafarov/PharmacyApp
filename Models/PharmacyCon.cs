using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp.Models
{
    public class PharmacyCon:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-5A83I97;Initial Catalog=Pharmacy;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public DbSet<Firm> Firms { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<MedicineToCategory> MedicineToCategories { get; set; }
        public DbSet<MedicineToFirm> MedicineToFirms { get; set; }
    }
}
