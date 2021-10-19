using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrafordCo.Data.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [MaxLength(10)]
        public string UserName { get; set; }

        [MaxLength(20)]
        public string Password { get; set; }

        [MaxLength(50)]
        public string DisplayName { get; set; }

        public bool Active { get; set; }
    }
}
