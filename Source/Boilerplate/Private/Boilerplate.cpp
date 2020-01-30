//
// <#Module Name#>.cpp
//
//  Generated on <#generation date#>
//  Template created by Peter Gusev on 27 January 2020.
//  Copyright 2013-2019 Regents of the University of California
//

#include "<#Module Name#>.h"
#include "logging.hpp"

#define LOCTEXT_NAMESPACE "F<#Module Name#>Module"

void F<#Module Name#>Module::StartupModule()
{
    initLogger(LOCTEXT_NAMESPACE);
    RLOG_PLUGIN_INFO("<#Module Name#> Module startup");

    // To log using ReLog plugin, use these macro definitions:
    // RLOG_PLUGIN_ERROR("Error message");
    // RLOG_PLUGIN_WARN("Warning message");
    // RLOG_PLUGIN_INFO("Info message");
    // RLOG_PLUGIN_DEBUG("Debug message");
    // RLOG_PLUGIN_TRACE("Trace message");

    // This code will execute after your module is loaded into memory; the exact timing is specified in the .uplugin file per-module
}

void F<#Module Name#>Module::ShutdownModule()
{
    RLOG_PLUGIN_INFO("<#Module Name#> Module shutdown");
	// This function may be called during shutdown to clean up your module.  For modules that support dynamic reloading,
	// we call this function before unloading the module.
}

#undef LOCTEXT_NAMESPACE

IMPLEMENT_MODULE(F<#Module Name#>Module, <#Module Name#>)
