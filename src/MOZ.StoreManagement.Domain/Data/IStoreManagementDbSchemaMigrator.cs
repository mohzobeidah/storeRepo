using System.Threading.Tasks;

namespace MOZ.StoreManagement.Data;

public interface IStoreManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
