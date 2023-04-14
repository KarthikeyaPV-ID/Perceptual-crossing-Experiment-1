using UnrealBuildTool;

public class PCExperiment1Target : TargetRules
{
	public PCExperiment1Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("PCExperiment1");
	}
}
