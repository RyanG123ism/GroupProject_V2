using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupProject_V2.Models
{
    public class Comment
    {

        [Key]
        public int CommentId { get; set; }

        [Display(Name = "Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CommentDate { get; set; }

        [Required]
        [DataType(DataType.Text), StringLength(75)]
        public string CommentTitle { get; set; }

        [Required]
        [Display(Name = "Comment:")]
        [DataType(DataType.MultilineText)]
        public string CommentBody { get; set; }

        public bool IsRemoved { get; set; }

        //navigational properties------------------------

        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; }

        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }


    }
}
