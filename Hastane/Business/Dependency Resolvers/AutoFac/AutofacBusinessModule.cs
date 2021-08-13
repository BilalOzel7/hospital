using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstracts;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dependency_Resolvers.AutoFac
{
   public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DoktorManager>().As<IDoktorService>().SingleInstance();
            builder.RegisterType<TibbiBirimManager>().As<ITibbiBirimService>().SingleInstance();

            builder.RegisterType<EfDoktorDal>().As<IDoktorDal>().SingleInstance();
            builder.RegisterType<EfTibbiBirimDal>().As<ITibbiBirimDal>().SingleInstance();



            //builder.RegisterType<JwtHelper>().As<ITokenHelper>();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();//çalışan uygulama içinde 

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()//implement edilmiş interface leri bul
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()//bütün sınıflar için bunu çalıştır (selector u)
                }).SingleInstance();
        }
    }
}
