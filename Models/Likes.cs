using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupProject_V2.Models
{
    public class Likes
    {
        [Key]
        public int LikeId { get; set; }

        //navigational Properties

        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; } // Navigation property to Post table

        [ForeignKey("AppUser")]
        public string UserId { get; set; }
        public AppUser AppUser { get; set; } // Navigation property to User table

    }
}
