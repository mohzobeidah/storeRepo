﻿using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using MOZ.StoreManagement.Localization;

namespace MOZ.StoreManagement.Web;

[Dependency(ReplaceServices = true)]
public class StoreManagementBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<StoreManagementResource> _localizer;

    public StoreManagementBrandingProvider(IStringLocalizer<StoreManagementResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
