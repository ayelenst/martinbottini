using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IDALContext : IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
        IBannerRepository BannerRepository { get; }
        IFeatureRepository FeatureRepository { get; }
        IImageRepository ImageRepository { get; }
        IOrderRepository OrderRepository { get; }
    }
}
