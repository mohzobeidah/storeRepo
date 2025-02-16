using Volo.Abp.Modularity;

namespace MOZ.StoreManagement;

[DependsOn(
    typeof(StoreManagementDomainModule),
    typeof(StoreManagementTestBaseModule)
)]
public class StoreManagementDomainTestModule : AbpModule
{

}
