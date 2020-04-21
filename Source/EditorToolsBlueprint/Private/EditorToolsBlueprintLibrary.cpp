// Fill out your copyright notice in the Description page of Project Settings.


#include "EditorToolsBlueprintLibrary.h"
#include "Engine/Engine.h"
#include "EngineUtils.h"

using namespace std;

void UEditorToolsBlueprintLibrary::setVisibilityByTag(FString tag, bool vis)
{
    FName tagName = FName(*tag);
    UWorld * w = GEngine->GetWorldContexts()[0].World();

    for (TActorIterator<AActor> ActorIterator(w); ActorIterator; ++ActorIterator) {
        AActor* actor = *ActorIterator;
        FString n = AActor::GetDebugName(actor);

        if (actor->ActorHasTag(tagName)) {
            TArray<USceneComponent*> listComps;
            actor->GetComponents<USceneComponent>(listComps);
            for (auto Itr = listComps.CreateConstIterator(); Itr; ++Itr) {
                USceneComponent* component = *Itr;
                component->SetVisibility(vis,true);
            }
        }
    }
}
