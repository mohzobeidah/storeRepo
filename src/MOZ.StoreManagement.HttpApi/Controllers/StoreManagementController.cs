using MOZ.StoreManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MOZ.StoreManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StoreManagementController : AbpControllerBase
{
    protected StoreManagementController()
    {
        LocalizationResource = typeof(StoreManagementResource);
    }
}
