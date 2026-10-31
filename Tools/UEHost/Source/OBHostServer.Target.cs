using UnrealBuildTool;

public class OBHostServerTarget : TargetRules
{
	public OBHostServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("OBHost");
	}
}
