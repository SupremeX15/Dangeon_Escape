// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Dangeon_Escape : ModuleRules
{
	public Dangeon_Escape(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Dangeon_Escape",
			"Dangeon_Escape/Variant_Horror",
			"Dangeon_Escape/Variant_Horror/UI",
			"Dangeon_Escape/Variant_Shooter",
			"Dangeon_Escape/Variant_Shooter/AI",
			"Dangeon_Escape/Variant_Shooter/UI",
			"Dangeon_Escape/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
