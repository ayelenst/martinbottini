using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication
{
    public class UnityDependencyResolver : IDependencyResolver
    {
        readonly IUnityContainer _container;

        public UnityDependencyResolver(IUnityContainer container)
        {
            this._container = container;
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return this._container.IsRegistered(serviceType) ? _container.Resolve(serviceType) : null;
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return this._container.IsRegistered(serviceType) ? _container.ResolveAll(serviceType) : new List<object>();
            }
            catch
            {
                return new List<object>();
            }
        }
    }
}