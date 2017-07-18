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


        public void AddRange(List<Image> image)
        {
            using (var db = new EcommerceContext())
            {
                db.Image.AddRange(image);
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

        public void UpdateRange(List<Image> images)
        {
            using (var db = new EcommerceContext())
            {
                foreach (var image in images) {
                    var img = db.Image.Where(x => x.Id == image.Id);
                    db.Entry(img).CurrentValues.SetValues(image);
                }
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

        public void DeleteRangeByProductId(int id)
        {
            using (var db = new EcommerceContext())
            {

                var img = db.Image.Where(x => x.Id == id);
                db.Image.RemoveRange(img);
                db.SaveChanges();
            }
        }

        public void DeleteRange(List<Image> images)
        {
            using (var db = new EcommerceContext())
            {
                
                db.Image.RemoveRange(images);
                db.SaveChanges();
            }
        }

    }


}
