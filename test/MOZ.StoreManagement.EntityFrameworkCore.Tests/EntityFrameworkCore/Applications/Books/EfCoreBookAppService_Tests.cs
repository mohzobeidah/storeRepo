using MOZ.StoreManagement.Books;
using Xunit;

namespace MOZ.StoreManagement.EntityFrameworkCore.Applications.Books;

[Collection(StoreManagementTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<StoreManagementEntityFrameworkCoreTestModule>
{

}