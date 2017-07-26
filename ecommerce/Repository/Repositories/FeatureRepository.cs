using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class FeatureRepository : Repository<Feature>, IFeatureRepository
    {
        public FeatureRepository(EcommerceContext context) : base(context) { }
        public void AddRange(List<Feature> feature)
        {
           foreach (var f in feature)
                {
                Context.Feature.Add(f);
            }
            Context.SaveChanges();

        }

       

        public void UpdateRange(List<Feature> features)
        {
            foreach (var feature in features)
                {
                    var img = Context.Image.Where(x => x.Id == feature.Id);
                Context.Entry(img).CurrentValues.SetValues(feature);
                }
            Context.SaveChanges();
        }

        public void DeleteRangeByProductId(int id)
        {
           var img = Context.Feature.Where(x => x.Id == id);
            Context.Feature.RemoveRange(img);
            Context.SaveChanges();
        }

        public void DeleteRange(List<Feature> features)
        {
            Context.Feature.RemoveRange(features);
            Context.SaveChanges();
        }    



    }


}
