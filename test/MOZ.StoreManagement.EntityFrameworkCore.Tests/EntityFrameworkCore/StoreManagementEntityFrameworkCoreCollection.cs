using Xunit;

namespace MOZ.StoreManagement.EntityFrameworkCore;

[CollectionDefinition(StoreManagementTestConsts.CollectionDefinitionName)]
public class StoreManagementEntityFrameworkCoreCollection : ICollectionFixture<StoreManagementEntityFrameworkCoreFixture>
{

}
