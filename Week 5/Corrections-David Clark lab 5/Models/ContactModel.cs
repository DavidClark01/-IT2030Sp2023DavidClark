using System.ComponentModel.DataAnnotations;

//namespace David_s_Extreme_Gear.Views.Contact
namespace David_s_Extreme_Gear.Models
{
    public class ContactModel
    {
        //internal dynamic ContactModel()
        //{
        //    throw new NotImplementedException();
        //}

        //this is the code you should have here
        [Required(ErrorMessage = "Please enter a first name.")]
        public string? FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a last name.")]
        public string? LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an address.")]
        public string? Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string? Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an email.")]
        public string? Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a message.")]
        public string? Message { get; set; } = string.Empty;
    }
}