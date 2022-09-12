using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Business;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Utilities.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BrandManager>().As<IBaseService<Brand>>().SingleInstance();
            builder.RegisterType<EfBrandDal>().As<IBrandDal> ().SingleInstance();

            builder.RegisterType<CarManager>().As<IBaseService<Car>>().SingleInstance();
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();

            builder.RegisterType<ColorManager>().As<IBaseService<Color>>().SingleInstance();
            builder.RegisterType<EfColorDal>().As<IColorDal>().SingleInstance();

            builder.RegisterType<CustomerManager>().As<IBaseService<Customer>>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<RentalManager>().As<IBaseService<Rental>>().SingleInstance();
            builder.RegisterType<EfRentalDal>().As<IRentalDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IBaseService<User>>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
