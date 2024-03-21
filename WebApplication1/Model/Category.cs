using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
