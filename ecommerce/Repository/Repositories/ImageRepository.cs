using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
   public class ImageRepository
    {

        public void Add(Image image)
        {
            using (var db = new EcommerceContext())
            {
                db.Image.Add(image);
                db.SaveChanges();
            }
        }

        public void Update(Image image)
        {
            using (var db = new EcommerceContext())
            {

                var img = db.Image.First(x => x.Id == image.Id);
                db.Entry(img).CurrentValues.SetValues(image);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new EcommerceContext())
            {

                var img = db.Image.First(x => x.Id == id);
                db.Image.Remove(img);
                db.SaveChanges();
            }
        }

    }


}
