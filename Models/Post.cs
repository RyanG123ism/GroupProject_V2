using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GroupProject_V2.Models
{
    public enum PostStatus
    {
        Active,
        Finished,
        Cancelled,
        Postponed,
        SoldOut, 
        Removed
    }

    public class Post
    {

        [Key]
        public int PostId { get; set; }
      
        [Display(Name = "Date Posted:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime PostCreationDate { get; set; }

 
        [Required]
        [Display(Name = "Post Title:")]
        public string PostTitle { get; set; }

  
        [Required]
        [Display(Name = "Post Context:")]
        [DataType(DataType.MultilineText)]
        public string PostBody { get; set; }

        [Display(Name = "Status of Post:")]
        public PostStatus PostStatus { get; set; }


        //navigational properties

        [ForeignKey("AppUser")]
        public string UserId { get; set; }
        public AppUser AppUser { get; set; } //one to one


        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } //one to one


        public List<Comment>? Comments { get; set; } //one to many

        public ICollection<Likes>? Likes { get; set; }   



    }
}
