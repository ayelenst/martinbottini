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

        public void DeleteCategory(int id)
        {
            var repo = new CategoryRepository();
            repo.Delete(id);
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


        public void AddProduct(Product product)
        {
            var prodrepo = new ProductRepository();
            var imgrepo = new ImageRepository();
            var featrepo = new FeatureRepository();

            prodrepo.Add(product);
            //verficiar q todo tenga el id!
            imgrepo.AddRange(product.Image);
            featrepo.AddRange(product.Feature);

        }

        public void UpdateProduct(Product product)
        {
            var prodrepo = new ProductRepository();
            var imgrepo = new ImageRepository();
            var featrepo = new FeatureRepository();
            var productDB = prodrepo.GetById(product.Id);

            MergeList(product.Image, productDB.Image, imgrepo);
            MergeList(product.Feature, productDB.Feature, featrepo);

           
            var repo = new ProductRepository();
            repo.Update(product);
        }
        private void MergeList(List<Image> listParam, List<Image> listDb, ImageRepository repo)
        {
            var a = listDb.Where(x => listParam.Any(y => (y.Id == x.Id) && (x.Url != y.Url || x.IsMain != y.IsMain))).ToList();
            repo.UpdateRange(a);
            var b = listDb.Where(x => listParam.All(y => y.Id == x.Id)).ToList();
            repo.DeleteRange(b);
            var c = listDb.Where(x => listDb.All(y => x.Id == y.Id)).ToList();
            repo.AddRange(c);
        }


        private void MergeList(List<Feature> listParam, List<Feature> listDb, FeatureRepository repo)
        {
            var a = listDb.Where(x => listParam.Any(y => (y.Id == x.Id) && (x.Name != y.Name || x.Description != y.Description))).ToList();
            repo.UpdateRange(a);
            var b = listDb.Where(x => listParam.All(y => y.Id == x.Id)).ToList();
            repo.DeleteRange(b);
            var c = listDb.Where(x => listDb.All(y => x.Id == y.Id)).ToList();
            repo.AddRange(c);
        }

        public void DeleteProduct(int id)
        {
            var repo = new ProductRepository();
            var imgrepo = new ImageRepository();
            var featrepo = new FeatureRepository();
            imgrepo.DeleteRangeByProductId(id); //where y el resultado un removerange
            featrepo.DeleteRangeByProductId(id); //where y el resultado un removerange

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

        #region Banner 

        public List<Banner> GetAllBanner()
        {
            var repo = new BannerRepository();
            return repo.GetAll();

        }


        public Banner GetBannerById(int id)
        {
            var repo = new BannerRepository();
            return repo.GetById(id);
        }

        public void AddBanner(Banner banner)
        {
            var repo = new BannerRepository();
            repo.Add(banner);
        }

        public void UpdateBanner(Banner banner)
        {
            var repo = new BannerRepository();
            repo.Update(banner);
        }

        public void DeleteBanner(int id)
        {
            var repo = new BannerRepository();
            repo.Delete(id);
        }
        #endregion


    }
}

