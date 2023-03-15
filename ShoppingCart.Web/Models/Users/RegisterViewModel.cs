namespace ShoppingCart.Web.Models.Users
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterViewModel
    {
        public RegisterViewModel()
        {

        }

        [Required]
        [StringLength(25, ErrorMessage = "First Name length can't be more than 25.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Last Name length can't be more than 25.")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "test")]
        [Required]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Street length can't be more than 50.")]
        public string Street { get; set; }


        [Required]
        [StringLength(30, ErrorMessage = "City length can't be more than 30.")]
        public string City { get; set; }


        [Required]
        [StringLength(20, ErrorMessage = "House Number length can't be more than 20.")]
        public string HouseNumber { get; set; }

        [Required]
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,}",
            ErrorMessage = "Password must be minimum 8 characters. Contain at least one letter and one number")]
        public string Password { get; set; }
    }
}
