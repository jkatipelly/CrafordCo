using CrafordCo.Data.Entities;
using CrafordCo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrafordCo.Data.Repositories
{
    public class LossTypeRepo : ILossTypeRepo
    {

        private readonly CrafordCoContext _context;
        public LossTypeRepo(CrafordCoContext context)
        {
            _context = context;
        }
        public IEnumerable<LossType> GetLossTypes()
        {
            return _context.LossTypes.AsEnumerable();
        }
    }
}
