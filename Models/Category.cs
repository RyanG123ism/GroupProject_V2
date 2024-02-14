using System.ComponentModel.DataAnnotations;

namespace GroupProject_V2.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text), StringLength(25)]
        [Display(Name ="Category Name")]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        //navigational properties
        public List<Post> Posts { get; set; }


    }
}
