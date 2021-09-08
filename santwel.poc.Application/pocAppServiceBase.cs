using Abp.Application.Services;

namespace santwel.poc
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class pocAppServiceBase : ApplicationService
    {
        protected pocAppServiceBase()
        {
            LocalizationSourceName = pocConsts.LocalizationSourceName;
        }
    }
}