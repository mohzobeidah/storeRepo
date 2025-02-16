using MOZ.StoreManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace MOZ.StoreManagement.Permissions;

public class StoreManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StoreManagementPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(StoreManagementPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(StoreManagementPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(StoreManagementPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(StoreManagementPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(StoreManagementPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StoreManagementResource>(name);
    }
}
