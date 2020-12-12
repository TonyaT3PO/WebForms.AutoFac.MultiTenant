using System.ComponentModel.DataAnnotations;

namespace WebForms.AutoFac.MultiTenant.Data.Models.Tenants
{
    public class Customer
    {
        [Key]
        public int Id { get; set; } 
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(150)]
        public string ClientUrl { get; set; }
        [StringLength(150)]
        public string Provider { get; set; } 

        
    }
}