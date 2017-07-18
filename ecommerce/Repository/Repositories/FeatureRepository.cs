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

        public void Add(Feature feature)
        {
            using (var db = new EcommerceContext())
            {
                db.Feature.Add(feature);
                db.SaveChanges();
            }
        }

        public void AddRange(List<Feature> feature)
        {
            using (var db = new EcommerceContext())
            {
                foreach (var f in feature)
                {
                    db.Feature.Add(f);
                }

                db.SaveChanges();
            }
        }

        public void Update(Feature feature)
        {
            using (var db = new EcommerceContext())
            {

                var img = db.Feature.First(x => x.Id == feature.Id);
                db.Entry(img).CurrentValues.SetValues(feature);
                db.SaveChanges();
            }
        }


        public void UpdateRange(List<Feature> features)
        {
            using (var db = new EcommerceContext())
            {
                foreach (var feature in features)
                {
                    var img = db.Image.Where(x => x.Id == feature.Id);
                    db.Entry(img).CurrentValues.SetValues(feature);
                }
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new EcommerceContext())
            {

                var img = db.Feature.First(x => x.Id == id);
                db.Feature.Remove(img);
                db.SaveChanges();
            }
        }

        public void DeleteRangeByProductId(int id)
        {
            using (var db = new EcommerceContext())
            {

                var img = db.Feature.Where(x => x.Id == id);
                db.Feature.RemoveRange(img);
                db.SaveChanges();
            }
        }

        public void DeleteRange(List<Feature> features)
        {
            using (var db = new EcommerceContext())
            {

                db.Feature.RemoveRange(features);
                db.SaveChanges();
            }
        }

    }


}
