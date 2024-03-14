using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SnackStore.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CatogoryId { get; set; }

        [StringLength(100,ErrorMessage = "The max length of Name field is 100 characters.")]
        [Required(ErrorMessage ="Category Name can't be null.")]
        [Display(Name = "Name")]
        public string CategoryName { get; set; }

        [StringLength(200, ErrorMessage = "The max length of Description field is 100 characters.")]
        [Required(ErrorMessage = "Category Description field can't be null.")]
        [Display(Name = "Description")]
        public string CategoryDescription { get; set; }

        public List<Snack> Snacks { get; set; }
    }
}
