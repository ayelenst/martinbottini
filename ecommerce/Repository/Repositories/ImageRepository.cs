using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
   public class ImageRepository : Repository<Image>, IImageRepository
    {
        public ImageRepository(EcommerceContext context) : base(context) { }

       public void AddRange(List<Image> image)
        {
            using (var db = new EcommerceContext())
            {
                db.Image.AddRange(image);
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
