using MOZ.StoreManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MOZ.StoreManagement.Web.Pages;

public abstract class StoreManagementPageModel : AbpPageModel
{
    protected StoreManagementPageModel()
    {
        LocalizationResourceType = typeof(StoreManagementResource);
    }
}
