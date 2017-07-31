using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IService
    {
        #region Categories
         
        List<Category> GetAllCategories();

         
        List<Category> GetAllCategoryVisible();

         
        Category GetCategoryById(int id);


        IDictionary<int, int> GetCategoryCount(bool requireOffer);

         
        void UpdateCategory(Category category);

         
        void AddCategory(Category category);

         
        void DeleteCategory(int id);
        #endregion

        #region products

         
        List<Product> GetAllProducts();

         
        List<Product> GetAllProductVisible();


         
        Product GetProductById(int id);


         
        List<Product> GetProductByCategory(int id, bool requireOffer);


         
        List<Product> GetProductByName(string name);

         
         
        void UpdateProduct(Product Product);

         
        int AddProduct(Product Product);

         
        void DeleteProduct(int id);

         
        List<Product> GetProductLastOffers(int? count);

         
        List<Product> GetProductLastAdded(int count);

        #endregion

        #region Orders

         
        List<Order> GetAllOrders();

         
        List<Order> GetAllOrderByState(int id);

         
        void UpdateOrder(Order Order);

         
        Order GetOrderById(int id);

         
        List<Order> GetOrderByDate(DateTime OrdenDate);

         
        List<Order> GetOrderByDateDone(DateTime OrdenDate);

         
        void PlaceOrder(Order Order, List<OrderProduct> products);


        #endregion

        #region Banner
         
        List<Banner> GetAllBanner();

         
        Banner GetBannerById(int id);

         
        void UpdateBanner(Banner banner);

         
        void AddBanner(Banner banner);

         
        void DeleteBanner(int id);
        #endregion

        #region Image

         
        List<Image> GetImageByProductId(int id);

         
        Image GetImageById(int id);


         
        void DeleteImage(int id);

         
        void AddImageRange(List<Image> image);


        #endregion

        #region Feature
         
        List<Feature> GetFeatureByProductId(int id);
        #endregion
    }
}
