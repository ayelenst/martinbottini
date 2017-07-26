using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class FeatureRepository
    {
        private EcommerceContext db = new EcommerceContext();
        public void Add(Feature feature)
        {
           db.Feature.Add(feature);
                db.SaveChanges();
        }

        public void AddRange(List<Feature> feature)
        {
           foreach (var f in feature)
                {
                    db.Feature.Add(f);
            }
            db.SaveChanges();

        }

        public void Update(Feature feature)
        {
           var img = db.Feature.First(x => x.Id == feature.Id);
                db.Entry(img).CurrentValues.SetValues(feature);
                db.SaveChanges();
        }


        public void UpdateRange(List<Feature> features)
        {
            foreach (var feature in features)
                {
                    var img = db.Image.Where(x => x.Id == feature.Id);
                    db.Entry(img).CurrentValues.SetValues(feature);
                }
                db.SaveChanges();
        }

        public void Delete(int id)
        {
            var img = db.Feature.First(x => x.Id == id);
                db.Feature.Remove(img);
                db.SaveChanges();
        }

        public void DeleteRangeByProductId(int id)
        {
           var img = db.Feature.Where(x => x.Id == id);
                db.Feature.RemoveRange(img);
                db.SaveChanges();
        }

        public void DeleteRange(List<Feature> features)
        {
            db.Feature.RemoveRange(features);
                db.SaveChanges();
        }
        public List<Feature> GetByProductId(int id)
        {
            var query = db.Feature.Where(x => x.ProductID == id);
                return query.ToList();
        }



    }


}
