using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Model;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IContract
    {
        #region Categories
        [OperationContract]
        List<Category> GetAllCategories();

        [OperationContract]
        List<Category> GetAllCategoryVisible();

        [OperationContract]
        Category GetCategoryById(int id);

        [OperationContract]
        List<KeyValuePair<int,int>> GetCategoryCount(bool requireOffer);

        [OperationContract]
        void UpdateCategory(Category category);

        [OperationContract]
        void AddCategory(Category category);
        
        [OperationContract]
        void DeleteCategory(int id);
        #endregion

        #region products

        [OperationContract]
        List<Product> GetAllProducts();

        [OperationContract]
        List<Product> GetAllProductVisible();


        [OperationContract]
        Product GetProductById(int id);


        [OperationContract]
        List<Product> GetProductByCategory(int id, bool requireOffer);


        [OperationContract]
        List<Product> GetProductByName(string name);

        [OperationContract]
        List<Product> GetProductBywithOffer();

        [OperationContract]
        void UpdateProduct(Product Product);

        [OperationContract]
        int AddProduct(Product Product);

        [OperationContract]
        void DeleteProduct(int id);

        [OperationContract]
        List<Product> GetProductLastOffers(int? count);

        [OperationContract]
        List<Product> GetProductLastAdded(int count);

        #endregion

        #region Orders

        [OperationContract]
        List<Order> GetAllOrders();

        [OperationContract]
        List<Order> GetAllOrderByState(int id);

        [OperationContract]
        void UpdateOrder(Order Order);

        [OperationContract]
        Order GetOrderById(int id);

        [OperationContract]
        List<Order> GetOrderByDate(DateTime OrdenDate);

        [OperationContract]
        List<Order> GetOrderByDateDone(DateTime OrdenDate);

        [OperationContract]
        void PlaceOrder(Order Order, List<OrderProduct> products);


        #endregion

        #region Banner
        [OperationContract]
        List<Banner> GetAllBanner();

        [OperationContract]
        Banner GetBannerById(int id);

        [OperationContract]
        void UpdateBanner(Banner banner);

        [OperationContract]
        void AddBanner(Banner banner);

        [OperationContract]
        void DeleteBanner(int id);
        #endregion

        #region Image

        [OperationContract]
        List<Image> GetImageByProductId(int id);

        [OperationContract]
        Image GetImageById(int id);


        [OperationContract]
        void DeleteImage(int id);

        [OperationContract]
        void AddImageRange(List<Image> image);


        #endregion

        #region Feature
        [OperationContract]
        List<Feature> GetFeatureByProductId(int id);
        #endregion

    }


}
