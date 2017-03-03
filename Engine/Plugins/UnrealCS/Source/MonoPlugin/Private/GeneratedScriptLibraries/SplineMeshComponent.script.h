#pragma once

namespace UnrealEngine
{
	class _USplineMeshComponent
	{
		static void SetBoundaryMax(USplineMeshComponent* _this,float InBoundaryMax,int32 bUpdateMesh)
		{
			_this->SetBoundaryMax(InBoundaryMax,bUpdateMesh>0?true:false);
			
		}
		static float GetBoundaryMax(USplineMeshComponent* _this)
		{
			float ___ret = _this->GetBoundaryMax();
			return ___ret;
			
		}
		static void SetBoundaryMin(USplineMeshComponent* _this,float InBoundaryMin,int32 bUpdateMesh)
		{
			_this->SetBoundaryMin(InBoundaryMin,bUpdateMesh>0?true:false);
			
		}
		static float GetBoundaryMin(USplineMeshComponent* _this)
		{
			float ___ret = _this->GetBoundaryMin();
			return ___ret;
			
		}
		static void SetSplineUpDir(USplineMeshComponent* _this,FVector* InSplineUpDir,int32 bUpdateMesh)
		{
			_this->SetSplineUpDir(*InSplineUpDir,bUpdateMesh>0?true:false);
			
		}
		static FVector GetSplineUpDir(USplineMeshComponent* _this)
		{
			FVector ___ret = _this->GetSplineUpDir();
			return ___ret;
			
		}
		static void SetForwardAxis(USplineMeshComponent* _this,int32 InForwardAxis,int32 bUpdateMesh)
		{
			_this->SetForwardAxis((TEnumAsByte<ESplineMeshAxis::Type>)InForwardAxis,bUpdateMesh>0?true:false);
			
		}
		static int32 GetForwardAxis(USplineMeshComponent* _this)
		{
			TEnumAsByte<ESplineMeshAxis::Type> ___ret = _this->GetForwardAxis();
			return (int32)___ret.GetValue();
			
		}
		static void SetEndOffset(USplineMeshComponent* _this,FVector2D* EndOffset,int32 bUpdateMesh)
		{
			_this->SetEndOffset(*EndOffset,bUpdateMesh>0?true:false);
			
		}
		static FVector2D GetEndOffset(USplineMeshComponent* _this)
		{
			FVector2D ___ret = _this->GetEndOffset();
			return ___ret;
			
		}
		static void SetEndRoll(USplineMeshComponent* _this,float EndRoll,int32 bUpdateMesh)
		{
			_this->SetEndRoll(EndRoll,bUpdateMesh>0?true:false);
			
		}
		static float GetEndRoll(USplineMeshComponent* _this)
		{
			float ___ret = _this->GetEndRoll();
			return ___ret;
			
		}
		static void SetEndScale(USplineMeshComponent* _this,FVector2D* EndScale,int32 bUpdateMesh)
		{
			_this->SetEndScale(*EndScale,bUpdateMesh>0?true:false);
			
		}
		static FVector2D GetEndScale(USplineMeshComponent* _this)
		{
			FVector2D ___ret = _this->GetEndScale();
			return ___ret;
			
		}
		static void SetStartOffset(USplineMeshComponent* _this,FVector2D* StartOffset,int32 bUpdateMesh)
		{
			_this->SetStartOffset(*StartOffset,bUpdateMesh>0?true:false);
			
		}
		static FVector2D GetStartOffset(USplineMeshComponent* _this)
		{
			FVector2D ___ret = _this->GetStartOffset();
			return ___ret;
			
		}
		static void SetStartRoll(USplineMeshComponent* _this,float StartRoll,int32 bUpdateMesh)
		{
			_this->SetStartRoll(StartRoll,bUpdateMesh>0?true:false);
			
		}
		static float GetStartRoll(USplineMeshComponent* _this)
		{
			float ___ret = _this->GetStartRoll();
			return ___ret;
			
		}
		static void SetStartScale(USplineMeshComponent* _this,FVector2D* StartScale,int32 bUpdateMesh)
		{
			_this->SetStartScale(*StartScale,bUpdateMesh>0?true:false);
			
		}
		static FVector2D GetStartScale(USplineMeshComponent* _this)
		{
			FVector2D ___ret = _this->GetStartScale();
			return ___ret;
			
		}
		static void SetStartAndEnd(USplineMeshComponent* _this,FVector* StartPos,FVector* StartTangent,FVector* EndPos,FVector* EndTangent,int32 bUpdateMesh)
		{
			_this->SetStartAndEnd(*StartPos,*StartTangent,*EndPos,*EndTangent,bUpdateMesh>0?true:false);
			
		}
		static void SetEndTangent(USplineMeshComponent* _this,FVector* EndTangent,int32 bUpdateMesh)
		{
			_this->SetEndTangent(*EndTangent,bUpdateMesh>0?true:false);
			
		}
		static FVector GetEndTangent(USplineMeshComponent* _this)
		{
			FVector ___ret = _this->GetEndTangent();
			return ___ret;
			
		}
		static void SetEndPosition(USplineMeshComponent* _this,FVector* EndPos,int32 bUpdateMesh)
		{
			_this->SetEndPosition(*EndPos,bUpdateMesh>0?true:false);
			
		}
		static FVector GetEndPosition(USplineMeshComponent* _this)
		{
			FVector ___ret = _this->GetEndPosition();
			return ___ret;
			
		}
		static void SetStartTangent(USplineMeshComponent* _this,FVector* StartTangent,int32 bUpdateMesh)
		{
			_this->SetStartTangent(*StartTangent,bUpdateMesh>0?true:false);
			
		}
		static FVector GetStartTangent(USplineMeshComponent* _this)
		{
			FVector ___ret = _this->GetStartTangent();
			return ___ret;
			
		}
		static void SetStartPosition(USplineMeshComponent* _this,FVector* StartPos,int32 bUpdateMesh)
		{
			_this->SetStartPosition(*StartPos,bUpdateMesh>0?true:false);
			
		}
		static FVector GetStartPosition(USplineMeshComponent* _this)
		{
			FVector ___ret = _this->GetStartPosition();
			return ___ret;
			
		}
		static void UpdateMesh(USplineMeshComponent* _this)
		{
			_this->UpdateMesh();
			
		}
		static UClass* StaticClass(){return USplineMeshComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::SetBoundaryMax",(const void*)SetBoundaryMax);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::GetBoundaryMax",(const void*)GetBoundaryMax);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::SetBoundaryMin",(const void*)SetBoundaryMin);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::GetBoundaryMin",(const void*)GetBoundaryMin);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::SetSplineUpDir",(const void*)SetSplineUpDir);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::GetSplineUpDir",(const void*)GetSplineUpDir);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::SetForwardAxis",(const void*)SetForwardAxis);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::GetForwardAxis",(const void*)GetForwardAxis);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::SetEndOffset",(const void*)SetEndOffset);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::GetEndOffset",(const void*)GetEndOffset);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::SetEndRoll",(const void*)SetEndRoll);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::GetEndRoll",(const void*)GetEndRoll);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::SetEndScale",(const void*)SetEndScale);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::GetEndScale",(const void*)GetEndScale);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::SetStartOffset",(const void*)SetStartOffset);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::GetStartOffset",(const void*)GetStartOffset);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::SetStartRoll",(const void*)SetStartRoll);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::GetStartRoll",(const void*)GetStartRoll);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::SetStartScale",(const void*)SetStartScale);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::GetStartScale",(const void*)GetStartScale);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::SetStartAndEnd",(const void*)SetStartAndEnd);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::SetEndTangent",(const void*)SetEndTangent);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::GetEndTangent",(const void*)GetEndTangent);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::SetEndPosition",(const void*)SetEndPosition);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::GetEndPosition",(const void*)GetEndPosition);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::SetStartTangent",(const void*)SetStartTangent);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::GetStartTangent",(const void*)GetStartTangent);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::SetStartPosition",(const void*)SetStartPosition);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::GetStartPosition",(const void*)GetStartPosition);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::UpdateMesh",(const void*)UpdateMesh);
			mono_add_internal_call("UnrealEngine.USplineMeshComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
