//
// EditorTools.Build.cs
//
//  Generated on 24 February 2020.
//  Template created by Peter Gusev on 27 January 2020.
//  Copyright 2013-2019 Regents of the University of California
//

using UnrealBuildTool;

public class EditorTools : ModuleRules
{
	public EditorTools(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);


		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
				"/EditorTools/Private"			}
				);


		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"UMG",
				"DDBase",
				"DDLog"
				// ... add other public dependencies that you statically link with here ...
			}
			);


		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				"depsEditorTools"
				// ... add private dependencies that you statically link with here ...
			}
			);


		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
