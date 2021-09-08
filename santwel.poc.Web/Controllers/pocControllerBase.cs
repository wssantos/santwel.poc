using Abp.Web.Mvc.Controllers;

namespace santwel.poc.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class pocControllerBase : AbpController
    {
        protected pocControllerBase()
        {
            LocalizationSourceName = pocConsts.LocalizationSourceName;
        }
    }
}