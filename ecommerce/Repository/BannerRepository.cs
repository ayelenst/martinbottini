using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class BannerRepository
    {

        public List<Banner> GetAll()
        {
            using (var db = new EcommerceContext())
            {
                var query = db.Banner.OrderBy(x => x.Id);

                return query.ToList();
            }
        }


        public void Add(Banner banner)
        {
            using (var db = new EcommerceContext())
            {
                db.Banner.Add(banner);
                db.SaveChanges();
            }
        }

        public void Update(Banner banner)
        {
            using (var db = new EcommerceContext())
            {

                var cat = db.Banner.First(x => x.Id == banner.Id);
                db.Entry(cat).CurrentValues.SetValues(banner);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new EcommerceContext())
            {

                var cat = db.Banner.First(x => x.Id == id);
                db.Banner.Remove(cat);
                db.SaveChanges();
            }
        }



    }
}
