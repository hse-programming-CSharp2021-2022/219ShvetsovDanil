using System.ComponentModel.DataAnnotations;

namespace Task_01.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public decimal Price { get; set; }
    }
}