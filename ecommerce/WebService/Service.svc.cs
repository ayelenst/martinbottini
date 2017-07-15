using Model;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{

    public class Service : IContract
    {
        #region Categorias 

        public List<Category> GetAllCategories()
        {
            var repo = new CategoryRepository();
            return repo.GetAll();

        }


        public Category GetCategoryById(int id)
        {
            var repo = new CategoryRepository();
            return repo.GetById(id);
        }

        public List<Category> GetAllCategoryVisible()
        {
            var repo = new CategoryRepository();
            return repo.GetAllVisible();
        }


        public void AddCategory(Category category)
        {
            var repo = new CategoryRepository();
            repo.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var repo = new CategoryRepository();
            repo.Update(category);
        }

        public void DeleteCategory(Category category)
        {
            var repo = new CategoryRepository();
            repo.Delete(category);
        }
        #endregion

        #region  Productos

        public List<Product> GetAllProducts()
        {
            var repo = new ProductRepository();
            return repo.GetAll();

        }

        public List<Product> GetProductBywithOffer()
        {
            var repo = new ProductRepository();
            return repo.GetWithOffer();

        }

        public Product GetProductById(int id)
        {
            var repo = new ProductRepository();
            return repo.GetById(id);
        }

        public List<Product> GetProductByCategory(int id)
        {
            var repo = new ProductRepository();
            return repo.GetByCategory(id);
        }

        public List<Product> GetProductByName(string name)
        {
            var repo = new ProductRepository();
            return repo.GetByName(name);
        }


        public List<Product> GetAllProductVisible()
        {
            var repo = new ProductRepository();
            return repo.GetAllVisible();
        }


        public void AddProduct(Product Product)
        {
            var repo = new ProductRepository();
            repo.Add(Product);
        }

        public void UpdateProduct(Product Product)
        {
            var repo = new ProductRepository();
            repo.Update(Product);
        }

        public void DeleteProduct(int id)
        {
            var repo = new ProductRepository();
            repo.Delete(id);
        }
        #endregion

        #region Order

        public List<Order> GetAllOrders()
        {
            var repo = new OrderRepository();
            return repo.GetAll();
        }


        public List<Order> GetAllOrderByState(int id)
        {
            var repo = new OrderRepository();
            return repo.GetAll();
        }

        public void UpdateOrder(Order Order)
        {
            var repo = new OrderRepository();
            repo.Update(Order);
        }

        public Order GetOrderById(int id)
        {
            var repo = new OrderRepository();
            return repo.GetById(id);
        }

        public List<Order> GetOrderByDate(DateTime OrderDate )
        {
            var repo = new OrderRepository();
            return repo.GetByDate(OrderDate);
        }

        public List<Order> GetOrderByDateDone(DateTime OrderDate)
        {
            var repo = new OrderRepository();
            return repo.GetByDateDone(OrderDate);
        }

        public void PlaceOrder(Order Order, List<OrderProduct> products)
        {
            var repo = new OrderRepository();
            repo.Place(Order,products);
        }


        #endregion
    }
}

