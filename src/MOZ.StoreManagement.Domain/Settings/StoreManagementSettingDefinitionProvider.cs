﻿using Volo.Abp.Settings;

namespace MOZ.StoreManagement.Settings;

public class StoreManagementSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(StoreManagementSettings.MySetting1));
    }
}
