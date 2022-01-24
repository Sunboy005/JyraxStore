using System.ComponentModel.DataAnnotations;

namespace JyraxStore.Models
{
    public class Category:BaseEntity
    {        

        [Required]
        [Display(Name ="Name")]
        [StringLength(100, ErrorMessage = "Name cannot be empty")]
        [MinLength(3)]
        public string CategoryName { get; set; }


        [StringLength(100, ErrorMessage ="Name cannot be empty")][MinLength(3)]
        [Display(Name = "Description")]
        public string CategoryDescription { get; set; }
    }
}
