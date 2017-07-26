using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IFeatureRepository : IRepository<Feature>
    {
        void AddRange(List<Feature> feature);

        void UpdateRange(List<Feature> features);

        void DeleteRangeByProductId(int id);

        void DeleteRange(List<Feature> features);
    }
}
