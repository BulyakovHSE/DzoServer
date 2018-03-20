using System.ComponentModel.DataAnnotations;

namespace DlrModel
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public Region Region { get; set; }
    }
}
