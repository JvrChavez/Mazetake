using UnrealBuildTool;

public class MazetakeTarget : TargetRules
{
	public MazetakeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Mazetake");
	}
}
