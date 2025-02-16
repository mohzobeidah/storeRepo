using Volo.Abp.Modularity;

namespace MOZ.StoreManagement;

[DependsOn(
    typeof(StoreManagementApplicationModule),
    typeof(StoreManagementDomainTestModule)
)]
public class StoreManagementApplicationTestModule : AbpModule
{

}
