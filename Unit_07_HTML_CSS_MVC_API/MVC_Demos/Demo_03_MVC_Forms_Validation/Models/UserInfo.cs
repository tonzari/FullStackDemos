using System.ComponentModel.DataAnnotations;

namespace Demo_03_MVC_Forms_Validation.Models
{
    /*
     * Validation in ASP.NET with "Validation Attributes"
     * 
     * Some examples:
     * 
     * EmailAddress
     * Phone
     * Range
     * RegularExpression
     * StringLength
     *
     * These attributes will be added above the property, and inside square brackets: [TheValidationType]
     * 
     * Example: [StringLength(100)] 
     *          public string Message { get; set; }
     *
     * Model Binding will make use of these attributes. Validation will fail if the requirements are not met.
     * 
     */

    // Microsoft Data Annotations: https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-6.0
    // Microsoft validation docs: https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/adding-validation


    public class UserInfo
    {
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter a valid password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(16)]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of birth: ")]
        [Required(ErrorMessage = "Please enter a valid date.")]
        public DateTime Birthday { get; set; }
    }
}
