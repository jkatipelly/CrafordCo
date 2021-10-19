using System.ComponentModel.DataAnnotations;

namespace CrafordCo.App.Models
{
    public class UserViewModel
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }

    }
}
