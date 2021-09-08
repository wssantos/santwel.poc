using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace santwel.poc
{
    [DependsOn(typeof(AbpWebApiModule), typeof(pocApplicationModule))]
    public class pocWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(pocApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
