//
// ReLogBp.h
//
//  Generated on January 27 2020
//  Template created by Peter Gusev on 27 January 2020.
//  Copyright 2013-2020 Regents of the University of California
//


#pragma once

#include "CoreMinimal.h"
#include "Modules/ModuleManager.h"

class FEditorToolsBlueprintModule : public IModuleInterface
{
public:

	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};
