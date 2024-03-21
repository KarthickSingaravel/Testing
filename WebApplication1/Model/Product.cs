using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class Product
    {
      
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Prize { get; set; }

        public int CategoryName { get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

    }
}
