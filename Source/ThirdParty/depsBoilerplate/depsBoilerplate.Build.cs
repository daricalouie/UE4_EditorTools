// Fill out your copyright notice in the Description page of Project Settings.

using System.IO;
using UnrealBuildTool;
using System;
using System.Collections.Generic;

public class deps<#Module Name#> : ModuleRules
{
	public deps<#Module Name#>(ReadOnlyTargetRules Target) : base(Target)
	{
		Type = ModuleType.External;

        SetupThirdPartyLibs();
	}

    // returns full path to current module's folder
    private string ModulePath
    {
        get {
            return ModuleDirectory;
        }
    }

    public string GetLibPath(string libName)
    {
        return Path.Combine(ModulePath, libName);
    }

    public string GetLibIncludePath(string libPath)
    {
        return Path.Combine(libPath, "include");
    }

    public string GetLibBinaryPath(string libPath) {
        string path = Path.Combine(libPath, "lib");

        if (Target.Platform == UnrealTargetPlatform.Mac)
            return Path.Combine(path, "macOS");

        return path;
    }

    public List<string> GetAllLibBinaries (string libBinaryPath) {
       string [] bins = Directory.GetFiles(libBinaryPath, "lib*.dylib");
       List<string> binaries = new List<string>();

       foreach (var s in bins)
        binaries.Add(Path.GetFileName(s));

       return binaries;
    }


    public void SetupThirdPartyLibs()
    {
        // here, we set paths and linkage to any thirdparty libraries our plugin uses

        // discover dependencies automatically
        foreach (var path in Directory.GetDirectories(ModulePath, "*"))
        {
            string libName = Path.GetFileName(path.TrimEnd(Path.DirectorySeparatorChar));
            SetupThirdParty(libName);
        }

        //bool isDebug = (Target.Configuration == UnrealTargetConfiguration.Debug && BuildConfiguration.bDebugBuildsActuallyUseDebugCRT);

        // additional flags
        //Definitions.Add("DO_CHECK=0");
        //Definitions.Add("_CRT_SECURE_NO_WARNINGS=1");
        //Definitions.Add("BOOST_DISABLE_ABI_HEADERS=1");
        bUseRTTI = true;
        bEnableExceptions = true;
    }

    private void SetupThirdParty(string libName)
    {
        // set up include paths for dependencies
        //System.Console.WriteLine("Adding include path for {0}: {1}", libName, GetLibIncludePath(GetLibPath(libName)));
        PublicIncludePaths.Add(GetLibIncludePath(GetLibPath(libName)));

        if (!IsHeaderOnlyLibrary(libName))
        {
            // set up linkage
            // if our thirdparty libraries have any prebuilt binaries, add them now
            // to PublicDelayLoadDLLs and RuntimeDependencies
            if (Target.Platform == UnrealTargetPlatform.Win64)
            {

            }
            else if (Target.Platform == UnrealTargetPlatform.Android)
            {
                // set up Android lib paths
            }
            else if (Target.Platform == UnrealTargetPlatform.IOS)
            {
                // set up iOS lib paths
            }
            else if (Target.Platform == UnrealTargetPlatform.Mac)
            {
                string binPath = GetLibBinaryPath(libName);
                List<string> binaries = GetAllLibBinaries(GetLibBinaryPath(libName));

                foreach (var b in binaries)
                {
                    //System.Console.WriteLine("Adding linking {0}: {1}", libName, Path.Combine(binPath, b));
                    PublicDelayLoadDLLs.Add(Path.Combine(binPath, b));
                    RuntimeDependencies.Add(Path.Combine(binPath, b));
                }
            }
        }
    }

    private bool IsHeaderOnlyLibrary(string libName)
    {
        return !Directory.Exists(GetLibBinaryPath(libName));
    }
}
