using System.Reflection;
using Abp.Modules;

namespace santwel.poc
{
    [DependsOn(typeof(pocCoreModule))]
    public class pocApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
