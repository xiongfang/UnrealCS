#pragma once

namespace UnrealEngine
{
	class _USplineComponent
	{
		static FTransform FindTransformClosestToWorldLocation(USplineComponent* _this,FVector* WorldLocation,int32 CoordinateSpace,int32 bUseScale)
		{
			FTransform ___ret = _this->FindTransformClosestToWorldLocation(*WorldLocation,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUseScale>0?true:false);
			return ___ret;
			
		}
		static FVector FindScaleClosestToWorldLocation(USplineComponent* _this,FVector* WorldLocation)
		{
			FVector ___ret = _this->FindScaleClosestToWorldLocation(*WorldLocation);
			return ___ret;
			
		}
		static float FindRollClosestToWorldLocation(USplineComponent* _this,FVector* WorldLocation,int32 CoordinateSpace)
		{
			float ___ret = _this->FindRollClosestToWorldLocation(*WorldLocation,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector FindRightVectorClosestToWorldLocation(USplineComponent* _this,FVector* WorldLocation,int32 CoordinateSpace)
		{
			FVector ___ret = _this->FindRightVectorClosestToWorldLocation(*WorldLocation,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector FindUpVectorClosestToWorldLocation(USplineComponent* _this,FVector* WorldLocation,int32 CoordinateSpace)
		{
			FVector ___ret = _this->FindUpVectorClosestToWorldLocation(*WorldLocation,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FRotator FindRotationClosestToWorldLocation(USplineComponent* _this,FVector* WorldLocation,int32 CoordinateSpace)
		{
			FRotator ___ret = _this->FindRotationClosestToWorldLocation(*WorldLocation,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector FindTangentClosestToWorldLocation(USplineComponent* _this,FVector* WorldLocation,int32 CoordinateSpace)
		{
			FVector ___ret = _this->FindTangentClosestToWorldLocation(*WorldLocation,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector FindDirectionClosestToWorldLocation(USplineComponent* _this,FVector* WorldLocation,int32 CoordinateSpace)
		{
			FVector ___ret = _this->FindDirectionClosestToWorldLocation(*WorldLocation,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector FindLocationClosestToWorldLocation(USplineComponent* _this,FVector* WorldLocation,int32 CoordinateSpace)
		{
			FVector ___ret = _this->FindLocationClosestToWorldLocation(*WorldLocation,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static float FindInputKeyClosestToWorldLocation(USplineComponent* _this,FVector* WorldLocation)
		{
			float ___ret = _this->FindInputKeyClosestToWorldLocation(*WorldLocation);
			return ___ret;
			
		}
		static FVector GetScaleAtTime(USplineComponent* _this,float Time,int32 bUseConstantVelocity)
		{
			FVector ___ret = _this->GetScaleAtTime(Time,bUseConstantVelocity>0?true:false);
			return ___ret;
			
		}
		static float GetRollAtTime(USplineComponent* _this,float Time,int32 CoordinateSpace,int32 bUseConstantVelocity)
		{
			float ___ret = _this->GetRollAtTime(Time,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUseConstantVelocity>0?true:false);
			return ___ret;
			
		}
		static FTransform GetTransformAtTime(USplineComponent* _this,float Time,int32 CoordinateSpace,int32 bUseConstantVelocity,int32 bUseScale)
		{
			FTransform ___ret = _this->GetTransformAtTime(Time,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUseConstantVelocity>0?true:false,bUseScale>0?true:false);
			return ___ret;
			
		}
		static FVector GetRightVectorAtTime(USplineComponent* _this,float Time,int32 CoordinateSpace,int32 bUseConstantVelocity)
		{
			FVector ___ret = _this->GetRightVectorAtTime(Time,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUseConstantVelocity>0?true:false);
			return ___ret;
			
		}
		static FVector GetUpVectorAtTime(USplineComponent* _this,float Time,int32 CoordinateSpace,int32 bUseConstantVelocity)
		{
			FVector ___ret = _this->GetUpVectorAtTime(Time,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUseConstantVelocity>0?true:false);
			return ___ret;
			
		}
		static FRotator GetRotationAtTime(USplineComponent* _this,float Time,int32 CoordinateSpace,int32 bUseConstantVelocity)
		{
			FRotator ___ret = _this->GetRotationAtTime(Time,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUseConstantVelocity>0?true:false);
			return ___ret;
			
		}
		static FVector GetTangentAtTime(USplineComponent* _this,float Time,int32 CoordinateSpace,int32 bUseConstantVelocity)
		{
			FVector ___ret = _this->GetTangentAtTime(Time,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUseConstantVelocity>0?true:false);
			return ___ret;
			
		}
		static FVector GetDirectionAtTime(USplineComponent* _this,float Time,int32 CoordinateSpace,int32 bUseConstantVelocity)
		{
			FVector ___ret = _this->GetDirectionAtTime(Time,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUseConstantVelocity>0?true:false);
			return ___ret;
			
		}
		static FVector GetLocationAtTime(USplineComponent* _this,float Time,int32 CoordinateSpace,int32 bUseConstantVelocity)
		{
			FVector ___ret = _this->GetLocationAtTime(Time,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUseConstantVelocity>0?true:false);
			return ___ret;
			
		}
		static FTransform GetTransformAtDistanceAlongSpline(USplineComponent* _this,float Distance,int32 CoordinateSpace,int32 bUseScale)
		{
			FTransform ___ret = _this->GetTransformAtDistanceAlongSpline(Distance,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUseScale>0?true:false);
			return ___ret;
			
		}
		static FVector GetScaleAtDistanceAlongSpline(USplineComponent* _this,float Distance)
		{
			FVector ___ret = _this->GetScaleAtDistanceAlongSpline(Distance);
			return ___ret;
			
		}
		static float GetRollAtDistanceAlongSpline(USplineComponent* _this,float Distance,int32 CoordinateSpace)
		{
			float ___ret = _this->GetRollAtDistanceAlongSpline(Distance,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector GetRightVectorAtDistanceAlongSpline(USplineComponent* _this,float Distance,int32 CoordinateSpace)
		{
			FVector ___ret = _this->GetRightVectorAtDistanceAlongSpline(Distance,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector GetUpVectorAtDistanceAlongSpline(USplineComponent* _this,float Distance,int32 CoordinateSpace)
		{
			FVector ___ret = _this->GetUpVectorAtDistanceAlongSpline(Distance,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FRotator GetRotationAtDistanceAlongSpline(USplineComponent* _this,float Distance,int32 CoordinateSpace)
		{
			FRotator ___ret = _this->GetRotationAtDistanceAlongSpline(Distance,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector GetTangentAtDistanceAlongSpline(USplineComponent* _this,float Distance,int32 CoordinateSpace)
		{
			FVector ___ret = _this->GetTangentAtDistanceAlongSpline(Distance,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector GetDirectionAtDistanceAlongSpline(USplineComponent* _this,float Distance,int32 CoordinateSpace)
		{
			FVector ___ret = _this->GetDirectionAtDistanceAlongSpline(Distance,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector GetLocationAtDistanceAlongSpline(USplineComponent* _this,float Distance,int32 CoordinateSpace)
		{
			FVector ___ret = _this->GetLocationAtDistanceAlongSpline(Distance,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static float GetInputKeyAtDistanceAlongSpline(USplineComponent* _this,float Distance)
		{
			float ___ret = _this->GetInputKeyAtDistanceAlongSpline(Distance);
			return ___ret;
			
		}
		static FVector GetDefaultUpVector(USplineComponent* _this,int32 CoordinateSpace)
		{
			FVector ___ret = _this->GetDefaultUpVector((TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static void SetDefaultUpVector(USplineComponent* _this,FVector* UpVector,int32 CoordinateSpace)
		{
			_this->SetDefaultUpVector(*UpVector,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			
		}
		static float GetSplineLength(USplineComponent* _this)
		{
			float ___ret = _this->GetSplineLength();
			return ___ret;
			
		}
		static float GetDistanceAlongSplineAtSplinePoint(USplineComponent* _this,int32 PointIndex)
		{
			float ___ret = _this->GetDistanceAlongSplineAtSplinePoint(PointIndex);
			return ___ret;
			
		}
		static void GetLocationAndTangentAtSplinePoint(USplineComponent* _this,int32 PointIndex,FVector* Location,FVector* Tangent,int32 CoordinateSpace)
		{
			_this->GetLocationAndTangentAtSplinePoint(PointIndex,*Location,*Tangent,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			
		}
		static FTransform GetTransformAtSplinePoint(USplineComponent* _this,int32 PointIndex,int32 CoordinateSpace,int32 bUseScale)
		{
			FTransform ___ret = _this->GetTransformAtSplinePoint(PointIndex,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUseScale>0?true:false);
			return ___ret;
			
		}
		static FVector GetScaleAtSplinePoint(USplineComponent* _this,int32 PointIndex)
		{
			FVector ___ret = _this->GetScaleAtSplinePoint(PointIndex);
			return ___ret;
			
		}
		static float GetRollAtSplinePoint(USplineComponent* _this,int32 PointIndex,int32 CoordinateSpace)
		{
			float ___ret = _this->GetRollAtSplinePoint(PointIndex,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector GetRightVectorAtSplinePoint(USplineComponent* _this,int32 PointIndex,int32 CoordinateSpace)
		{
			FVector ___ret = _this->GetRightVectorAtSplinePoint(PointIndex,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector GetUpVectorAtSplinePoint(USplineComponent* _this,int32 PointIndex,int32 CoordinateSpace)
		{
			FVector ___ret = _this->GetUpVectorAtSplinePoint(PointIndex,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FRotator GetRotationAtSplinePoint(USplineComponent* _this,int32 PointIndex,int32 CoordinateSpace)
		{
			FRotator ___ret = _this->GetRotationAtSplinePoint(PointIndex,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector GetLeaveTangentAtSplinePoint(USplineComponent* _this,int32 PointIndex,int32 CoordinateSpace)
		{
			FVector ___ret = _this->GetLeaveTangentAtSplinePoint(PointIndex,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector GetArriveTangentAtSplinePoint(USplineComponent* _this,int32 PointIndex,int32 CoordinateSpace)
		{
			FVector ___ret = _this->GetArriveTangentAtSplinePoint(PointIndex,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector GetTangentAtSplinePoint(USplineComponent* _this,int32 PointIndex,int32 CoordinateSpace)
		{
			FVector ___ret = _this->GetTangentAtSplinePoint(PointIndex,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector GetDirectionAtSplinePoint(USplineComponent* _this,int32 PointIndex,int32 CoordinateSpace)
		{
			FVector ___ret = _this->GetDirectionAtSplinePoint(PointIndex,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static FVector GetLocationAtSplinePoint(USplineComponent* _this,int32 PointIndex,int32 CoordinateSpace)
		{
			FVector ___ret = _this->GetLocationAtSplinePoint(PointIndex,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace);
			return ___ret;
			
		}
		static int32 GetNumberOfSplinePoints(USplineComponent* _this)
		{
			int32 ___ret = _this->GetNumberOfSplinePoints();
			return ___ret;
			
		}
		static void SetSplinePointType(USplineComponent* _this,int32 PointIndex,int32 Type,int32 bUpdateSpline)
		{
			_this->SetSplinePointType(PointIndex,(TEnumAsByte<ESplinePointType::Type>)Type,bUpdateSpline>0?true:false);
			
		}
		static int32 GetSplinePointType(USplineComponent* _this,int32 PointIndex)
		{
			TEnumAsByte<ESplinePointType::Type> ___ret = _this->GetSplinePointType(PointIndex);
			return (int)___ret.GetValue();
			
		}
		static void SetUpVectorAtSplinePoint(USplineComponent* _this,int32 PointIndex,FVector* InUpVector,int32 CoordinateSpace,int32 bUpdateSpline)
		{
			_this->SetUpVectorAtSplinePoint(PointIndex,*InUpVector,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUpdateSpline>0?true:false);
			
		}
		static void SetTangentsAtSplinePoint(USplineComponent* _this,int32 PointIndex,FVector* InArriveTangent,FVector* InLeaveTangent,int32 CoordinateSpace,int32 bUpdateSpline)
		{
			_this->SetTangentsAtSplinePoint(PointIndex,*InArriveTangent,*InLeaveTangent,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUpdateSpline>0?true:false);
			
		}
		static void SetTangentAtSplinePoint(USplineComponent* _this,int32 PointIndex,FVector* InTangent,int32 CoordinateSpace,int32 bUpdateSpline)
		{
			_this->SetTangentAtSplinePoint(PointIndex,*InTangent,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUpdateSpline>0?true:false);
			
		}
		static void SetLocationAtSplinePoint(USplineComponent* _this,int32 PointIndex,FVector* InLocation,int32 CoordinateSpace,int32 bUpdateSpline)
		{
			_this->SetLocationAtSplinePoint(PointIndex,*InLocation,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUpdateSpline>0?true:false);
			
		}
		static void SetSplinePoints(USplineComponent* _this,MonoArray* Points,int32 CoordinateSpace,int32 bUpdateSpline)
		{
			_this->SetSplinePoints(MonoArrayToTArray<FVector>(Points),(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUpdateSpline>0?true:false);
			
		}
		static void RemoveSplinePoint(USplineComponent* _this,int32 Index,int32 bUpdateSpline)
		{
			_this->RemoveSplinePoint(Index,bUpdateSpline>0?true:false);
			
		}
		static void AddSplinePointAtIndex(USplineComponent* _this,FVector* Position,int32 Index,int32 CoordinateSpace,int32 bUpdateSpline)
		{
			_this->AddSplinePointAtIndex(*Position,Index,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUpdateSpline>0?true:false);
			
		}
		static void AddSplinePoint(USplineComponent* _this,FVector* Position,int32 CoordinateSpace,int32 bUpdateSpline)
		{
			_this->AddSplinePoint(*Position,(TEnumAsByte<ESplineCoordinateSpace::Type>)CoordinateSpace,bUpdateSpline>0?true:false);
			
		}
		static void AddPoints(USplineComponent* _this,MonoArray* Points,int32 bUpdateSpline)
		{
			_this->AddPoints(MonoArrayToTArray<FSplinePoint>(Points),bUpdateSpline>0?true:false);
			
		}
		static void AddPoint(USplineComponent* _this,FSplinePoint* Point,int32 bUpdateSpline)
		{
			_this->AddPoint(*Point,bUpdateSpline>0?true:false);
			
		}
		static void ClearSplinePoints(USplineComponent* _this,int32 bUpdateSpline)
		{
			_this->ClearSplinePoints(bUpdateSpline>0?true:false);
			
		}
		static int32 IsClosedLoop(USplineComponent* _this)
		{
			bool ___ret = _this->IsClosedLoop();
			return ___ret?1:0;
			
		}
		static void SetClosedLoopAtPosition(USplineComponent* _this,int32 bInClosedLoop,float Key,int32 bUpdateSpline)
		{
			_this->SetClosedLoopAtPosition(bInClosedLoop>0?true:false,Key,bUpdateSpline>0?true:false);
			
		}
		static void SetClosedLoop(USplineComponent* _this,int32 bInClosedLoop,int32 bUpdateSpline)
		{
			_this->SetClosedLoop(bInClosedLoop>0?true:false,bUpdateSpline>0?true:false);
			
		}
		static void SetDrawDebug(USplineComponent* _this,int32 bShow)
		{
			_this->SetDrawDebug(bShow>0?true:false);
			
		}
		static void SetSelectedSplineSegmentColor(USplineComponent* _this,FLinearColor* SegmentColor)
		{
			_this->SetSelectedSplineSegmentColor(*SegmentColor);
			
		}
		static void SetUnselectedSplineSegmentColor(USplineComponent* _this,FLinearColor* SegmentColor)
		{
			_this->SetUnselectedSplineSegmentColor(*SegmentColor);
			
		}
		static void UpdateSpline(USplineComponent* _this)
		{
			_this->UpdateSpline();
			
		}
		static UClass* StaticClass(){return USplineComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USplineComponent::FindTransformClosestToWorldLocation",(const void*)FindTransformClosestToWorldLocation);
			mono_add_internal_call("UnrealEngine.USplineComponent::FindScaleClosestToWorldLocation",(const void*)FindScaleClosestToWorldLocation);
			mono_add_internal_call("UnrealEngine.USplineComponent::FindRollClosestToWorldLocation",(const void*)FindRollClosestToWorldLocation);
			mono_add_internal_call("UnrealEngine.USplineComponent::FindRightVectorClosestToWorldLocation",(const void*)FindRightVectorClosestToWorldLocation);
			mono_add_internal_call("UnrealEngine.USplineComponent::FindUpVectorClosestToWorldLocation",(const void*)FindUpVectorClosestToWorldLocation);
			mono_add_internal_call("UnrealEngine.USplineComponent::FindRotationClosestToWorldLocation",(const void*)FindRotationClosestToWorldLocation);
			mono_add_internal_call("UnrealEngine.USplineComponent::FindTangentClosestToWorldLocation",(const void*)FindTangentClosestToWorldLocation);
			mono_add_internal_call("UnrealEngine.USplineComponent::FindDirectionClosestToWorldLocation",(const void*)FindDirectionClosestToWorldLocation);
			mono_add_internal_call("UnrealEngine.USplineComponent::FindLocationClosestToWorldLocation",(const void*)FindLocationClosestToWorldLocation);
			mono_add_internal_call("UnrealEngine.USplineComponent::FindInputKeyClosestToWorldLocation",(const void*)FindInputKeyClosestToWorldLocation);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetScaleAtTime",(const void*)GetScaleAtTime);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetRollAtTime",(const void*)GetRollAtTime);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetTransformAtTime",(const void*)GetTransformAtTime);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetRightVectorAtTime",(const void*)GetRightVectorAtTime);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetUpVectorAtTime",(const void*)GetUpVectorAtTime);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetRotationAtTime",(const void*)GetRotationAtTime);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetTangentAtTime",(const void*)GetTangentAtTime);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetDirectionAtTime",(const void*)GetDirectionAtTime);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetLocationAtTime",(const void*)GetLocationAtTime);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetTransformAtDistanceAlongSpline",(const void*)GetTransformAtDistanceAlongSpline);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetScaleAtDistanceAlongSpline",(const void*)GetScaleAtDistanceAlongSpline);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetRollAtDistanceAlongSpline",(const void*)GetRollAtDistanceAlongSpline);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetRightVectorAtDistanceAlongSpline",(const void*)GetRightVectorAtDistanceAlongSpline);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetUpVectorAtDistanceAlongSpline",(const void*)GetUpVectorAtDistanceAlongSpline);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetRotationAtDistanceAlongSpline",(const void*)GetRotationAtDistanceAlongSpline);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetTangentAtDistanceAlongSpline",(const void*)GetTangentAtDistanceAlongSpline);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetDirectionAtDistanceAlongSpline",(const void*)GetDirectionAtDistanceAlongSpline);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetLocationAtDistanceAlongSpline",(const void*)GetLocationAtDistanceAlongSpline);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetInputKeyAtDistanceAlongSpline",(const void*)GetInputKeyAtDistanceAlongSpline);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetDefaultUpVector",(const void*)GetDefaultUpVector);
			mono_add_internal_call("UnrealEngine.USplineComponent::SetDefaultUpVector",(const void*)SetDefaultUpVector);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetSplineLength",(const void*)GetSplineLength);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetDistanceAlongSplineAtSplinePoint",(const void*)GetDistanceAlongSplineAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetLocationAndTangentAtSplinePoint",(const void*)GetLocationAndTangentAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetTransformAtSplinePoint",(const void*)GetTransformAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetScaleAtSplinePoint",(const void*)GetScaleAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetRollAtSplinePoint",(const void*)GetRollAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetRightVectorAtSplinePoint",(const void*)GetRightVectorAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetUpVectorAtSplinePoint",(const void*)GetUpVectorAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetRotationAtSplinePoint",(const void*)GetRotationAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetLeaveTangentAtSplinePoint",(const void*)GetLeaveTangentAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetArriveTangentAtSplinePoint",(const void*)GetArriveTangentAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetTangentAtSplinePoint",(const void*)GetTangentAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetDirectionAtSplinePoint",(const void*)GetDirectionAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetLocationAtSplinePoint",(const void*)GetLocationAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetNumberOfSplinePoints",(const void*)GetNumberOfSplinePoints);
			mono_add_internal_call("UnrealEngine.USplineComponent::SetSplinePointType",(const void*)SetSplinePointType);
			mono_add_internal_call("UnrealEngine.USplineComponent::GetSplinePointType",(const void*)GetSplinePointType);
			mono_add_internal_call("UnrealEngine.USplineComponent::SetUpVectorAtSplinePoint",(const void*)SetUpVectorAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::SetTangentsAtSplinePoint",(const void*)SetTangentsAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::SetTangentAtSplinePoint",(const void*)SetTangentAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::SetLocationAtSplinePoint",(const void*)SetLocationAtSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::SetSplinePoints",(const void*)SetSplinePoints);
			mono_add_internal_call("UnrealEngine.USplineComponent::RemoveSplinePoint",(const void*)RemoveSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::AddSplinePointAtIndex",(const void*)AddSplinePointAtIndex);
			mono_add_internal_call("UnrealEngine.USplineComponent::AddSplinePoint",(const void*)AddSplinePoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::AddPoints",(const void*)AddPoints);
			mono_add_internal_call("UnrealEngine.USplineComponent::AddPoint",(const void*)AddPoint);
			mono_add_internal_call("UnrealEngine.USplineComponent::ClearSplinePoints",(const void*)ClearSplinePoints);
			mono_add_internal_call("UnrealEngine.USplineComponent::IsClosedLoop",(const void*)IsClosedLoop);
			mono_add_internal_call("UnrealEngine.USplineComponent::SetClosedLoopAtPosition",(const void*)SetClosedLoopAtPosition);
			mono_add_internal_call("UnrealEngine.USplineComponent::SetClosedLoop",(const void*)SetClosedLoop);
			mono_add_internal_call("UnrealEngine.USplineComponent::SetDrawDebug",(const void*)SetDrawDebug);
			mono_add_internal_call("UnrealEngine.USplineComponent::SetSelectedSplineSegmentColor",(const void*)SetSelectedSplineSegmentColor);
			mono_add_internal_call("UnrealEngine.USplineComponent::SetUnselectedSplineSegmentColor",(const void*)SetUnselectedSplineSegmentColor);
			mono_add_internal_call("UnrealEngine.USplineComponent::UpdateSpline",(const void*)UpdateSpline);
			mono_add_internal_call("UnrealEngine.USplineComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
