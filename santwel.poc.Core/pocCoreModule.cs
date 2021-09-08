using System.Reflection;
using Abp.Modules;

namespace santwel.poc
{
    public class pocCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = pocConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
