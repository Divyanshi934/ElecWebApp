using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ElecWebApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(100)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Range should be b/w 1-100")]
        public int DisplayOrder { get; set; }
    }
}
