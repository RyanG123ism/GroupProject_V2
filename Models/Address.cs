using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupProject_V2.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        [DataType(DataType.Text)]
        public string FirstLine { get; set; }

        [Display(Name = "Address Line 2")]
        [DataType(DataType.Text)]
        public string SecondLine { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Required]
        [Display(Name = "Post Code")]
        [DataType(DataType.PostalCode)]
        public string PostCode { get; set; }

        //navigational properties


        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
