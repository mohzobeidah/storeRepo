using MOZ.StoreManagement.Samples;
using Xunit;

namespace MOZ.StoreManagement.EntityFrameworkCore.Applications;

[Collection(StoreManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<StoreManagementEntityFrameworkCoreTestModule>
{

}
