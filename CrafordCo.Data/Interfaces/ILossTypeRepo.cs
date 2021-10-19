using CrafordCo.Data.Entities;
using System.Collections.Generic;

namespace CrafordCo.Data.Interfaces
{
    public interface ILossTypeRepo
    {
        public IEnumerable<LossType> GetLossTypes();
    }
}
