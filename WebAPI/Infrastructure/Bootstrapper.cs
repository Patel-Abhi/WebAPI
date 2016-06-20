using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using WebAPI.Services.ServiceDefinition;
using WebAPI.Services.ServiceInterface;
using Unity.WebApi;

namespace WebAPI.Infrastructure
{
    public static class Bootstrapper
    {
        public static IServiceLocator Locator;
        public static void Initialise()
        {
            var container = BuildUnityContainer();
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
            Locator = new UnityServiceLocator(container);
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IUserService, UserService>();
            //container.RegisterType<IProductService, ProductService>();
            return container;
        }

        //public static IUnityContainer Initialise()
        //{
        //    var container = BuildUnityContainer();
        //    DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        //    return container;
        //}

        //private static IUnityContainer BuildUnityContainer()
        //{
        //    var container = new UnityContainer();
        //    RegisterTypes(container);            
        //    return container;
        //}

        //public static void RegisterTypes(IUnityContainer container)
        //{
        //    container.RegisterType<IUserService, UserService>();
        //}            
    }
}