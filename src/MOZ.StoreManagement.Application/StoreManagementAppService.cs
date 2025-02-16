using MOZ.StoreManagement.Localization;
using Volo.Abp.Application.Services;

namespace MOZ.StoreManagement;

/* Inherit your application services from this class.
 */
public abstract class StoreManagementAppService : ApplicationService
{
    protected StoreManagementAppService()
    {
        LocalizationResource = typeof(StoreManagementResource);
    }
}
