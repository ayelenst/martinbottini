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
        Product GetProductByCategory(int id);


        [OperationContract]
        Product GetProductByName(string name);

        [OperationContract]
        Product GetProductBywithOffer();

        [OperationContract]
        void UpdateProduct(Product Product);

        [OperationContract]
        void AddProduct(Product Product);

#endregion
    }


}
