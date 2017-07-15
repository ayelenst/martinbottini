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
        void UpdateCategory(Category category);

        [OperationContract]
        void AddCategory(Category category);
        
        [OperationContract]
        void DeleteCategory(Category category);
        #endregion

        #region products

        [OperationContract]
        List<Product> GetAllProducts();

        [OperationContract]
        List<Product> GetAllProductVisible();


        [OperationContract]
        Product GetProductById(int id);


        [OperationContract]
        List<Product> GetProductByCategory(int id);


        [OperationContract]
        List<Product> GetProductByName(string name);

        [OperationContract]
        List<Product> GetProductBywithOffer();

        [OperationContract]
        void UpdateProduct(Product Product);

        [OperationContract]
        void AddProduct(Product Product);

        [OperationContract]
        void DeleteProduct(int id);

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
    }


}
