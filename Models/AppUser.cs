using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GroupProject_V2.Models
{
    public class AppUser : IdentityUser
    {
        //AppUser properties

        [Required]
        [DataType(DataType.Text), StringLength(30)]
        [Display(Name = "Ryan Name")]
        public string? FirstName { get; set; }
        [Required]
        [DataType(DataType.Text), StringLength(50)]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; }

        [Display(Name = "Suspension Status")]
        public bool IsSuspended { get; set; }

        [Display(Name = "Number of Warnings")]
        public int Warnings { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Registered On")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Joined { get; set; }

        //navigational properties

        public ICollection<Post>? Posts { get; set; }

        public ICollection<Comment>? Comments { get; set; }

        public ICollection<Likes>? Likes { get; set; }
    }
}
