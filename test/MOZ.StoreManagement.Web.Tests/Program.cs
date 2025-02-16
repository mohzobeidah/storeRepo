using Microsoft.AspNetCore.Builder;
using MOZ.StoreManagement;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("MOZ.StoreManagement.Web.csproj"); 
await builder.RunAbpModuleAsync<StoreManagementWebTestModule>(applicationName: "MOZ.StoreManagement.Web");

public partial class Program
{
}
