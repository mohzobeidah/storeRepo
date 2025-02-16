using MOZ.StoreManagement.Samples;
using Xunit;

namespace MOZ.StoreManagement.EntityFrameworkCore.Domains;

[Collection(StoreManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<StoreManagementEntityFrameworkCoreTestModule>
{

}
