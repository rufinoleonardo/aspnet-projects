using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SnackStore.Models
{
    public class Snack
    {
        [Key]
        public int SnackId { get; set; }

        [StringLength(100, MinimumLength = 15 ,ErrorMessage = "The max number of characters is 100." )]
        [Required(ErrorMessage = "Snack Name field can't be null.")]
        [Display(Name = "Name")]
        public string Name { get; set;}

        [StringLength(200, ErrorMessage = "Maximun length of the ShortDescription is 200 characters.", MinimumLength = 20)]
        [Display(Name="Short Description")]
        public string ShortDescription { get; set;}

        [StringLength(400, ErrorMessage = "The max number o characters for the field is 400")]
        [Display(Name="Full Description")]
        public string FullDescription { get; set; }

        [Required(ErrorMessage = "Please provide the price for the snack.")]
        [Column(TypeName = "decimal(10,2)")]
        [Display(Name="Price")]
        [Range(1,999.99, ErrorMessage ="The price must be between R$1,00 and R$999,99")]
        public decimal Price { get; set; }

        [Display(Name="Normal Image.")]
        [StringLength(300)]
        public string ImageUrl { get; set; }

        [Display(Name = "Thumbnail Image.")]
        [StringLength(300)]
        public string ThumbnailUrlImage { get; set; }

        [Display(Name = "Favorite?")]
        public bool IsFavoriteSnack { get; set; }

        [Display(Name = "In Stock?")]
        public bool InStock { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
