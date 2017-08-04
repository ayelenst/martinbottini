using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Service : IService, IDisposable
    {
        private DALContext context;

        public Service(IDALContext dal)
        {
            context = (DALContext) dal;
        }

        #region Categorias 

        public List<Category> GetAllCategories()
        {
            return context.CategoryRepository.All().ToList();

        }


        public Category GetCategoryById(int id)
        {
            return context.CategoryRepository.Find(id);
        }

        public List<Category> GetAllCategoryVisible()
        {
            return context.CategoryRepository.Filter(x=>x.Enabled == true).ToList();
        }


        public void AddCategory(Category category)
        {
            context.CategoryRepository.Create(category);
        }

        public void UpdateCategory(Category category)
        {
            context.CategoryRepository.Update(category);
        }

        public void DeleteCategory(int id)
        {
            context.CategoryRepository.Delete(x=>x.Id == id);
        }

        public IDictionary<int, int> GetCategoryCount(bool requireOffer)
        {
            return context.CategoryRepository.GetCategoryCount(requireOffer);
        }
        #endregion

        #region  Productos

        public List<Product> GetAllProducts()
        {
            return context.ProductRepository.All().ToList();

        }


        public Product GetProductById(int id)
        {
            return context.ProductRepository.Find(id);
        }

        public List<Product> GetProductByCategory(int id, bool requireOffer)
        {
            return context.ProductRepository.GetByCategory(id, requireOffer);
        }

        public List<Product> GetProductByName(string name)
        {
            return context.ProductRepository.Filter(x=>x.Name == name).ToList();
        }


        public List<Product> GetAllProductVisible()
        {
            return context.ProductRepository.GetAllVisible();
        }


        public int AddProduct(Product product)
        {
            var features = product.Feature;
            product.Feature = null;
            var id = context.ProductRepository.Create(product);
            foreach (var feat in features)
            {
                feat.ProductID = product.Id;
            }
            context.FeatureRepository.AddRange(features);
            return product.Id;

        }

        public void UpdateProduct(Product product)
        {
            context.ProductRepository.UpdateFull(product);

            context.ImageRepository.AddRange(product.Image);

        }


        private void MergeList(List<Feature> listParam, List<Feature> listDb)
        {
            var a = listDb.Where(x => listParam.Any(y => (y.Id == x.Id) && (x.Name != y.Name || x.Description != y.Description))).ToList();
            context.FeatureRepository.UpdateRange(a);
            var b = listDb.Where(x => listParam.All(y => y.Id != x.Id)).ToList();
            context.FeatureRepository.DeleteRange(b);
            var c = listParam.Where(x => x.Id == 0).ToList();
            context.FeatureRepository.AddRange(c);
        }

        public void DeleteProduct(int id)
        {
            context.ImageRepository.DeleteRangeByProductId(id); //where y el resultado un removerange
            context.FeatureRepository.DeleteRangeByProductId(id); //where y el resultado un removerange

            context.ProductRepository.Delete(x=>x.Id == id);
        }

        public List<Product> GetProductLastOffers(int? count)
        {
            return context.ProductRepository.GetLastOffers(count);
        }

        public List<Product> GetProductLastAdded(int count)
        {
            return context.ProductRepository.GetLastAdded(count);
        }
        #endregion

        #region Order

        public List<Order> GetAllOrders()
        {
            return context.OrderRepository.All().ToList();
        }


        public List<Order> GetAllOrderByState(int id)
        {
        
            return context.OrderRepository.Filter(x=>x.OrderStatusId == id).ToList();
        }

        public void UpdateOrder(Order Order)
        {
            context.OrderRepository.Update(Order);
        }

        public Order GetOrderById(int id)
        {
            return context.OrderRepository.GetOrderWithProducts(id);
        }

        public List<Order> GetOrderByDate(DateTime OrderDate)
        {
            return context.OrderRepository.Filter(x=>x.OrderDate>=OrderDate).ToList();
        }

        public List<Order> GetOrderByDateDone(DateTime OrderDate)
        {
            return context.OrderRepository.Filter(x => x.OrderDone >= OrderDate).ToList();
        }

        public void PlaceOrder(Order Order, List<OrderProduct> products)
        {
            context.OrderRepository.Place(Order, products);
            try
            {
                MailMessage mail = new MailMessage();
                var frommail  = ConfigurationManager.AppSettings["frommail"];
                var tommail = ConfigurationManager.AppSettings["tomail"];
                var frompassword= ConfigurationManager.AppSettings["frompassword"];
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(frommail);
                mail.To.Add(tommail);
                var productList = string.Empty;
                foreach(var product in products)
                {
                    productList = string.Format("{0} <br/> Nombre: {1} ; Cantidad {2} ; Precio {3}", productList, product.NameProduct, product.Quantity, product.Price);
                }

                mail.Subject = string.Format("Order número {3} {0} ha comprado por un total de {1} y método de pago {2}", Order.NameCustomer,Order.Total,Order.Payment, Order.Id);
                mail.Body = string.Format("Datos del comprador: <br/> Nombre: {0} <br/> Telefono: {1} <br/> mail: {2} <br/>" +
                    "<br/>" +
                    "<br/>" +
                    "Datos de la compra: </br> {3}" +
                    "<br/> Total: {4}, Metodo de pago {5}", Order.NameCustomer, Order.Phone, Order.Mail, productList, Order.Total, Order.Payment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(frommail, frompassword);
                SmtpServer.EnableSsl = true;
                mail.IsBodyHtml = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {

            }
        }

        public List<OrderStatus> GetAllOrderStatus()
        {

            return context.OrderStatusRepository.All().ToList();
        }

        public void UpdateOrderStatus(int id, int orderStateId)
        {
            context.OrderRepository.UpdateOrderStatus(id, orderStateId);
        }

        #endregion

        #region Banner 

        public List<Banner> GetAllBanner()
        {
            return context.BannerRepository.All().ToList();

        }


        public Banner GetBannerById(int id)
        {
            return context.BannerRepository.Find(id);
        }

        public void AddBanner(Banner banner)
        {
            context.BannerRepository.Create(banner);
        }

        public void UpdateBanner(Banner banner)
        {
            context.BannerRepository.Update(banner);
        }

        public void DeleteBanner(int id)
        {
            context.BannerRepository.Delete(x=>x.Id == id);
        }
        #endregion

        #region Image

        public List<Image> GetImageByProductId(int id)
        {
            return context.ImageRepository.Filter(x=>x.ProductId == id).ToList();
        }


        public Image GetImageById(int id)
        {
            return context.ImageRepository.Find(id);
        }

        public void DeleteImage(int id)
        {
            
            context.ImageRepository.Delete(x=>x.Id == id);
        }

        public void AddImageRange(List<Image> image)
        {
            
            context.ImageRepository.AddRange(image);
        }

        #endregion

        #region Feature

        public List<Feature> GetFeatureByProductId(int id)
        {
            
            return context.FeatureRepository.Filter(x=>x.ProductID == id).ToList();
        }



        #endregion 

        public void Dispose()
        {
            if (context != null)
                context.Dispose();
        }

        public void GetReports(out Dictionary<string, double> sellsPerMonth, out Dictionary<string, double> productBestCount, out Dictionary<string, double> productBestSell, out Dictionary<string, Dictionary<string, double>> totalSells)
        {

            context.OrderRepository.GetReports(out sellsPerMonth, out productBestCount, out productBestSell, out totalSells);
        }
    }
}
