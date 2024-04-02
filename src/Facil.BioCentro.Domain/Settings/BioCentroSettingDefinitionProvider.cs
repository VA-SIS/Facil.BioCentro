using Volo.Abp.Settings;

namespace Facil.BioCentro.Settings;

public class BioCentroSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BioCentroSettings.MySetting1));
    }
}
