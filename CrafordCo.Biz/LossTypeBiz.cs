using CrafordCo.Biz.Interfaces;
using CrafordCo.Data.Entities;
using CrafordCo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrafordCo.Biz
{
    public class LossTypeBiz : ILossType
    {
        private readonly ILossTypeRepo _lossTypeRepo;
        public LossTypeBiz(ILossTypeRepo lossTypeRepo)
        {
            _lossTypeRepo = lossTypeRepo;
        }
        public IEnumerable<LossType> GetLossTypes()
        {
            return _lossTypeRepo.GetLossTypes();
        }
    }
}
