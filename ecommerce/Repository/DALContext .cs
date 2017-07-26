using Model;
using Repository.Interfaces;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DALContext : IDALContext
    {
        private EcommerceContext dbContext;
        private ICategoryRepository categoryRepository;
        private IProductRepository productRepository;
        private IBannerRepository bannerRepository;
        private IFeatureRepository featureRepository;
        private IImageRepository imageRepository;
        private IOrderRepository orderRepository;


      

        public DALContext()
        {
            dbContext = new EcommerceContext();
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (categoryRepository == null)
                    categoryRepository = new CategoryRepository(dbContext);
                return categoryRepository;
            }
        }
        public IProductRepository ProductRepository
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(dbContext);
                return productRepository;
            }
        }
        


        public IBannerRepository BannerRepository
        {
            get
            {
                if (bannerRepository == null)
                    bannerRepository = new BannerRepository(dbContext);
                return bannerRepository;
            }
        }
        public IFeatureRepository FeatureRepository
        {
            get
            {
                if (featureRepository == null)
                    featureRepository = new FeatureRepository(dbContext);
                return featureRepository;
            }
        }
        public IImageRepository ImageRepository
        {
            get
            {
                if (imageRepository == null)
                    imageRepository = new ImageRepository(dbContext);
                return imageRepository;
            }
        }
        public IOrderRepository OrderRepository
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(dbContext);
                return orderRepository;
            }
        }


      

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (categoryRepository != null)
                categoryRepository.Dispose();

            if (productRepository != null)
                productRepository.Dispose();

            if (bannerRepository != null)
                bannerRepository.Dispose();
            if (featureRepository != null)
                featureRepository.Dispose();
            if (imageRepository != null)
                imageRepository.Dispose();
            if (orderRepository != null)
                orderRepository.Dispose();
            if (dbContext != null)
                dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}