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

        [OperationContract]
        List<Category> GetAllCategories();

        [OperationContract]
        Category GetCategoryById(int id);

        [OperationContract]
        void UpdateCategory(Category category);

        [OperationContract]
        void AddCategory(Category category);
        
    }

    
}
