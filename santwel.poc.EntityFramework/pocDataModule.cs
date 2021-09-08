using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using santwel.poc.EntityFramework;

namespace santwel.poc
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(pocCoreModule))]
    public class pocDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<pocDbContext>(null);
        }
    }
}
