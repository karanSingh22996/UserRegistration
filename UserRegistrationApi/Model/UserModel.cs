//-----------------------------------------------------------------------
// <copyright file="UserModel.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace UserRegistrationApi.Model
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// User model is a model class
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the pass.
        /// </summary>
        /// <value>
        /// The pass.
        /// </value>
        [Required]
        public string Pass { get; set; }

        /// <summary>
        /// Gets or sets the mobile no.
        /// </summary>
        /// <value>
        /// The mobile no.
        /// </value>
        [Required]
        public string MobleNo { get; set; }
    }
}
