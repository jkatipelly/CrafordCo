using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrafordCo.Data.Entities
{
    public class LossType
    {
        [Key]
        public int LossTypeID { get; set; }

        [MaxLength(2)]
        public string LossTypeCode { get; set; }

        [MaxLength(25)]
        public string LossTypeDescription { get; set; }
    }
}
