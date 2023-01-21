using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [MaxLength(300)]
        public string? Description { get; set; }
        public bool? IsReceipt { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cost { get; set; }   
        public DateTime? ProductionDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int Count { get; set; }
        public virtual List<MedicineToCategory> MedicineToCategories { get; set; }  
        public virtual List<MedicineToFirm> MedicineToFirms { get;set; }



    }
}
