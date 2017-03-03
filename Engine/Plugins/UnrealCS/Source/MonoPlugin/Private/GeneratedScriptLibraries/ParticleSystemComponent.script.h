#pragma once

namespace UnrealEngine
{
	class _UParticleSystemComponent
	{
		static void GenerateParticleEvent(UParticleSystemComponent* _this,MonoString* InEventName,float InEmitterTime,FVector* InLocation,FVector* InDirection,FVector* InVelocity)
		{
			FName InEventName_temp=MonoStringToFName(InEventName);
			_this->GenerateParticleEvent(InEventName_temp,InEmitterTime,*InLocation,*InDirection,*InVelocity);
			
		}
		static UMaterialInterface* GetNamedMaterial(UParticleSystemComponent* _this,MonoString* InName)
		{
			FName InName_temp=MonoStringToFName(InName);
			UMaterialInterface* ___ret = _this->GetNamedMaterial(InName_temp);
			return ___ret;
			
		}
		static UMaterialInstanceDynamic* CreateNamedDynamicMaterialInstance(UParticleSystemComponent* _this,MonoString* InName,UMaterialInterface* SourceMaterial)
		{
			FName InName_temp=MonoStringToFName(InName);
			UMaterialInstanceDynamic* ___ret = _this->CreateNamedDynamicMaterialInstance(InName_temp,SourceMaterial);
			return ___ret;
			
		}
		static void SetTrailSourceData(UParticleSystemComponent* _this,MonoString* InFirstSocketName,MonoString* InSecondSocketName,int32 InWidthMode,float InWidth)
		{
			FName InFirstSocketName_temp=MonoStringToFName(InFirstSocketName);
			FName InSecondSocketName_temp=MonoStringToFName(InSecondSocketName);
			_this->SetTrailSourceData(InFirstSocketName_temp,InSecondSocketName_temp,(TEnumAsByte<ETrailWidthMode>)InWidthMode,InWidth);
			
		}
		static void EndTrails(UParticleSystemComponent* _this)
		{
			_this->EndTrails();
			
		}
		static void BeginTrails(UParticleSystemComponent* _this,MonoString* InFirstSocketName,MonoString* InSecondSocketName,int32 InWidthMode,float InWidth)
		{
			FName InFirstSocketName_temp=MonoStringToFName(InFirstSocketName);
			FName InSecondSocketName_temp=MonoStringToFName(InSecondSocketName);
			_this->BeginTrails(InFirstSocketName_temp,InSecondSocketName_temp,(TEnumAsByte<ETrailWidthMode>)InWidthMode,InWidth);
			
		}
		static int32 GetNumActiveParticles(UParticleSystemComponent* _this)
		{
			int32 ___ret = _this->GetNumActiveParticles();
			return ___ret;
			
		}
		static void SetTemplate(UParticleSystemComponent* _this,UParticleSystem* NewTemplate)
		{
			_this->SetTemplate(NewTemplate);
			
		}
		static void SetMaterialParameter(UParticleSystemComponent* _this,MonoString* ParameterName,UMaterialInterface* Param)
		{
			FName ParameterName_temp=MonoStringToFName(ParameterName);
			_this->SetMaterialParameter(ParameterName_temp,Param);
			
		}
		static void SetActorParameter(UParticleSystemComponent* _this,MonoString* ParameterName,AActor* Param)
		{
			FName ParameterName_temp=MonoStringToFName(ParameterName);
			_this->SetActorParameter(ParameterName_temp,Param);
			
		}
		static void SetColorParameter(UParticleSystemComponent* _this,MonoString* ParameterName,FLinearColor* Param)
		{
			FName ParameterName_temp=MonoStringToFName(ParameterName);
			_this->SetColorParameter(ParameterName_temp,*Param);
			
		}
		static void SetVectorParameter(UParticleSystemComponent* _this,MonoString* ParameterName,FVector* Param)
		{
			FName ParameterName_temp=MonoStringToFName(ParameterName);
			_this->SetVectorParameter(ParameterName_temp,*Param);
			
		}
		static void SetFloatParameter(UParticleSystemComponent* _this,MonoString* ParameterName,float Param)
		{
			FName ParameterName_temp=MonoStringToFName(ParameterName);
			_this->SetFloatParameter(ParameterName_temp,Param);
			
		}
		static void SetEmitterEnable(UParticleSystemComponent* _this,MonoString* EmitterName,int32 bNewEnableState)
		{
			FName EmitterName_temp=MonoStringToFName(EmitterName);
			_this->SetEmitterEnable(EmitterName_temp,bNewEnableState>0?true:false);
			
		}
		static int32 GetBeamTargetStrength(UParticleSystemComponent* _this,int32 EmitterIndex,int32 TargetIndex,float* OutTargetStrength)
		{
			bool ___ret = _this->GetBeamTargetStrength(EmitterIndex,TargetIndex,*OutTargetStrength);
			return ___ret?1:0;
			
		}
		static int32 GetBeamTargetTangent(UParticleSystemComponent* _this,int32 EmitterIndex,int32 TargetIndex,FVector* OutTangentPoint)
		{
			bool ___ret = _this->GetBeamTargetTangent(EmitterIndex,TargetIndex,*OutTangentPoint);
			return ___ret?1:0;
			
		}
		static int32 GetBeamTargetPoint(UParticleSystemComponent* _this,int32 EmitterIndex,int32 TargetIndex,FVector* OutTargetPoint)
		{
			bool ___ret = _this->GetBeamTargetPoint(EmitterIndex,TargetIndex,*OutTargetPoint);
			return ___ret?1:0;
			
		}
		static int32 GetBeamSourceStrength(UParticleSystemComponent* _this,int32 EmitterIndex,int32 SourceIndex,float* OutSourceStrength)
		{
			bool ___ret = _this->GetBeamSourceStrength(EmitterIndex,SourceIndex,*OutSourceStrength);
			return ___ret?1:0;
			
		}
		static int32 GetBeamSourceTangent(UParticleSystemComponent* _this,int32 EmitterIndex,int32 SourceIndex,FVector* OutTangentPoint)
		{
			bool ___ret = _this->GetBeamSourceTangent(EmitterIndex,SourceIndex,*OutTangentPoint);
			return ___ret?1:0;
			
		}
		static int32 GetBeamSourcePoint(UParticleSystemComponent* _this,int32 EmitterIndex,int32 SourceIndex,FVector* OutSourcePoint)
		{
			bool ___ret = _this->GetBeamSourcePoint(EmitterIndex,SourceIndex,*OutSourcePoint);
			return ___ret?1:0;
			
		}
		static int32 GetBeamEndPoint(UParticleSystemComponent* _this,int32 EmitterIndex,FVector* OutEndPoint)
		{
			bool ___ret = _this->GetBeamEndPoint(EmitterIndex,*OutEndPoint);
			return ___ret?1:0;
			
		}
		static void SetBeamTargetStrength(UParticleSystemComponent* _this,int32 EmitterIndex,float NewTargetStrength,int32 TargetIndex)
		{
			_this->SetBeamTargetStrength(EmitterIndex,NewTargetStrength,TargetIndex);
			
		}
		static void SetBeamTargetTangent(UParticleSystemComponent* _this,int32 EmitterIndex,FVector* NewTangentPoint,int32 TargetIndex)
		{
			_this->SetBeamTargetTangent(EmitterIndex,*NewTangentPoint,TargetIndex);
			
		}
		static void SetBeamTargetPoint(UParticleSystemComponent* _this,int32 EmitterIndex,FVector* NewTargetPoint,int32 TargetIndex)
		{
			_this->SetBeamTargetPoint(EmitterIndex,*NewTargetPoint,TargetIndex);
			
		}
		static void SetBeamSourceStrength(UParticleSystemComponent* _this,int32 EmitterIndex,float NewSourceStrength,int32 SourceIndex)
		{
			_this->SetBeamSourceStrength(EmitterIndex,NewSourceStrength,SourceIndex);
			
		}
		static void SetBeamSourceTangent(UParticleSystemComponent* _this,int32 EmitterIndex,FVector* NewTangentPoint,int32 SourceIndex)
		{
			_this->SetBeamSourceTangent(EmitterIndex,*NewTangentPoint,SourceIndex);
			
		}
		static void SetBeamSourcePoint(UParticleSystemComponent* _this,int32 EmitterIndex,FVector* NewSourcePoint,int32 SourceIndex)
		{
			_this->SetBeamSourcePoint(EmitterIndex,*NewSourcePoint,SourceIndex);
			
		}
		static void SetBeamEndPoint(UParticleSystemComponent* _this,int32 EmitterIndex,FVector* NewEndPoint)
		{
			_this->SetBeamEndPoint(EmitterIndex,*NewEndPoint);
			
		}
		static UClass* StaticClass(){return UParticleSystemComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::GenerateParticleEvent",(const void*)GenerateParticleEvent);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::GetNamedMaterial",(const void*)GetNamedMaterial);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::CreateNamedDynamicMaterialInstance",(const void*)CreateNamedDynamicMaterialInstance);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::SetTrailSourceData",(const void*)SetTrailSourceData);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::EndTrails",(const void*)EndTrails);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::BeginTrails",(const void*)BeginTrails);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::GetNumActiveParticles",(const void*)GetNumActiveParticles);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::SetTemplate",(const void*)SetTemplate);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::SetMaterialParameter",(const void*)SetMaterialParameter);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::SetActorParameter",(const void*)SetActorParameter);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::SetColorParameter",(const void*)SetColorParameter);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::SetVectorParameter",(const void*)SetVectorParameter);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::SetFloatParameter",(const void*)SetFloatParameter);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::SetEmitterEnable",(const void*)SetEmitterEnable);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::GetBeamTargetStrength",(const void*)GetBeamTargetStrength);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::GetBeamTargetTangent",(const void*)GetBeamTargetTangent);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::GetBeamTargetPoint",(const void*)GetBeamTargetPoint);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::GetBeamSourceStrength",(const void*)GetBeamSourceStrength);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::GetBeamSourceTangent",(const void*)GetBeamSourceTangent);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::GetBeamSourcePoint",(const void*)GetBeamSourcePoint);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::GetBeamEndPoint",(const void*)GetBeamEndPoint);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::SetBeamTargetStrength",(const void*)SetBeamTargetStrength);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::SetBeamTargetTangent",(const void*)SetBeamTargetTangent);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::SetBeamTargetPoint",(const void*)SetBeamTargetPoint);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::SetBeamSourceStrength",(const void*)SetBeamSourceStrength);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::SetBeamSourceTangent",(const void*)SetBeamSourceTangent);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::SetBeamSourcePoint",(const void*)SetBeamSourcePoint);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::SetBeamEndPoint",(const void*)SetBeamEndPoint);
			mono_add_internal_call("UnrealEngine.UParticleSystemComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
