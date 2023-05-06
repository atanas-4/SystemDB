using System.ComponentModel.DataAnnotations;

namespace SystemDB.WebApp.Data
{
    public class User
    {
        [EmailAddress]
        [Required]
        public string LoginName { get; set; } = string.Empty;

        [Required]
        public string UserRole { get; set; } = string.Empty;
    }
}
