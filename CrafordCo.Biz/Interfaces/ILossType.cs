using CrafordCo.Data.Entities;
using System.Collections.Generic;

namespace CrafordCo.Biz.Interfaces
{
    public interface ILossType
    {
        public IEnumerable<LossType> GetLossTypes();
        
    }
}
