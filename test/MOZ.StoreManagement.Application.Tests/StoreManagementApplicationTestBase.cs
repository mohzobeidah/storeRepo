using Volo.Abp.Modularity;

namespace MOZ.StoreManagement;

public abstract class StoreManagementApplicationTestBase<TStartupModule> : StoreManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
