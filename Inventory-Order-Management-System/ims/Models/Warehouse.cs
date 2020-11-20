using System.ComponentModel.DataAnnotations;

namespace ims.Models
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }
        [Required]
        public string WarehouseName { get; set; }
        public string Description { get; set; }
        [Display(Name = "Branch")]
        public int BranchId { get; set; }
    }
}
