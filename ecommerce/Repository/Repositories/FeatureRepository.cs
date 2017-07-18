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

        public void Update(Feature feature)
        {
            using (var db = new EcommerceContext())
            {

                var img = db.Feature.First(x => x.Id == feature.Id);
                db.Entry(img).CurrentValues.SetValues(feature);
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

    }


}
