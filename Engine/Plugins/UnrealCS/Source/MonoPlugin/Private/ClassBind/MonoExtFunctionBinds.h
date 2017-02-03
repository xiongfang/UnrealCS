// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
#include "_UObject.h"
#include "_AActor_Ext.h"
#include "_FWeakObjectPtr.h"
#include "_FName.h"
#include "_FString.h"
#include "_FText.h"
#include "_FScriptArray.h"
#include "_FPaths.h"
#include "_IFileManager.h"
#include "_FMulticastScriptDelegate.h"

#include "_AMonoScriptBind_AIController.h"
#include "_AMonoScriptBind_Character.h"
#include "_AMonoScriptBind_GameMode.h"
#include "_AMonoScriptBind_PlayerController.h"
#include "_UMonoScriptBind_Component.h"
#include "_UInputComponent_Ext.h"

#include "_FVector.h"
#include "_FQuat.h"
#include "_FMatrix.h"
#include "_FRotator.h"
#include "_FTransform.h"

#include "_UWorld_Ext.h"
#include "_UWidgetTree_Ext.h"

#include "_FApp.h"

namespace UnrealEngine
{
	void ExtFunctionBinds()
	{
		_UObject::BindFunctions();
		_UClass_Ext::BindFunctions();
		_FWeakObjectPtr::BindFunctions();
		_AActor_Ext::BindFunctions();
		_FName::BindFunctions();
		_FString::BindFunctions();
		_FScriptArray::BindFunctions();
		_FPaths::BindFunctions();
		_IFileManager::BindFunctions();
		_FText::BindFunctions();
		_FMulticastScriptDelegate::BindFunctions();


		_UMonoScriptBind_Component::BindFunctions();
		_AMonoScriptBind_Character::BindFunctions();
		_AMonoScriptBind_GameMode::BindFunctions();
		_AMonoScriptBind_PlayerController::BindFunctions();
		_AMonoScriptBind_AIController::BindFunctions();
		_UInputComponent_Ext::BindFunctions();

		//ÊýÑ§¿â
		_FVector::BindFunctions();
		_FQuat::BindFunctions();
		_FMatrix::BindFunctions();
		_FRotator::BindFunctions();
		_FTransform::BindFunctions();

		_UWorld_Ext::BindFunctions();
		_UWidgetTree_Ext::BindFunctions();

		_FApp::BindFunctions();
	}

}
