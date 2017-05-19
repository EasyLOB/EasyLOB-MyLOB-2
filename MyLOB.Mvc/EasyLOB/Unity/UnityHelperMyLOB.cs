using MyLOB;
using MyLOB.Application;
using MyLOB.Persistence;
using Microsoft.Practices.Unity;

namespace EasyLOB
{
    public static class UnityHelperMyLOB
    {
        public static void RegisterMappings(IUnityContainer container)
        {
            container.RegisterType(typeof(IMyLOBApplication), typeof(MyLOBApplication), UnityHelper.AppLifetimeManager);

            // EasyLOBGenerator //container.RegisterType(typeof(IMyLOBGenericApplication<>), typeof(MyLOBGenericApplication<>), UnityHelper.AppLifetimeManager);
            // EasyLOBGenerator //container.RegisterType(typeof(IMyLOBGenericApplicationDTO<,>), typeof(MyLOBGenericApplicationDTO<,>), UnityHelper.AppLifetimeManager);

            // Entity Framework
            // EasyLOBGenerator //container.RegisterType(typeof(IMyLOBUnitOfWork), typeof(MyLOBUnitOfWorkEF), UnityHelper.AppLifetimeManager);
            // EasyLOBGenerator //container.RegisterType(typeof(IMyLOBGenericRepository<>), typeof(MyLOBGenericRepositoryEF<>), UnityHelper.AppLifetimeManager);
        }
    }
}