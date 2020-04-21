// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"

#include "EditorToolsBlueprintLibrary.generated.h"

/**
 *
 */
UCLASS()
class EDITORTOOLSBLUEPRINT_API UEditorToolsBlueprintLibrary : public UBlueprintFunctionLibrary
{
public:
    UFUNCTION(BlueprintCallable, Category = "EditorTools")
        static void setVisibilityByTag(FString tag, bool vis);

	GENERATED_BODY()

};
