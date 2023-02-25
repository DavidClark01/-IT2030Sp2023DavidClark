using System.ComponentModel.DataAnnotations;

namespace David_s_Extreme_Gear.Views.Shared
{
    public class ContactModel
    {
        
        public decimal? FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter Your First Name here.")]
        [Range(0.1, 10.0, ErrorMessage =
        "Please enter a valid First Name")]
        public decimal? LastName { get; set; }
        [Required(ErrorMessage = "Please enter Your Last Name here")]
        [Range(1, 50, ErrorMessage =
        "Please enter a valid Last Name.")]


        public decimal? Address { get; set; }
        [Required(ErrorMessage = "Please enter an Address here")]
        [Range(0.1, 10.0, ErrorMessage =
        "Please Enter a valid address")]
        public decimal? Phone { get; set; }
        [Required(ErrorMessage = "Please enter your phone number here")]
        [Range(1, 50, ErrorMessage =
        "Please enter a valid Phone Number")]
        public decimal? Email { get; set; }
        [Required(ErrorMessage = "Please enter your Email Here")]
        [Range(0.1, 10.0, ErrorMessage =
        "Please Enter a valid Email.")]
        public decimal? Message { get; set; }
        [Required(ErrorMessage = "enter your message here")]
        [Range(1, 50, ErrorMessage =
        "Please enter a valid message.")]
        public int? Profile
        {
            get; set;
        }
    }
}