using Abp.Web.Mvc.Views;

namespace santwel.poc.Web.Views
{
    public abstract class pocWebViewPageBase : pocWebViewPageBase<dynamic>
    {

    }

    public abstract class pocWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected pocWebViewPageBase()
        {
            LocalizationSourceName = pocConsts.LocalizationSourceName;
        }
    }
}