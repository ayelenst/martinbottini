using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IImageRepository : IRepository<Image>    
    {
        void AddRange(List<Image> feature);

        void UpdateRange(List<Image> features);

        void DeleteRangeByProductId(int id);

        void DeleteRange(List<Image> features);
    }
}
