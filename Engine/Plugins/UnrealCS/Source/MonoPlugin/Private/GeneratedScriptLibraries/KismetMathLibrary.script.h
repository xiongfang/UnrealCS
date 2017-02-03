#pragma once

namespace UnrealEngine
{
	class _UKismetMathLibrary
	{
		static int32 LinePlaneIntersection_OriginNormal(UKismetMathLibrary* _this,FVector* LineStart,FVector* LineEnd,FVector* PlaneOrigin,FVector* PlaneNormal,float* T,FVector* Intersection)
		{
			bool ___ret = _this->LinePlaneIntersection_OriginNormal(*LineStart,*LineEnd,*PlaneOrigin,*PlaneNormal,*T,*Intersection);
			return ___ret?1:0;
			
		}
		static int32 LinePlaneIntersection(UKismetMathLibrary* _this,FVector* LineStart,FVector* LineEnd,FPlane* APlane,float* T,FVector* Intersection)
		{
			bool ___ret = _this->LinePlaneIntersection(*LineStart,*LineEnd,*APlane,*T,*Intersection);
			return ___ret?1:0;
			
		}
		static int32 PointsAreCoplanar(UKismetMathLibrary* _this,MonoArray* Points,float Tolerance)
		{
			bool ___ret = _this->PointsAreCoplanar(MonoArrayToTArray<FVector>(Points),Tolerance);
			return ___ret?1:0;
			
		}
		static void MinimumAreaRectangle(UKismetMathLibrary* _this,UObject* WorldContextObject,MonoArray* InVerts,FVector* SampleSurfaceNormal,FVector* OutRectCenter,FRotator* OutRectRotation,float* OutSideLengthX,float* OutSideLengthY,int32 bDebugDraw)
		{
			_this->MinimumAreaRectangle(WorldContextObject,MonoArrayToTArray<FVector>(InVerts),*SampleSurfaceNormal,*OutRectCenter,*OutRectRotation,*OutSideLengthX,*OutSideLengthY,bDebugDraw>0?true:false);
			
		}
		static void SetRandomStreamSeed(UKismetMathLibrary* _this,FRandomStream* Stream,int32 NewSeed)
		{
			_this->SetRandomStreamSeed(*Stream,NewSeed);
			
		}
		static void SeedRandomStream(UKismetMathLibrary* _this,FRandomStream* Stream)
		{
			_this->SeedRandomStream(*Stream);
			
		}
		static void ResetRandomStream(UKismetMathLibrary* _this,FRandomStream* Stream)
		{
			_this->ResetRandomStream(*Stream);
			
		}
		static FRotator RandomRotatorFromStream(UKismetMathLibrary* _this,int32 bRoll,FRandomStream* Stream)
		{
			FRotator ___ret = _this->RandomRotatorFromStream(bRoll>0?true:false,*Stream);
			return ___ret;
			
		}
		static FVector RandomUnitVectorFromStream(UKismetMathLibrary* _this,FRandomStream* Stream)
		{
			FVector ___ret = _this->RandomUnitVectorFromStream(*Stream);
			return ___ret;
			
		}
		static float RandomFloatInRangeFromStream(UKismetMathLibrary* _this,float Min,float Max,FRandomStream* Stream)
		{
			float ___ret = _this->RandomFloatInRangeFromStream(Min,Max,*Stream);
			return ___ret;
			
		}
		static float RandomFloatFromStream(UKismetMathLibrary* _this,FRandomStream* Stream)
		{
			float ___ret = _this->RandomFloatFromStream(*Stream);
			return ___ret;
			
		}
		static int32 RandomBoolFromStream(UKismetMathLibrary* _this,FRandomStream* Stream)
		{
			bool ___ret = _this->RandomBoolFromStream(*Stream);
			return ___ret?1:0;
			
		}
		static int32 RandomIntegerInRangeFromStream(UKismetMathLibrary* _this,int32 Min,int32 Max,FRandomStream* Stream)
		{
			int32 ___ret = _this->RandomIntegerInRangeFromStream(Min,Max,*Stream);
			return ___ret;
			
		}
		static int32 RandomIntegerFromStream(UKismetMathLibrary* _this,int32 Max,FRandomStream* Stream)
		{
			int32 ___ret = _this->RandomIntegerFromStream(Max,*Stream);
			return ___ret;
			
		}
		static FLinearColor CInterpTo(UKismetMathLibrary* _this,FLinearColor* Current,FLinearColor* Target,float DeltaTime,float InterpSpeed)
		{
			FLinearColor ___ret = _this->CInterpTo(*Current,*Target,DeltaTime,InterpSpeed);
			return ___ret;
			
		}
		static FRotator RInterpTo_Constant(UKismetMathLibrary* _this,FRotator* Current,FRotator* Target,float DeltaTime,float InterpSpeed)
		{
			FRotator ___ret = _this->RInterpTo_Constant(*Current,*Target,DeltaTime,InterpSpeed);
			return ___ret;
			
		}
		static FRotator RInterpTo(UKismetMathLibrary* _this,FRotator* Current,FRotator* Target,float DeltaTime,float InterpSpeed)
		{
			FRotator ___ret = _this->RInterpTo(*Current,*Target,DeltaTime,InterpSpeed);
			return ___ret;
			
		}
		static FVector2D Vector2DInterpTo_Constant(UKismetMathLibrary* _this,FVector2D* Current,FVector2D* Target,float DeltaTime,float InterpSpeed)
		{
			FVector2D ___ret = _this->Vector2DInterpTo_Constant(*Current,*Target,DeltaTime,InterpSpeed);
			return ___ret;
			
		}
		static FVector2D Vector2DInterpTo(UKismetMathLibrary* _this,FVector2D* Current,FVector2D* Target,float DeltaTime,float InterpSpeed)
		{
			FVector2D ___ret = _this->Vector2DInterpTo(*Current,*Target,DeltaTime,InterpSpeed);
			return ___ret;
			
		}
		static FVector VInterpTo_Constant(UKismetMathLibrary* _this,FVector* Current,FVector* Target,float DeltaTime,float InterpSpeed)
		{
			FVector ___ret = _this->VInterpTo_Constant(*Current,*Target,DeltaTime,InterpSpeed);
			return ___ret;
			
		}
		static FVector VInterpTo(UKismetMathLibrary* _this,FVector* Current,FVector* Target,float DeltaTime,float InterpSpeed)
		{
			FVector ___ret = _this->VInterpTo(*Current,*Target,DeltaTime,InterpSpeed);
			return ___ret;
			
		}
		static float FInterpTo_Constant(UKismetMathLibrary* _this,float Current,float Target,float DeltaTime,float InterpSpeed)
		{
			float ___ret = _this->FInterpTo_Constant(Current,Target,DeltaTime,InterpSpeed);
			return ___ret;
			
		}
		static float FInterpTo(UKismetMathLibrary* _this,float Current,float Target,float DeltaTime,float InterpSpeed)
		{
			float ___ret = _this->FInterpTo(Current,Target,DeltaTime,InterpSpeed);
			return ___ret;
			
		}
		static int32 NotEqual_Vector2DVector2D(UKismetMathLibrary* _this,FVector2D* A,FVector2D* B,float ErrorTolerance)
		{
			bool ___ret = _this->NotEqual_Vector2DVector2D(*A,*B,ErrorTolerance);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_Vector2DVector2D(UKismetMathLibrary* _this,FVector2D* A,FVector2D* B,float ErrorTolerance)
		{
			bool ___ret = _this->EqualEqual_Vector2DVector2D(*A,*B,ErrorTolerance);
			return ___ret?1:0;
			
		}
		static FVector2D Subtract_Vector2DFloat(UKismetMathLibrary* _this,FVector2D* A,float B)
		{
			FVector2D ___ret = _this->Subtract_Vector2DFloat(*A,B);
			return ___ret;
			
		}
		static FVector2D Add_Vector2DFloat(UKismetMathLibrary* _this,FVector2D* A,float B)
		{
			FVector2D ___ret = _this->Add_Vector2DFloat(*A,B);
			return ___ret;
			
		}
		static FVector2D Divide_Vector2DFloat(UKismetMathLibrary* _this,FVector2D* A,float B)
		{
			FVector2D ___ret = _this->Divide_Vector2DFloat(*A,B);
			return ___ret;
			
		}
		static FVector2D Multiply_Vector2DVector2D(UKismetMathLibrary* _this,FVector2D* A,FVector2D* B)
		{
			FVector2D ___ret = _this->Multiply_Vector2DVector2D(*A,*B);
			return ___ret;
			
		}
		static FVector2D Multiply_Vector2DFloat(UKismetMathLibrary* _this,FVector2D* A,float B)
		{
			FVector2D ___ret = _this->Multiply_Vector2DFloat(*A,B);
			return ___ret;
			
		}
		static FVector2D Subtract_Vector2DVector2D(UKismetMathLibrary* _this,FVector2D* A,FVector2D* B)
		{
			FVector2D ___ret = _this->Subtract_Vector2DVector2D(*A,*B);
			return ___ret;
			
		}
		static FVector2D Add_Vector2DVector2D(UKismetMathLibrary* _this,FVector2D* A,FVector2D* B)
		{
			FVector2D ___ret = _this->Add_Vector2DVector2D(*A,*B);
			return ___ret;
			
		}
		static int32 NearlyEqual_TransformTransform(UKismetMathLibrary* _this,FTransform* A,FTransform* B,float LocationTolerance,float RotationTolerance,float Scale3DTolerance)
		{
			bool ___ret = _this->NearlyEqual_TransformTransform(*A,*B,LocationTolerance,RotationTolerance,Scale3DTolerance);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_TransformTransform(UKismetMathLibrary* _this,FTransform* A,FTransform* B)
		{
			bool ___ret = _this->EqualEqual_TransformTransform(*A,*B);
			return ___ret?1:0;
			
		}
		static FTransform TInterpTo(UKismetMathLibrary* _this,FTransform* Current,FTransform* Target,float DeltaTime,float InterpSpeed)
		{
			FTransform ___ret = _this->TInterpTo(*Current,*Target,DeltaTime,InterpSpeed);
			return ___ret;
			
		}
		static FTransform TEase(UKismetMathLibrary* _this,FTransform* A,FTransform* B,float Alpha,int32 EasingFunc,float BlendExp,int32 Steps)
		{
			FTransform ___ret = _this->TEase(*A,*B,Alpha,(TEnumAsByte<EEasingFunc::Type>)EasingFunc,BlendExp,Steps);
			return ___ret;
			
		}
		static FTransform TLerp(UKismetMathLibrary* _this,FTransform* A,FTransform* B,float Alpha,int32 InterpMode)
		{
			FTransform ___ret = _this->TLerp(*A,*B,Alpha,(TEnumAsByte<ELerpInterpolationMode::Type>)InterpMode);
			return ___ret;
			
		}
		static FTransform InvertTransform(UKismetMathLibrary* _this,FTransform* T)
		{
			FTransform ___ret = _this->InvertTransform(*T);
			return ___ret;
			
		}
		static FTransform ConvertTransformToRelative(UKismetMathLibrary* _this,FTransform* Transform,FTransform* ParentTransform)
		{
			FTransform ___ret = _this->ConvertTransformToRelative(*Transform,*ParentTransform);
			return ___ret;
			
		}
		static FTransform ComposeTransforms(UKismetMathLibrary* _this,FTransform* A,FTransform* B)
		{
			FTransform ___ret = _this->ComposeTransforms(*A,*B);
			return ___ret;
			
		}
		static FVector InverseTransformDirection(UKismetMathLibrary* _this,FTransform* T,FVector* Direction)
		{
			FVector ___ret = _this->InverseTransformDirection(*T,*Direction);
			return ___ret;
			
		}
		static FVector InverseTransformLocation(UKismetMathLibrary* _this,FTransform* T,FVector* Location)
		{
			FVector ___ret = _this->InverseTransformLocation(*T,*Location);
			return ___ret;
			
		}
		static FVector TransformDirection(UKismetMathLibrary* _this,FTransform* T,FVector* Direction)
		{
			FVector ___ret = _this->TransformDirection(*T,*Direction);
			return ___ret;
			
		}
		static FVector TransformLocation(UKismetMathLibrary* _this,FTransform* T,FVector* Location)
		{
			FVector ___ret = _this->TransformLocation(*T,*Location);
			return ___ret;
			
		}
		static int32 NotEqual_NameName(UKismetMathLibrary* _this,MonoString* A,MonoString* B)
		{
			FName A_temp=MonoStringToFName(A);
			FName B_temp=MonoStringToFName(B);
			bool ___ret = _this->NotEqual_NameName(A_temp,B_temp);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_NameName(UKismetMathLibrary* _this,MonoString* A,MonoString* B)
		{
			FName A_temp=MonoStringToFName(A);
			FName B_temp=MonoStringToFName(B);
			bool ___ret = _this->EqualEqual_NameName(A_temp,B_temp);
			return ___ret?1:0;
			
		}
		static int32 ClassIsChildOf(UKismetMathLibrary* _this,TSubclassOf<UObject>  TestClass,TSubclassOf<UObject>  ParentClass)
		{
			bool ___ret = _this->ClassIsChildOf(TestClass,ParentClass);
			return ___ret?1:0;
			
		}
		static int32 NotEqual_ClassClass(UKismetMathLibrary* _this,UClass* A,UClass* B)
		{
			bool ___ret = _this->NotEqual_ClassClass(A,B);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_ClassClass(UKismetMathLibrary* _this,UClass* A,UClass* B)
		{
			bool ___ret = _this->EqualEqual_ClassClass(A,B);
			return ___ret?1:0;
			
		}
		static int32 NotEqual_ObjectObject(UKismetMathLibrary* _this,UObject* A,UObject* B)
		{
			bool ___ret = _this->NotEqual_ObjectObject(A,B);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_ObjectObject(UKismetMathLibrary* _this,UObject* A,UObject* B)
		{
			bool ___ret = _this->EqualEqual_ObjectObject(A,B);
			return ___ret?1:0;
			
		}
		static FVector Conv_RotatorToVector(UKismetMathLibrary* _this,FRotator* InRot)
		{
			FVector ___ret = _this->Conv_RotatorToVector(*InRot);
			return ___ret;
			
		}
		static FRotator Conv_VectorToRotator(UKismetMathLibrary* _this,FVector* InVec)
		{
			FRotator ___ret = _this->Conv_VectorToRotator(*InVec);
			return ___ret;
			
		}
		static FRotator MakeRotationFromAxes(UKismetMathLibrary* _this,FVector* Forward,FVector* Right,FVector* Up)
		{
			FRotator ___ret = _this->MakeRotationFromAxes(*Forward,*Right,*Up);
			return ___ret;
			
		}
		static UClass* SelectClass(UKismetMathLibrary* _this,UClass* A,UClass* B,int32 bSelectA)
		{
			UClass* ___ret = _this->SelectClass(A,B,bSelectA>0?true:false);
			return ___ret;
			
		}
		static UObject* SelectObject(UKismetMathLibrary* _this,UObject* A,UObject* B,int32 bSelectA)
		{
			UObject* ___ret = _this->SelectObject(A,B,bSelectA>0?true:false);
			return ___ret;
			
		}
		static FTransform SelectTransform(UKismetMathLibrary* _this,FTransform* A,FTransform* B,int32 bPickA)
		{
			FTransform ___ret = _this->SelectTransform(*A,*B,bPickA>0?true:false);
			return ___ret;
			
		}
		static FLinearColor SelectColor(UKismetMathLibrary* _this,FLinearColor* A,FLinearColor* B,int32 bPickA)
		{
			FLinearColor ___ret = _this->SelectColor(*A,*B,bPickA>0?true:false);
			return ___ret;
			
		}
		static FRotator SelectRotator(UKismetMathLibrary* _this,FRotator* A,FRotator* B,int32 bPickA)
		{
			FRotator ___ret = _this->SelectRotator(*A,*B,bPickA>0?true:false);
			return ___ret;
			
		}
		static FVector SelectVector(UKismetMathLibrary* _this,FVector* A,FVector* B,int32 bPickA)
		{
			FVector ___ret = _this->SelectVector(*A,*B,bPickA>0?true:false);
			return ___ret;
			
		}
		static float SelectFloat(UKismetMathLibrary* _this,float A,float B,int32 bPickA)
		{
			float ___ret = _this->SelectFloat(A,B,bPickA>0?true:false);
			return ___ret;
			
		}
		static int32 SelectInt(UKismetMathLibrary* _this,int32 A,int32 B,int32 bPickA)
		{
			int32 ___ret = _this->SelectInt(A,B,bPickA>0?true:false);
			return ___ret;
			
		}
		static MonoString* SelectString(UKismetMathLibrary* _this,MonoString* A,MonoString* B,int32 bPickA)
		{
			FString A_temp=MonoStringToFString(A);
			FString B_temp=MonoStringToFString(B);
			FString ___ret = _this->SelectString(A_temp,B_temp,bPickA>0?true:false);
			return FStringToMonoString(___ret);
			
		}
		static void RGBToHSV_Vector(UKismetMathLibrary* _this,FLinearColor* RGB,FLinearColor* HSV)
		{
			_this->RGBToHSV_Vector(*RGB,*HSV);
			
		}
		static void HSVToRGB_Vector(UKismetMathLibrary* _this,FLinearColor* HSV,FLinearColor* RGB)
		{
			_this->HSVToRGB_Vector(*HSV,*RGB);
			
		}
		static void RGBToHSV(UKismetMathLibrary* _this,FLinearColor* InColor,float* H,float* S,float* V,float* A)
		{
			_this->RGBToHSV(*InColor,*H,*S,*V,*A);
			
		}
		static FLinearColor HSVToRGB(UKismetMathLibrary* _this,float H,float S,float V,float A)
		{
			FLinearColor ___ret = _this->HSVToRGB(H,S,V,A);
			return ___ret;
			
		}
		static void BreakColor(UKismetMathLibrary* _this,FLinearColor* InColor,float* R,float* G,float* B,float* A)
		{
			_this->BreakColor(*InColor,*R,*G,*B,*A);
			
		}
		static FLinearColor MakeColor(UKismetMathLibrary* _this,float R,float G,float B,float A)
		{
			FLinearColor ___ret = _this->MakeColor(R,G,B,A);
			return ___ret;
			
		}
		static void BreakRandomStream(UKismetMathLibrary* _this,FRandomStream* InRandomStream,int32* InitialSeed)
		{
			_this->BreakRandomStream(*InRandomStream,*InitialSeed);
			
		}
		static FRandomStream MakeRandomStream(UKismetMathLibrary* _this,int32 InitialSeed)
		{
			FRandomStream ___ret = _this->MakeRandomStream(InitialSeed);
			return ___ret;
			
		}
		static void BreakTransform(UKismetMathLibrary* _this,FTransform* InTransform,FVector* Location,FRotator* Rotation,FVector* Scale)
		{
			_this->BreakTransform(*InTransform,*Location,*Rotation,*Scale);
			
		}
		static FTransform MakeTransform(UKismetMathLibrary* _this,FVector* Location,FRotator* Rotation,FVector* Scale)
		{
			FTransform ___ret = _this->MakeTransform(*Location,*Rotation,*Scale);
			return ___ret;
			
		}
		static void BreakRotIntoAxes(UKismetMathLibrary* _this,FRotator* InRot,FVector* X,FVector* Y,FVector* Z)
		{
			_this->BreakRotIntoAxes(*InRot,*X,*Y,*Z);
			
		}
		static void BreakRotator(UKismetMathLibrary* _this,FRotator* InRot,float* Roll,float* Pitch,float* Yaw)
		{
			_this->BreakRotator(*InRot,*Roll,*Pitch,*Yaw);
			
		}
		static FRotator MakeRotFromZY(UKismetMathLibrary* _this,FVector* Z,FVector* Y)
		{
			FRotator ___ret = _this->MakeRotFromZY(*Z,*Y);
			return ___ret;
			
		}
		static FRotator MakeRotFromZX(UKismetMathLibrary* _this,FVector* Z,FVector* X)
		{
			FRotator ___ret = _this->MakeRotFromZX(*Z,*X);
			return ___ret;
			
		}
		static FRotator MakeRotFromYZ(UKismetMathLibrary* _this,FVector* Y,FVector* Z)
		{
			FRotator ___ret = _this->MakeRotFromYZ(*Y,*Z);
			return ___ret;
			
		}
		static FRotator MakeRotFromYX(UKismetMathLibrary* _this,FVector* Y,FVector* X)
		{
			FRotator ___ret = _this->MakeRotFromYX(*Y,*X);
			return ___ret;
			
		}
		static FRotator MakeRotFromXZ(UKismetMathLibrary* _this,FVector* X,FVector* Z)
		{
			FRotator ___ret = _this->MakeRotFromXZ(*X,*Z);
			return ___ret;
			
		}
		static FRotator MakeRotFromXY(UKismetMathLibrary* _this,FVector* X,FVector* Y)
		{
			FRotator ___ret = _this->MakeRotFromXY(*X,*Y);
			return ___ret;
			
		}
		static FRotator MakeRotFromZ(UKismetMathLibrary* _this,FVector* Z)
		{
			FRotator ___ret = _this->MakeRotFromZ(*Z);
			return ___ret;
			
		}
		static FRotator MakeRotFromY(UKismetMathLibrary* _this,FVector* Y)
		{
			FRotator ___ret = _this->MakeRotFromY(*Y);
			return ___ret;
			
		}
		static FRotator MakeRotFromX(UKismetMathLibrary* _this,FVector* X)
		{
			FRotator ___ret = _this->MakeRotFromX(*X);
			return ___ret;
			
		}
		static FRotator FindLookAtRotation(UKismetMathLibrary* _this,FVector* Start,FVector* Target)
		{
			FRotator ___ret = _this->FindLookAtRotation(*Start,*Target);
			return ___ret;
			
		}
		static FRotator MakeRotator(UKismetMathLibrary* _this,float Roll,float Pitch,float Yaw)
		{
			FRotator ___ret = _this->MakeRotator(Roll,Pitch,Yaw);
			return ___ret;
			
		}
		static void GetYawPitchFromVector(UKismetMathLibrary* _this,FVector* InVec,float* Yaw,float* Pitch)
		{
			_this->GetYawPitchFromVector(*InVec,*Yaw,*Pitch);
			
		}
		static FVector CreateVectorFromYawPitch(UKismetMathLibrary* _this,float Yaw,float Pitch,float Length)
		{
			FVector ___ret = _this->CreateVectorFromYawPitch(Yaw,Pitch,Length);
			return ___ret;
			
		}
		static FVector GetUpVector(UKismetMathLibrary* _this,FRotator* InRot)
		{
			FVector ___ret = _this->GetUpVector(*InRot);
			return ___ret;
			
		}
		static FVector GetRightVector(UKismetMathLibrary* _this,FRotator* InRot)
		{
			FVector ___ret = _this->GetRightVector(*InRot);
			return ___ret;
			
		}
		static FVector GetForwardVector(UKismetMathLibrary* _this,FRotator* InRot)
		{
			FVector ___ret = _this->GetForwardVector(*InRot);
			return ___ret;
			
		}
		static void BreakVector2D(UKismetMathLibrary* _this,FVector2D* InVec,float* X,float* Y)
		{
			_this->BreakVector2D(*InVec,*X,*Y);
			
		}
		static FVector2D MakeVector2D(UKismetMathLibrary* _this,float X,float Y)
		{
			FVector2D ___ret = _this->MakeVector2D(X,Y);
			return ___ret;
			
		}
		static void BreakVector(UKismetMathLibrary* _this,FVector* InVec,float* X,float* Y,float* Z)
		{
			_this->BreakVector(*InVec,*X,*Y,*Z);
			
		}
		static FVector MakeVector(UKismetMathLibrary* _this,float X,float Y,float Z)
		{
			FVector ___ret = _this->MakeVector(X,Y,Z);
			return ___ret;
			
		}
		static FLinearColor Conv_FloatToLinearColor(UKismetMathLibrary* _this,float InFloat)
		{
			FLinearColor ___ret = _this->Conv_FloatToLinearColor(InFloat);
			return ___ret;
			
		}
		static FVector Conv_FloatToVector(UKismetMathLibrary* _this,float InFloat)
		{
			FVector ___ret = _this->Conv_FloatToVector(InFloat);
			return ___ret;
			
		}
		static FVector Conv_Vector2DToVector(UKismetMathLibrary* _this,FVector2D* InVector2D,float Z)
		{
			FVector ___ret = _this->Conv_Vector2DToVector(*InVector2D,Z);
			return ___ret;
			
		}
		static FVector2D Conv_VectorToVector2D(UKismetMathLibrary* _this,FVector* InVector)
		{
			FVector2D ___ret = _this->Conv_VectorToVector2D(*InVector);
			return ___ret;
			
		}
		static FTransform Conv_VectorToTransform(UKismetMathLibrary* _this,FVector* InLocation)
		{
			FTransform ___ret = _this->Conv_VectorToTransform(*InLocation);
			return ___ret;
			
		}
		static FColor Conv_LinearColorToColor(UKismetMathLibrary* _this,FLinearColor* InLinearColor)
		{
			FColor ___ret = _this->Conv_LinearColorToColor(*InLinearColor);
			return ___ret;
			
		}
		static FLinearColor Conv_ColorToLinearColor(UKismetMathLibrary* _this,FColor* InColor)
		{
			FLinearColor ___ret = _this->Conv_ColorToLinearColor(*InColor);
			return ___ret;
			
		}
		static FVector Conv_LinearColorToVector(UKismetMathLibrary* _this,FLinearColor* InLinearColor)
		{
			FVector ___ret = _this->Conv_LinearColorToVector(*InLinearColor);
			return ___ret;
			
		}
		static FLinearColor Conv_VectorToLinearColor(UKismetMathLibrary* _this,FVector* InVec)
		{
			FLinearColor ___ret = _this->Conv_VectorToLinearColor(*InVec);
			return ___ret;
			
		}
		static int32 Conv_ByteToInt(UKismetMathLibrary* _this,int32 InByte)
		{
			int32 ___ret = _this->Conv_ByteToInt(InByte);
			return ___ret;
			
		}
		static int32 Conv_BoolToByte(UKismetMathLibrary* _this,int32 InBool)
		{
			uint8 ___ret = _this->Conv_BoolToByte(InBool>0?true:false);
			return (uint8)___ret;
			
		}
		static float Conv_BoolToFloat(UKismetMathLibrary* _this,int32 InBool)
		{
			float ___ret = _this->Conv_BoolToFloat(InBool>0?true:false);
			return ___ret;
			
		}
		static int32 Conv_BoolToInt(UKismetMathLibrary* _this,int32 InBool)
		{
			int32 ___ret = _this->Conv_BoolToInt(InBool>0?true:false);
			return ___ret;
			
		}
		static int32 Conv_IntToBool(UKismetMathLibrary* _this,int32 InInt)
		{
			bool ___ret = _this->Conv_IntToBool(InInt);
			return ___ret?1:0;
			
		}
		static int32 Conv_IntToByte(UKismetMathLibrary* _this,int32 InInt)
		{
			uint8 ___ret = _this->Conv_IntToByte(InInt);
			return (uint8)___ret;
			
		}
		static float Conv_IntToFloat(UKismetMathLibrary* _this,int32 InInt)
		{
			float ___ret = _this->Conv_IntToFloat(InInt);
			return ___ret;
			
		}
		static float Conv_ByteToFloat(UKismetMathLibrary* _this,int32 InByte)
		{
			float ___ret = _this->Conv_ByteToFloat(InByte);
			return ___ret;
			
		}
		static int32 TimespanFromString(UKismetMathLibrary* _this,MonoString* TimespanString,FTimespan* Result)
		{
			FString TimespanString_temp=MonoStringToFString(TimespanString);
			bool ___ret = _this->TimespanFromString(TimespanString_temp,*Result);
			return ___ret?1:0;
			
		}
		static FTimespan TimespanZeroValue(UKismetMathLibrary* _this)
		{
			FTimespan ___ret = _this->TimespanZeroValue();
			return ___ret;
			
		}
		static float TimespanRatio(UKismetMathLibrary* _this,FTimespan* A,FTimespan* B)
		{
			float ___ret = _this->TimespanRatio(*A,*B);
			return ___ret;
			
		}
		static FTimespan TimespanMinValue(UKismetMathLibrary* _this)
		{
			FTimespan ___ret = _this->TimespanMinValue();
			return ___ret;
			
		}
		static FTimespan TimespanMaxValue(UKismetMathLibrary* _this)
		{
			FTimespan ___ret = _this->TimespanMaxValue();
			return ___ret;
			
		}
		static FTimespan FromSeconds(UKismetMathLibrary* _this,float Seconds)
		{
			FTimespan ___ret = _this->FromSeconds(Seconds);
			return ___ret;
			
		}
		static FTimespan FromMinutes(UKismetMathLibrary* _this,float Minutes)
		{
			FTimespan ___ret = _this->FromMinutes(Minutes);
			return ___ret;
			
		}
		static FTimespan FromMilliseconds(UKismetMathLibrary* _this,float Milliseconds)
		{
			FTimespan ___ret = _this->FromMilliseconds(Milliseconds);
			return ___ret;
			
		}
		static FTimespan FromHours(UKismetMathLibrary* _this,float Hours)
		{
			FTimespan ___ret = _this->FromHours(Hours);
			return ___ret;
			
		}
		static FTimespan FromDays(UKismetMathLibrary* _this,float Days)
		{
			FTimespan ___ret = _this->FromDays(Days);
			return ___ret;
			
		}
		static float GetTotalSeconds(UKismetMathLibrary* _this,FTimespan* A)
		{
			float ___ret = _this->GetTotalSeconds(*A);
			return ___ret;
			
		}
		static float GetTotalMinutes(UKismetMathLibrary* _this,FTimespan* A)
		{
			float ___ret = _this->GetTotalMinutes(*A);
			return ___ret;
			
		}
		static float GetTotalMilliseconds(UKismetMathLibrary* _this,FTimespan* A)
		{
			float ___ret = _this->GetTotalMilliseconds(*A);
			return ___ret;
			
		}
		static float GetTotalHours(UKismetMathLibrary* _this,FTimespan* A)
		{
			float ___ret = _this->GetTotalHours(*A);
			return ___ret;
			
		}
		static float GetTotalDays(UKismetMathLibrary* _this,FTimespan* A)
		{
			float ___ret = _this->GetTotalDays(*A);
			return ___ret;
			
		}
		static int32 GetSeconds(UKismetMathLibrary* _this,FTimespan* A)
		{
			int32 ___ret = _this->GetSeconds(*A);
			return ___ret;
			
		}
		static int32 GetMinutes(UKismetMathLibrary* _this,FTimespan* A)
		{
			int32 ___ret = _this->GetMinutes(*A);
			return ___ret;
			
		}
		static int32 GetMilliseconds(UKismetMathLibrary* _this,FTimespan* A)
		{
			int32 ___ret = _this->GetMilliseconds(*A);
			return ___ret;
			
		}
		static int32 GetHours(UKismetMathLibrary* _this,FTimespan* A)
		{
			int32 ___ret = _this->GetHours(*A);
			return ___ret;
			
		}
		static FTimespan GetDuration(UKismetMathLibrary* _this,FTimespan* A)
		{
			FTimespan ___ret = _this->GetDuration(*A);
			return ___ret;
			
		}
		static int32 GetDays(UKismetMathLibrary* _this,FTimespan* A)
		{
			int32 ___ret = _this->GetDays(*A);
			return ___ret;
			
		}
		static int32 LessEqual_TimespanTimespan(UKismetMathLibrary* _this,FTimespan* A,FTimespan* B)
		{
			bool ___ret = _this->LessEqual_TimespanTimespan(*A,*B);
			return ___ret?1:0;
			
		}
		static int32 Less_TimespanTimespan(UKismetMathLibrary* _this,FTimespan* A,FTimespan* B)
		{
			bool ___ret = _this->Less_TimespanTimespan(*A,*B);
			return ___ret?1:0;
			
		}
		static int32 GreaterEqual_TimespanTimespan(UKismetMathLibrary* _this,FTimespan* A,FTimespan* B)
		{
			bool ___ret = _this->GreaterEqual_TimespanTimespan(*A,*B);
			return ___ret?1:0;
			
		}
		static int32 Greater_TimespanTimespan(UKismetMathLibrary* _this,FTimespan* A,FTimespan* B)
		{
			bool ___ret = _this->Greater_TimespanTimespan(*A,*B);
			return ___ret?1:0;
			
		}
		static int32 NotEqual_TimespanTimespan(UKismetMathLibrary* _this,FTimespan* A,FTimespan* B)
		{
			bool ___ret = _this->NotEqual_TimespanTimespan(*A,*B);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_TimespanTimespan(UKismetMathLibrary* _this,FTimespan* A,FTimespan* B)
		{
			bool ___ret = _this->EqualEqual_TimespanTimespan(*A,*B);
			return ___ret?1:0;
			
		}
		static FTimespan Multiply_TimespanFloat(UKismetMathLibrary* _this,FTimespan* A,float Scalar)
		{
			FTimespan ___ret = _this->Multiply_TimespanFloat(*A,Scalar);
			return ___ret;
			
		}
		static FTimespan Subtract_TimespanTimespan(UKismetMathLibrary* _this,FTimespan* A,FTimespan* B)
		{
			FTimespan ___ret = _this->Subtract_TimespanTimespan(*A,*B);
			return ___ret;
			
		}
		static FTimespan Add_TimespanTimespan(UKismetMathLibrary* _this,FTimespan* A,FTimespan* B)
		{
			FTimespan ___ret = _this->Add_TimespanTimespan(*A,*B);
			return ___ret;
			
		}
		static void BreakTimespan(UKismetMathLibrary* _this,FTimespan* InTimespan,int32* Days,int32* Hours,int32* Minutes,int32* Seconds,int32* Milliseconds)
		{
			_this->BreakTimespan(*InTimespan,*Days,*Hours,*Minutes,*Seconds,*Milliseconds);
			
		}
		static FTimespan MakeTimespan(UKismetMathLibrary* _this,int32 Days,int32 Hours,int32 Minutes,int32 Seconds,int32 Milliseconds)
		{
			FTimespan ___ret = _this->MakeTimespan(Days,Hours,Minutes,Seconds,Milliseconds);
			return ___ret;
			
		}
		static int32 DateTimeFromString(UKismetMathLibrary* _this,MonoString* DateTimeString,FDateTime* Result)
		{
			FString DateTimeString_temp=MonoStringToFString(DateTimeString);
			bool ___ret = _this->DateTimeFromString(DateTimeString_temp,*Result);
			return ___ret?1:0;
			
		}
		static int32 DateTimeFromIsoString(UKismetMathLibrary* _this,MonoString* IsoString,FDateTime* Result)
		{
			FString IsoString_temp=MonoStringToFString(IsoString);
			bool ___ret = _this->DateTimeFromIsoString(IsoString_temp,*Result);
			return ___ret?1:0;
			
		}
		static FDateTime UtcNow(UKismetMathLibrary* _this)
		{
			FDateTime ___ret = _this->UtcNow();
			return ___ret;
			
		}
		static FDateTime Today(UKismetMathLibrary* _this)
		{
			FDateTime ___ret = _this->Today();
			return ___ret;
			
		}
		static FDateTime Now(UKismetMathLibrary* _this)
		{
			FDateTime ___ret = _this->Now();
			return ___ret;
			
		}
		static FDateTime DateTimeMinValue(UKismetMathLibrary* _this)
		{
			FDateTime ___ret = _this->DateTimeMinValue();
			return ___ret;
			
		}
		static FDateTime DateTimeMaxValue(UKismetMathLibrary* _this)
		{
			FDateTime ___ret = _this->DateTimeMaxValue();
			return ___ret;
			
		}
		static int32 IsLeapYear(UKismetMathLibrary* _this,int32 Year)
		{
			bool ___ret = _this->IsLeapYear(Year);
			return ___ret?1:0;
			
		}
		static int32 DaysInYear(UKismetMathLibrary* _this,int32 Year)
		{
			int32 ___ret = _this->DaysInYear(Year);
			return ___ret;
			
		}
		static int32 DaysInMonth(UKismetMathLibrary* _this,int32 Year,int32 Month)
		{
			int32 ___ret = _this->DaysInMonth(Year,Month);
			return ___ret;
			
		}
		static int32 IsMorning(UKismetMathLibrary* _this,FDateTime* A)
		{
			bool ___ret = _this->IsMorning(*A);
			return ___ret?1:0;
			
		}
		static int32 IsAfternoon(UKismetMathLibrary* _this,FDateTime* A)
		{
			bool ___ret = _this->IsAfternoon(*A);
			return ___ret?1:0;
			
		}
		static int32 GetYear(UKismetMathLibrary* _this,FDateTime* A)
		{
			int32 ___ret = _this->GetYear(*A);
			return ___ret;
			
		}
		static FTimespan GetTimeOfDay(UKismetMathLibrary* _this,FDateTime* A)
		{
			FTimespan ___ret = _this->GetTimeOfDay(*A);
			return ___ret;
			
		}
		static int32 GetSecond(UKismetMathLibrary* _this,FDateTime* A)
		{
			int32 ___ret = _this->GetSecond(*A);
			return ___ret;
			
		}
		static int32 GetMonth(UKismetMathLibrary* _this,FDateTime* A)
		{
			int32 ___ret = _this->GetMonth(*A);
			return ___ret;
			
		}
		static int32 GetMinute(UKismetMathLibrary* _this,FDateTime* A)
		{
			int32 ___ret = _this->GetMinute(*A);
			return ___ret;
			
		}
		static int32 GetMillisecond(UKismetMathLibrary* _this,FDateTime* A)
		{
			int32 ___ret = _this->GetMillisecond(*A);
			return ___ret;
			
		}
		static int32 GetHour12(UKismetMathLibrary* _this,FDateTime* A)
		{
			int32 ___ret = _this->GetHour12(*A);
			return ___ret;
			
		}
		static int32 GetHour(UKismetMathLibrary* _this,FDateTime* A)
		{
			int32 ___ret = _this->GetHour(*A);
			return ___ret;
			
		}
		static int32 GetDayOfYear(UKismetMathLibrary* _this,FDateTime* A)
		{
			int32 ___ret = _this->GetDayOfYear(*A);
			return ___ret;
			
		}
		static int32 GetDay(UKismetMathLibrary* _this,FDateTime* A)
		{
			int32 ___ret = _this->GetDay(*A);
			return ___ret;
			
		}
		static FDateTime GetDate(UKismetMathLibrary* _this,FDateTime* A)
		{
			FDateTime ___ret = _this->GetDate(*A);
			return ___ret;
			
		}
		static int32 LessEqual_DateTimeDateTime(UKismetMathLibrary* _this,FDateTime* A,FDateTime* B)
		{
			bool ___ret = _this->LessEqual_DateTimeDateTime(*A,*B);
			return ___ret?1:0;
			
		}
		static int32 Less_DateTimeDateTime(UKismetMathLibrary* _this,FDateTime* A,FDateTime* B)
		{
			bool ___ret = _this->Less_DateTimeDateTime(*A,*B);
			return ___ret?1:0;
			
		}
		static int32 GreaterEqual_DateTimeDateTime(UKismetMathLibrary* _this,FDateTime* A,FDateTime* B)
		{
			bool ___ret = _this->GreaterEqual_DateTimeDateTime(*A,*B);
			return ___ret?1:0;
			
		}
		static int32 Greater_DateTimeDateTime(UKismetMathLibrary* _this,FDateTime* A,FDateTime* B)
		{
			bool ___ret = _this->Greater_DateTimeDateTime(*A,*B);
			return ___ret?1:0;
			
		}
		static int32 NotEqual_DateTimeDateTime(UKismetMathLibrary* _this,FDateTime* A,FDateTime* B)
		{
			bool ___ret = _this->NotEqual_DateTimeDateTime(*A,*B);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_DateTimeDateTime(UKismetMathLibrary* _this,FDateTime* A,FDateTime* B)
		{
			bool ___ret = _this->EqualEqual_DateTimeDateTime(*A,*B);
			return ___ret?1:0;
			
		}
		static FTimespan Subtract_DateTimeDateTime(UKismetMathLibrary* _this,FDateTime* A,FDateTime* B)
		{
			FTimespan ___ret = _this->Subtract_DateTimeDateTime(*A,*B);
			return ___ret;
			
		}
		static FDateTime Subtract_DateTimeTimespan(UKismetMathLibrary* _this,FDateTime* A,FTimespan* B)
		{
			FDateTime ___ret = _this->Subtract_DateTimeTimespan(*A,*B);
			return ___ret;
			
		}
		static FDateTime Add_DateTimeTimespan(UKismetMathLibrary* _this,FDateTime* A,FTimespan* B)
		{
			FDateTime ___ret = _this->Add_DateTimeTimespan(*A,*B);
			return ___ret;
			
		}
		static void BreakDateTime(UKismetMathLibrary* _this,FDateTime* InDateTime,int32* Year,int32* Month,int32* Day,int32* Hour,int32* Minute,int32* Second,int32* Millisecond)
		{
			_this->BreakDateTime(*InDateTime,*Year,*Month,*Day,*Hour,*Minute,*Second,*Millisecond);
			
		}
		static FDateTime MakeDateTime(UKismetMathLibrary* _this,int32 Year,int32 Month,int32 Day,int32 Hour,int32 Minute,int32 Second,int32 Millisecond)
		{
			FDateTime ___ret = _this->MakeDateTime(Year,Month,Day,Hour,Minute,Second,Millisecond);
			return ___ret;
			
		}
		static FPlane MakePlaneFromPointAndNormal(UKismetMathLibrary* _this,FVector* Point,FVector* Normal)
		{
			FPlane ___ret = _this->MakePlaneFromPointAndNormal(*Point,*Normal);
			return ___ret;
			
		}
		static FLinearColor Multiply_LinearColorFloat(UKismetMathLibrary* _this,FLinearColor* A,float B)
		{
			FLinearColor ___ret = _this->Multiply_LinearColorFloat(*A,B);
			return ___ret;
			
		}
		static FLinearColor Multiply_LinearColorLinearColor(UKismetMathLibrary* _this,FLinearColor* A,FLinearColor* B)
		{
			FLinearColor ___ret = _this->Multiply_LinearColorLinearColor(*A,*B);
			return ___ret;
			
		}
		static FLinearColor LinearColorLerpUsingHSV(UKismetMathLibrary* _this,FLinearColor* A,FLinearColor* B,float Alpha)
		{
			FLinearColor ___ret = _this->LinearColorLerpUsingHSV(*A,*B,Alpha);
			return ___ret;
			
		}
		static FLinearColor LinearColorLerp(UKismetMathLibrary* _this,FLinearColor* A,FLinearColor* B,float Alpha)
		{
			FLinearColor ___ret = _this->LinearColorLerp(*A,*B,Alpha);
			return ___ret;
			
		}
		static float NormalizeAxis(UKismetMathLibrary* _this,float Angle)
		{
			float ___ret = _this->NormalizeAxis(Angle);
			return ___ret;
			
		}
		static float ClampAxis(UKismetMathLibrary* _this,float Angle)
		{
			float ___ret = _this->ClampAxis(Angle);
			return ___ret;
			
		}
		static FRotator RotatorFromAxisAndAngle(UKismetMathLibrary* _this,FVector* Axis,float Angle)
		{
			FRotator ___ret = _this->RotatorFromAxisAndAngle(*Axis,Angle);
			return ___ret;
			
		}
		static FRotator NormalizedDeltaRotator(UKismetMathLibrary* _this,FRotator* A,FRotator* B)
		{
			FRotator ___ret = _this->NormalizedDeltaRotator(*A,*B);
			return ___ret;
			
		}
		static FRotator REase(UKismetMathLibrary* _this,FRotator* A,FRotator* B,float Alpha,int32 bShortestPath,int32 EasingFunc,float BlendExp,int32 Steps)
		{
			FRotator ___ret = _this->REase(*A,*B,Alpha,bShortestPath>0?true:false,(TEnumAsByte<EEasingFunc::Type>)EasingFunc,BlendExp,Steps);
			return ___ret;
			
		}
		static FRotator RLerp(UKismetMathLibrary* _this,FRotator* A,FRotator* B,float Alpha,int32 bShortestPath)
		{
			FRotator ___ret = _this->RLerp(*A,*B,Alpha,bShortestPath>0?true:false);
			return ___ret;
			
		}
		static FRotator RandomRotator(UKismetMathLibrary* _this,int32 bRoll)
		{
			FRotator ___ret = _this->RandomRotator(bRoll>0?true:false);
			return ___ret;
			
		}
		static void GetAxes(UKismetMathLibrary* _this,FRotator* A,FVector* X,FVector* Y,FVector* Z)
		{
			_this->GetAxes(*A,*X,*Y,*Z);
			
		}
		static FRotator NegateRotator(UKismetMathLibrary* _this,FRotator* A)
		{
			FRotator ___ret = _this->NegateRotator(*A);
			return ___ret;
			
		}
		static FRotator ComposeRotators(UKismetMathLibrary* _this,FRotator* A,FRotator* B)
		{
			FRotator ___ret = _this->ComposeRotators(*A,*B);
			return ___ret;
			
		}
		static FRotator Multiply_RotatorInt(UKismetMathLibrary* _this,FRotator* A,int32 B)
		{
			FRotator ___ret = _this->Multiply_RotatorInt(*A,B);
			return ___ret;
			
		}
		static FRotator Multiply_RotatorFloat(UKismetMathLibrary* _this,FRotator* A,float B)
		{
			FRotator ___ret = _this->Multiply_RotatorFloat(*A,B);
			return ___ret;
			
		}
		static int32 NotEqual_RotatorRotator(UKismetMathLibrary* _this,FRotator* A,FRotator* B,float ErrorTolerance)
		{
			bool ___ret = _this->NotEqual_RotatorRotator(*A,*B,ErrorTolerance);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_RotatorRotator(UKismetMathLibrary* _this,FRotator* A,FRotator* B,float ErrorTolerance)
		{
			bool ___ret = _this->EqualEqual_RotatorRotator(*A,*B,ErrorTolerance);
			return ___ret?1:0;
			
		}
		static FVector GetDirectionVector(UKismetMathLibrary* _this,FVector* From,FVector* To)
		{
			FVector ___ret = _this->GetDirectionVector(*From,*To);
			return ___ret;
			
		}
		static FVector GetVectorArrayAverage(UKismetMathLibrary* _this,MonoArray* Vectors)
		{
			FVector ___ret = _this->GetVectorArrayAverage(MonoArrayToTArray<FVector>(Vectors));
			return ___ret;
			
		}
		static float GetMaxElement(UKismetMathLibrary* _this,FVector* A)
		{
			float ___ret = _this->GetMaxElement(*A);
			return ___ret;
			
		}
		static float GetMinElement(UKismetMathLibrary* _this,FVector* A)
		{
			float ___ret = _this->GetMinElement(*A);
			return ___ret;
			
		}
		static FVector ClampVectorSize(UKismetMathLibrary* _this,FVector* A,float Min,float Max)
		{
			FVector ___ret = _this->ClampVectorSize(*A,Min,Max);
			return ___ret;
			
		}
		static FVector NegateVector(UKismetMathLibrary* _this,FVector* A)
		{
			FVector ___ret = _this->NegateVector(*A);
			return ___ret;
			
		}
		static FVector ProjectVectorOnToPlane(UKismetMathLibrary* _this,FVector* V,FVector* PlaneNormal)
		{
			FVector ___ret = _this->ProjectVectorOnToPlane(*V,*PlaneNormal);
			return ___ret;
			
		}
		static FVector ProjectPointOnToPlane(UKismetMathLibrary* _this,FVector* Point,FVector* PlaneBase,FVector* PlaneNormal)
		{
			FVector ___ret = _this->ProjectPointOnToPlane(*Point,*PlaneBase,*PlaneNormal);
			return ___ret;
			
		}
		static float GetPointDistanceToLine(UKismetMathLibrary* _this,FVector* Point,FVector* LineOrigin,FVector* LineDirection)
		{
			float ___ret = _this->GetPointDistanceToLine(*Point,*LineOrigin,*LineDirection);
			return ___ret;
			
		}
		static float GetPointDistanceToSegment(UKismetMathLibrary* _this,FVector* Point,FVector* SegmentStart,FVector* SegmentEnd)
		{
			float ___ret = _this->GetPointDistanceToSegment(*Point,*SegmentStart,*SegmentEnd);
			return ___ret;
			
		}
		static FVector FindClosestPointOnLine(UKismetMathLibrary* _this,FVector* Point,FVector* LineOrigin,FVector* LineDirection)
		{
			FVector ___ret = _this->FindClosestPointOnLine(*Point,*LineOrigin,*LineDirection);
			return ___ret;
			
		}
		static FVector FindClosestPointOnSegment(UKismetMathLibrary* _this,FVector* Point,FVector* SegmentStart,FVector* SegmentEnd)
		{
			FVector ___ret = _this->FindClosestPointOnSegment(*Point,*SegmentStart,*SegmentEnd);
			return ___ret;
			
		}
		static void FindNearestPointsOnLineSegments(UKismetMathLibrary* _this,FVector* Segment1Start,FVector* Segment1End,FVector* Segment2Start,FVector* Segment2End,FVector* Segment1Point,FVector* Segment2Point)
		{
			_this->FindNearestPointsOnLineSegments(*Segment1Start,*Segment1End,*Segment2Start,*Segment2End,*Segment1Point,*Segment2Point);
			
		}
		static FVector ProjectVectorOnToVector(UKismetMathLibrary* _this,FVector* V,FVector* Target)
		{
			FVector ___ret = _this->ProjectVectorOnToVector(*V,*Target);
			return ___ret;
			
		}
		static FVector MirrorVectorByNormal(UKismetMathLibrary* _this,FVector* InVect,FVector* InNormal)
		{
			FVector ___ret = _this->MirrorVectorByNormal(*InVect,*InNormal);
			return ___ret;
			
		}
		static FVector RandomUnitVectorInConeWithYawAndPitch(UKismetMathLibrary* _this,FVector* ConeDir,float MaxYawInDegrees,float MaxPitchInDegrees)
		{
			FVector ___ret = _this->RandomUnitVectorInConeWithYawAndPitch(*ConeDir,MaxYawInDegrees,MaxPitchInDegrees);
			return ___ret;
			
		}
		static FVector RandomUnitVectorInCone(UKismetMathLibrary* _this,FVector* ConeDir,float ConeHalfAngle)
		{
			FVector ___ret = _this->RandomUnitVectorInCone(*ConeDir,ConeHalfAngle);
			return ___ret;
			
		}
		static FVector RandomPointInBoundingBox(UKismetMathLibrary* _this,FVector* Origin,FVector* BoxExtent)
		{
			FVector ___ret = _this->RandomPointInBoundingBox(*Origin,*BoxExtent);
			return ___ret;
			
		}
		static FVector RandomUnitVector(UKismetMathLibrary* _this)
		{
			FVector ___ret = _this->RandomUnitVector();
			return ___ret;
			
		}
		static FVector VEase(UKismetMathLibrary* _this,FVector* A,FVector* B,float Alpha,int32 EasingFunc,float BlendExp,int32 Steps)
		{
			FVector ___ret = _this->VEase(*A,*B,Alpha,(TEnumAsByte<EEasingFunc::Type>)EasingFunc,BlendExp,Steps);
			return ___ret;
			
		}
		static FVector VLerp(UKismetMathLibrary* _this,FVector* A,FVector* B,float Alpha)
		{
			FVector ___ret = _this->VLerp(*A,*B,Alpha);
			return ___ret;
			
		}
		static FVector2D Normal2D(UKismetMathLibrary* _this,FVector2D* A)
		{
			FVector2D ___ret = _this->Normal2D(*A);
			return ___ret;
			
		}
		static FVector Normal(UKismetMathLibrary* _this,FVector* A)
		{
			FVector ___ret = _this->Normal(*A);
			return ___ret;
			
		}
		static float VSize2DSquared(UKismetMathLibrary* _this,FVector2D* A)
		{
			float ___ret = _this->VSize2DSquared(*A);
			return ___ret;
			
		}
		static float VSizeSquared(UKismetMathLibrary* _this,FVector* A)
		{
			float ___ret = _this->VSizeSquared(*A);
			return ___ret;
			
		}
		static float VSize2D(UKismetMathLibrary* _this,FVector2D* A)
		{
			float ___ret = _this->VSize2D(*A);
			return ___ret;
			
		}
		static float VSize(UKismetMathLibrary* _this,FVector* A)
		{
			float ___ret = _this->VSize(*A);
			return ___ret;
			
		}
		static float CrossProduct2D(UKismetMathLibrary* _this,FVector2D* A,FVector2D* B)
		{
			float ___ret = _this->CrossProduct2D(*A,*B);
			return ___ret;
			
		}
		static float DotProduct2D(UKismetMathLibrary* _this,FVector2D* A,FVector2D* B)
		{
			float ___ret = _this->DotProduct2D(*A,*B);
			return ___ret;
			
		}
		static FVector Cross_VectorVector(UKismetMathLibrary* _this,FVector* A,FVector* B)
		{
			FVector ___ret = _this->Cross_VectorVector(*A,*B);
			return ___ret;
			
		}
		static float Dot_VectorVector(UKismetMathLibrary* _this,FVector* A,FVector* B)
		{
			float ___ret = _this->Dot_VectorVector(*A,*B);
			return ___ret;
			
		}
		static int32 NotEqual_VectorVector(UKismetMathLibrary* _this,FVector* A,FVector* B,float ErrorTolerance)
		{
			bool ___ret = _this->NotEqual_VectorVector(*A,*B,ErrorTolerance);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_VectorVector(UKismetMathLibrary* _this,FVector* A,FVector* B,float ErrorTolerance)
		{
			bool ___ret = _this->EqualEqual_VectorVector(*A,*B,ErrorTolerance);
			return ___ret?1:0;
			
		}
		static FVector RotateAngleAxis(UKismetMathLibrary* _this,FVector* InVect,float AngleDeg,FVector* Axis)
		{
			FVector ___ret = _this->RotateAngleAxis(*InVect,AngleDeg,*Axis);
			return ___ret;
			
		}
		static FVector GreaterGreater_VectorRotator(UKismetMathLibrary* _this,FVector* A,FRotator* B)
		{
			FVector ___ret = _this->GreaterGreater_VectorRotator(*A,*B);
			return ___ret;
			
		}
		static FVector LessLess_VectorRotator(UKismetMathLibrary* _this,FVector* A,FRotator* B)
		{
			FVector ___ret = _this->LessLess_VectorRotator(*A,*B);
			return ___ret;
			
		}
		static FVector Subtract_VectorInt(UKismetMathLibrary* _this,FVector* A,int32 B)
		{
			FVector ___ret = _this->Subtract_VectorInt(*A,B);
			return ___ret;
			
		}
		static FVector Subtract_VectorFloat(UKismetMathLibrary* _this,FVector* A,float B)
		{
			FVector ___ret = _this->Subtract_VectorFloat(*A,B);
			return ___ret;
			
		}
		static FVector Subtract_VectorVector(UKismetMathLibrary* _this,FVector* A,FVector* B)
		{
			FVector ___ret = _this->Subtract_VectorVector(*A,*B);
			return ___ret;
			
		}
		static FVector Add_VectorInt(UKismetMathLibrary* _this,FVector* A,int32 B)
		{
			FVector ___ret = _this->Add_VectorInt(*A,B);
			return ___ret;
			
		}
		static FVector Add_VectorFloat(UKismetMathLibrary* _this,FVector* A,float B)
		{
			FVector ___ret = _this->Add_VectorFloat(*A,B);
			return ___ret;
			
		}
		static FVector Add_VectorVector(UKismetMathLibrary* _this,FVector* A,FVector* B)
		{
			FVector ___ret = _this->Add_VectorVector(*A,*B);
			return ___ret;
			
		}
		static FVector Divide_VectorVector(UKismetMathLibrary* _this,FVector* A,FVector* B)
		{
			FVector ___ret = _this->Divide_VectorVector(*A,*B);
			return ___ret;
			
		}
		static FVector Divide_VectorInt(UKismetMathLibrary* _this,FVector* A,int32 B)
		{
			FVector ___ret = _this->Divide_VectorInt(*A,B);
			return ___ret;
			
		}
		static FVector Divide_VectorFloat(UKismetMathLibrary* _this,FVector* A,float B)
		{
			FVector ___ret = _this->Divide_VectorFloat(*A,B);
			return ___ret;
			
		}
		static FVector Multiply_VectorVector(UKismetMathLibrary* _this,FVector* A,FVector* B)
		{
			FVector ___ret = _this->Multiply_VectorVector(*A,*B);
			return ___ret;
			
		}
		static FVector Multiply_VectorInt(UKismetMathLibrary* _this,FVector* A,int32 B)
		{
			FVector ___ret = _this->Multiply_VectorInt(*A,B);
			return ___ret;
			
		}
		static FVector Multiply_VectorFloat(UKismetMathLibrary* _this,FVector* A,float B)
		{
			FVector ___ret = _this->Multiply_VectorFloat(*A,B);
			return ___ret;
			
		}
		static float FixedTurn(UKismetMathLibrary* _this,float InCurrent,float InDesired,float InDeltaRate)
		{
			float ___ret = _this->FixedTurn(InCurrent,InDesired,InDeltaRate);
			return ___ret;
			
		}
		static float MakePulsatingValue(UKismetMathLibrary* _this,float InCurrentTime,float InPulsesPerSecond,float InPhase)
		{
			float ___ret = _this->MakePulsatingValue(InCurrentTime,InPulsesPerSecond,InPhase);
			return ___ret;
			
		}
		static float FInterpEaseInOut(UKismetMathLibrary* _this,float A,float B,float Alpha,float Exponent)
		{
			float ___ret = _this->FInterpEaseInOut(A,B,Alpha,Exponent);
			return ___ret;
			
		}
		static float MultiplyByPi(UKismetMathLibrary* _this,float Value)
		{
			float ___ret = _this->MultiplyByPi(Value);
			return ___ret;
			
		}
		static float MapRangeClamped(UKismetMathLibrary* _this,float Value,float InRangeA,float InRangeB,float OutRangeA,float OutRangeB)
		{
			float ___ret = _this->MapRangeClamped(Value,InRangeA,InRangeB,OutRangeA,OutRangeB);
			return ___ret;
			
		}
		static float MapRangeUnclamped(UKismetMathLibrary* _this,float Value,float InRangeA,float InRangeB,float OutRangeA,float OutRangeB)
		{
			float ___ret = _this->MapRangeUnclamped(Value,InRangeA,InRangeB,OutRangeA,OutRangeB);
			return ___ret;
			
		}
		static float NormalizeToRange(UKismetMathLibrary* _this,float Value,float RangeMin,float RangeMax)
		{
			float ___ret = _this->NormalizeToRange(Value,RangeMin,RangeMax);
			return ___ret;
			
		}
		static float SignOfFloat(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->SignOfFloat(A);
			return ___ret;
			
		}
		static int32 FMod(UKismetMathLibrary* _this,float Dividend,float Divisor,float* Remainder)
		{
			int32 ___ret = _this->FMod(Dividend,Divisor,*Remainder);
			return ___ret;
			
		}
		static int32 FCeil(UKismetMathLibrary* _this,float A)
		{
			int32 ___ret = _this->FCeil(A);
			return ___ret;
			
		}
		static int32 FTrunc(UKismetMathLibrary* _this,float A)
		{
			int32 ___ret = _this->FTrunc(A);
			return ___ret;
			
		}
		static int32 FFloor(UKismetMathLibrary* _this,float A)
		{
			int32 ___ret = _this->FFloor(A);
			return ___ret;
			
		}
		static int32 Round(UKismetMathLibrary* _this,float A)
		{
			int32 ___ret = _this->Round(A);
			return ___ret;
			
		}
		static float Ease(UKismetMathLibrary* _this,float A,float B,float Alpha,int32 EasingFunc,float BlendExp,int32 Steps)
		{
			float ___ret = _this->Ease(A,B,Alpha,(TEnumAsByte<EEasingFunc::Type>)EasingFunc,BlendExp,Steps);
			return ___ret;
			
		}
		static float InverseLerp(UKismetMathLibrary* _this,float A,float B,float Value)
		{
			float ___ret = _this->InverseLerp(A,B,Value);
			return ___ret;
			
		}
		static float Lerp(UKismetMathLibrary* _this,float A,float B,float Alpha)
		{
			float ___ret = _this->Lerp(A,B,Alpha);
			return ___ret;
			
		}
		static void MinOfByteArray(UKismetMathLibrary* _this,MonoArray* ByteArray,int32* IndexOfMinValue,int32* MinValue)
		{
			uint8 MinValue_temp;
			_this->MinOfByteArray(MonoArrayToTArray<uint8>(ByteArray),*IndexOfMinValue,MinValue_temp);
			*MinValue=(uint8)MinValue_temp;
			
		}
		static void MaxOfByteArray(UKismetMathLibrary* _this,MonoArray* ByteArray,int32* IndexOfMaxValue,int32* MaxValue)
		{
			uint8 MaxValue_temp;
			_this->MaxOfByteArray(MonoArrayToTArray<uint8>(ByteArray),*IndexOfMaxValue,MaxValue_temp);
			*MaxValue=(uint8)MaxValue_temp;
			
		}
		static void MinOfFloatArray(UKismetMathLibrary* _this,MonoArray* FloatArray,int32* IndexOfMinValue,float* MinValue)
		{
			_this->MinOfFloatArray(MonoArrayToTArray<float>(FloatArray),*IndexOfMinValue,*MinValue);
			
		}
		static void MaxOfFloatArray(UKismetMathLibrary* _this,MonoArray* FloatArray,int32* IndexOfMaxValue,float* MaxValue)
		{
			_this->MaxOfFloatArray(MonoArrayToTArray<float>(FloatArray),*IndexOfMaxValue,*MaxValue);
			
		}
		static void MinOfIntArray(UKismetMathLibrary* _this,MonoArray* IntArray,int32* IndexOfMinValue,int32* MinValue)
		{
			_this->MinOfIntArray(MonoArrayToTArray<int32>(IntArray),*IndexOfMinValue,*MinValue);
			
		}
		static void MaxOfIntArray(UKismetMathLibrary* _this,MonoArray* IntArray,int32* IndexOfMaxValue,int32* MaxValue)
		{
			_this->MaxOfIntArray(MonoArrayToTArray<int32>(IntArray),*IndexOfMaxValue,*MaxValue);
			
		}
		static float FClamp(UKismetMathLibrary* _this,float Value,float Min,float Max)
		{
			float ___ret = _this->FClamp(Value,Min,Max);
			return ___ret;
			
		}
		static float FMax(UKismetMathLibrary* _this,float A,float B)
		{
			float ___ret = _this->FMax(A,B);
			return ___ret;
			
		}
		static float FMin(UKismetMathLibrary* _this,float A,float B)
		{
			float ___ret = _this->FMin(A,B);
			return ___ret;
			
		}
		static float ClampAngle(UKismetMathLibrary* _this,float AngleDegrees,float MinAngleDegrees,float MaxAngleDegrees)
		{
			float ___ret = _this->ClampAngle(AngleDegrees,MinAngleDegrees,MaxAngleDegrees);
			return ___ret;
			
		}
		static float DegAtan2(UKismetMathLibrary* _this,float A,float B)
		{
			float ___ret = _this->DegAtan2(A,B);
			return ___ret;
			
		}
		static float DegAtan(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->DegAtan(A);
			return ___ret;
			
		}
		static float DegTan(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->DegTan(A);
			return ___ret;
			
		}
		static float DegAcos(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->DegAcos(A);
			return ___ret;
			
		}
		static float DegCos(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->DegCos(A);
			return ___ret;
			
		}
		static float DegAsin(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->DegAsin(A);
			return ___ret;
			
		}
		static float DegSin(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->DegSin(A);
			return ___ret;
			
		}
		static float RadiansToDegrees(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->RadiansToDegrees(A);
			return ___ret;
			
		}
		static float DegreesToRadians(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->DegreesToRadians(A);
			return ___ret;
			
		}
		static float GetTAU(UKismetMathLibrary* _this)
		{
			float ___ret = _this->GetTAU();
			return ___ret;
			
		}
		static float GetPI(UKismetMathLibrary* _this)
		{
			float ___ret = _this->GetPI();
			return ___ret;
			
		}
		static float RandomFloatInRange(UKismetMathLibrary* _this,float Min,float Max)
		{
			float ___ret = _this->RandomFloatInRange(Min,Max);
			return ___ret;
			
		}
		static float RandomFloat(UKismetMathLibrary* _this)
		{
			float ___ret = _this->RandomFloat();
			return ___ret;
			
		}
		static float Square(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->Square(A);
			return ___ret;
			
		}
		static float Sqrt(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->Sqrt(A);
			return ___ret;
			
		}
		static float Loge(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->Loge(A);
			return ___ret;
			
		}
		static float Exp(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->Exp(A);
			return ___ret;
			
		}
		static float Atan2(UKismetMathLibrary* _this,float A,float B)
		{
			float ___ret = _this->Atan2(A,B);
			return ___ret;
			
		}
		static float Atan(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->Atan(A);
			return ___ret;
			
		}
		static float Tan(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->Tan(A);
			return ___ret;
			
		}
		static float Acos(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->Acos(A);
			return ___ret;
			
		}
		static float Cos(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->Cos(A);
			return ___ret;
			
		}
		static float Asin(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->Asin(A);
			return ___ret;
			
		}
		static float Sin(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->Sin(A);
			return ___ret;
			
		}
		static float Abs(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->Abs(A);
			return ___ret;
			
		}
		static float GridSnap_Float(UKismetMathLibrary* _this,float Location,float GridSize)
		{
			float ___ret = _this->GridSnap_Float(Location,GridSize);
			return ___ret;
			
		}
		static float Hypotenuse(UKismetMathLibrary* _this,float Width,float Height)
		{
			float ___ret = _this->Hypotenuse(Width,Height);
			return ___ret;
			
		}
		static int32 InRange_FloatFloat(UKismetMathLibrary* _this,float Value,float Min,float Max,int32 InclusiveMin,int32 InclusiveMax)
		{
			bool ___ret = _this->InRange_FloatFloat(Value,Min,Max,InclusiveMin>0?true:false,InclusiveMax>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 NotEqual_FloatFloat(UKismetMathLibrary* _this,float A,float B)
		{
			bool ___ret = _this->NotEqual_FloatFloat(A,B);
			return ___ret?1:0;
			
		}
		static int32 NearlyEqual_FloatFloat(UKismetMathLibrary* _this,float A,float B,float ErrorTolerance)
		{
			bool ___ret = _this->NearlyEqual_FloatFloat(A,B,ErrorTolerance);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_FloatFloat(UKismetMathLibrary* _this,float A,float B)
		{
			bool ___ret = _this->EqualEqual_FloatFloat(A,B);
			return ___ret?1:0;
			
		}
		static int32 GreaterEqual_FloatFloat(UKismetMathLibrary* _this,float A,float B)
		{
			bool ___ret = _this->GreaterEqual_FloatFloat(A,B);
			return ___ret?1:0;
			
		}
		static int32 LessEqual_FloatFloat(UKismetMathLibrary* _this,float A,float B)
		{
			bool ___ret = _this->LessEqual_FloatFloat(A,B);
			return ___ret?1:0;
			
		}
		static int32 Greater_FloatFloat(UKismetMathLibrary* _this,float A,float B)
		{
			bool ___ret = _this->Greater_FloatFloat(A,B);
			return ___ret?1:0;
			
		}
		static int32 Less_FloatFloat(UKismetMathLibrary* _this,float A,float B)
		{
			bool ___ret = _this->Less_FloatFloat(A,B);
			return ___ret?1:0;
			
		}
		static float Subtract_FloatFloat(UKismetMathLibrary* _this,float A,float B)
		{
			float ___ret = _this->Subtract_FloatFloat(A,B);
			return ___ret;
			
		}
		static float Add_FloatFloat(UKismetMathLibrary* _this,float A,float B)
		{
			float ___ret = _this->Add_FloatFloat(A,B);
			return ___ret;
			
		}
		static float Fraction(UKismetMathLibrary* _this,float A)
		{
			float ___ret = _this->Fraction(A);
			return ___ret;
			
		}
		static float Percent_FloatFloat(UKismetMathLibrary* _this,float A,float B)
		{
			float ___ret = _this->Percent_FloatFloat(A,B);
			return ___ret;
			
		}
		static float Divide_FloatFloat(UKismetMathLibrary* _this,float A,float B)
		{
			float ___ret = _this->Divide_FloatFloat(A,B);
			return ___ret;
			
		}
		static float Multiply_IntFloat(UKismetMathLibrary* _this,int32 A,float B)
		{
			float ___ret = _this->Multiply_IntFloat(A,B);
			return ___ret;
			
		}
		static float Multiply_FloatFloat(UKismetMathLibrary* _this,float A,float B)
		{
			float ___ret = _this->Multiply_FloatFloat(A,B);
			return ___ret;
			
		}
		static float MultiplyMultiply_FloatFloat(UKismetMathLibrary* _this,float Base,float Exp)
		{
			float ___ret = _this->MultiplyMultiply_FloatFloat(Base,Exp);
			return ___ret;
			
		}
		static int32 Abs_Int(UKismetMathLibrary* _this,int32 A)
		{
			int32 ___ret = _this->Abs_Int(A);
			return ___ret;
			
		}
		static int32 Clamp(UKismetMathLibrary* _this,int32 Value,int32 Min,int32 Max)
		{
			int32 ___ret = _this->Clamp(Value,Min,Max);
			return ___ret;
			
		}
		static int32 Max(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			int32 ___ret = _this->Max(A,B);
			return ___ret;
			
		}
		static int32 Min(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			int32 ___ret = _this->Min(A,B);
			return ___ret;
			
		}
		static int32 RandomIntegerInRange(UKismetMathLibrary* _this,int32 Min,int32 Max)
		{
			int32 ___ret = _this->RandomIntegerInRange(Min,Max);
			return ___ret;
			
		}
		static int32 RandomInteger(UKismetMathLibrary* _this,int32 Max)
		{
			int32 ___ret = _this->RandomInteger(Max);
			return ___ret;
			
		}
		static int32 SignOfInteger(UKismetMathLibrary* _this,int32 A)
		{
			int32 ___ret = _this->SignOfInteger(A);
			return ___ret;
			
		}
		static int32 Not_Int(UKismetMathLibrary* _this,int32 A)
		{
			int32 ___ret = _this->Not_Int(A);
			return ___ret;
			
		}
		static int32 Or_IntInt(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			int32 ___ret = _this->Or_IntInt(A,B);
			return ___ret;
			
		}
		static int32 Xor_IntInt(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			int32 ___ret = _this->Xor_IntInt(A,B);
			return ___ret;
			
		}
		static int32 And_IntInt(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			int32 ___ret = _this->And_IntInt(A,B);
			return ___ret;
			
		}
		static int32 NotEqual_IntInt(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->NotEqual_IntInt(A,B);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_IntInt(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->EqualEqual_IntInt(A,B);
			return ___ret?1:0;
			
		}
		static int32 GreaterEqual_IntInt(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->GreaterEqual_IntInt(A,B);
			return ___ret?1:0;
			
		}
		static int32 LessEqual_IntInt(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->LessEqual_IntInt(A,B);
			return ___ret?1:0;
			
		}
		static int32 Greater_IntInt(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->Greater_IntInt(A,B);
			return ___ret?1:0;
			
		}
		static int32 Less_IntInt(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->Less_IntInt(A,B);
			return ___ret?1:0;
			
		}
		static int32 Subtract_IntInt(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			int32 ___ret = _this->Subtract_IntInt(A,B);
			return ___ret;
			
		}
		static int32 Add_IntInt(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			int32 ___ret = _this->Add_IntInt(A,B);
			return ___ret;
			
		}
		static int32 Percent_IntInt(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			int32 ___ret = _this->Percent_IntInt(A,B);
			return ___ret;
			
		}
		static int32 Divide_IntInt(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			int32 ___ret = _this->Divide_IntInt(A,B);
			return ___ret;
			
		}
		static int32 Multiply_IntInt(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			int32 ___ret = _this->Multiply_IntInt(A,B);
			return ___ret;
			
		}
		static int32 NotEqual_ByteByte(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->NotEqual_ByteByte(A,B);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_ByteByte(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->EqualEqual_ByteByte(A,B);
			return ___ret?1:0;
			
		}
		static int32 GreaterEqual_ByteByte(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->GreaterEqual_ByteByte(A,B);
			return ___ret?1:0;
			
		}
		static int32 LessEqual_ByteByte(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->LessEqual_ByteByte(A,B);
			return ___ret?1:0;
			
		}
		static int32 Greater_ByteByte(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->Greater_ByteByte(A,B);
			return ___ret?1:0;
			
		}
		static int32 Less_ByteByte(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->Less_ByteByte(A,B);
			return ___ret?1:0;
			
		}
		static int32 BMax(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			uint8 ___ret = _this->BMax(A,B);
			return (uint8)___ret;
			
		}
		static int32 BMin(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			uint8 ___ret = _this->BMin(A,B);
			return (uint8)___ret;
			
		}
		static int32 Subtract_ByteByte(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			uint8 ___ret = _this->Subtract_ByteByte(A,B);
			return (uint8)___ret;
			
		}
		static int32 Add_ByteByte(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			uint8 ___ret = _this->Add_ByteByte(A,B);
			return (uint8)___ret;
			
		}
		static int32 Percent_ByteByte(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			uint8 ___ret = _this->Percent_ByteByte(A,B);
			return (uint8)___ret;
			
		}
		static int32 Divide_ByteByte(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			uint8 ___ret = _this->Divide_ByteByte(A,B);
			return (uint8)___ret;
			
		}
		static int32 Multiply_ByteByte(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			uint8 ___ret = _this->Multiply_ByteByte(A,B);
			return (uint8)___ret;
			
		}
		static int32 BooleanNOR(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->BooleanNOR(A>0?true:false,B>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 BooleanXOR(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->BooleanXOR(A>0?true:false,B>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 BooleanOR(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->BooleanOR(A>0?true:false,B>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 BooleanNAND(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->BooleanNAND(A>0?true:false,B>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 BooleanAND(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->BooleanAND(A>0?true:false,B>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 NotEqual_BoolBool(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->NotEqual_BoolBool(A>0?true:false,B>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_BoolBool(UKismetMathLibrary* _this,int32 A,int32 B)
		{
			bool ___ret = _this->EqualEqual_BoolBool(A>0?true:false,B>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 Not_PreBool(UKismetMathLibrary* _this,int32 A)
		{
			bool ___ret = _this->Not_PreBool(A>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 RandomBoolWithWeightFromStream(UKismetMathLibrary* _this,float Weight,FRandomStream* RandomStream)
		{
			bool ___ret = _this->RandomBoolWithWeightFromStream(Weight,*RandomStream);
			return ___ret?1:0;
			
		}
		static int32 RandomBoolWithWeight(UKismetMathLibrary* _this,float Weight)
		{
			bool ___ret = _this->RandomBoolWithWeight(Weight);
			return ___ret?1:0;
			
		}
		static int32 RandomBool(UKismetMathLibrary* _this)
		{
			bool ___ret = _this->RandomBool();
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return UKismetMathLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::LinePlaneIntersection_OriginNormal",(const void*)LinePlaneIntersection_OriginNormal);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::LinePlaneIntersection",(const void*)LinePlaneIntersection);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::PointsAreCoplanar",(const void*)PointsAreCoplanar);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MinimumAreaRectangle",(const void*)MinimumAreaRectangle);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::SetRandomStreamSeed",(const void*)SetRandomStreamSeed);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::SeedRandomStream",(const void*)SeedRandomStream);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::ResetRandomStream",(const void*)ResetRandomStream);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomRotatorFromStream",(const void*)RandomRotatorFromStream);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomUnitVectorFromStream",(const void*)RandomUnitVectorFromStream);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomFloatInRangeFromStream",(const void*)RandomFloatInRangeFromStream);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomFloatFromStream",(const void*)RandomFloatFromStream);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomBoolFromStream",(const void*)RandomBoolFromStream);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomIntegerInRangeFromStream",(const void*)RandomIntegerInRangeFromStream);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomIntegerFromStream",(const void*)RandomIntegerFromStream);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::CInterpTo",(const void*)CInterpTo);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RInterpTo_Constant",(const void*)RInterpTo_Constant);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RInterpTo",(const void*)RInterpTo);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Vector2DInterpTo_Constant",(const void*)Vector2DInterpTo_Constant);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Vector2DInterpTo",(const void*)Vector2DInterpTo);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::VInterpTo_Constant",(const void*)VInterpTo_Constant);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::VInterpTo",(const void*)VInterpTo);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FInterpTo_Constant",(const void*)FInterpTo_Constant);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FInterpTo",(const void*)FInterpTo);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NotEqual_Vector2DVector2D",(const void*)NotEqual_Vector2DVector2D);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::EqualEqual_Vector2DVector2D",(const void*)EqualEqual_Vector2DVector2D);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Subtract_Vector2DFloat",(const void*)Subtract_Vector2DFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Add_Vector2DFloat",(const void*)Add_Vector2DFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Divide_Vector2DFloat",(const void*)Divide_Vector2DFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Multiply_Vector2DVector2D",(const void*)Multiply_Vector2DVector2D);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Multiply_Vector2DFloat",(const void*)Multiply_Vector2DFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Subtract_Vector2DVector2D",(const void*)Subtract_Vector2DVector2D);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Add_Vector2DVector2D",(const void*)Add_Vector2DVector2D);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NearlyEqual_TransformTransform",(const void*)NearlyEqual_TransformTransform);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::EqualEqual_TransformTransform",(const void*)EqualEqual_TransformTransform);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::TInterpTo",(const void*)TInterpTo);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::TEase",(const void*)TEase);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::TLerp",(const void*)TLerp);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::InvertTransform",(const void*)InvertTransform);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::ConvertTransformToRelative",(const void*)ConvertTransformToRelative);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::ComposeTransforms",(const void*)ComposeTransforms);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::InverseTransformDirection",(const void*)InverseTransformDirection);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::InverseTransformLocation",(const void*)InverseTransformLocation);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::TransformDirection",(const void*)TransformDirection);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::TransformLocation",(const void*)TransformLocation);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NotEqual_NameName",(const void*)NotEqual_NameName);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::EqualEqual_NameName",(const void*)EqualEqual_NameName);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::ClassIsChildOf",(const void*)ClassIsChildOf);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NotEqual_ClassClass",(const void*)NotEqual_ClassClass);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::EqualEqual_ClassClass",(const void*)EqualEqual_ClassClass);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NotEqual_ObjectObject",(const void*)NotEqual_ObjectObject);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::EqualEqual_ObjectObject",(const void*)EqualEqual_ObjectObject);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_RotatorToVector",(const void*)Conv_RotatorToVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_VectorToRotator",(const void*)Conv_VectorToRotator);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeRotationFromAxes",(const void*)MakeRotationFromAxes);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::SelectClass",(const void*)SelectClass);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::SelectObject",(const void*)SelectObject);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::SelectTransform",(const void*)SelectTransform);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::SelectColor",(const void*)SelectColor);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::SelectRotator",(const void*)SelectRotator);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::SelectVector",(const void*)SelectVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::SelectFloat",(const void*)SelectFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::SelectInt",(const void*)SelectInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::SelectString",(const void*)SelectString);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RGBToHSV_Vector",(const void*)RGBToHSV_Vector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::HSVToRGB_Vector",(const void*)HSVToRGB_Vector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RGBToHSV",(const void*)RGBToHSV);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::HSVToRGB",(const void*)HSVToRGB);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BreakColor",(const void*)BreakColor);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeColor",(const void*)MakeColor);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BreakRandomStream",(const void*)BreakRandomStream);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeRandomStream",(const void*)MakeRandomStream);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BreakTransform",(const void*)BreakTransform);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeTransform",(const void*)MakeTransform);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BreakRotIntoAxes",(const void*)BreakRotIntoAxes);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BreakRotator",(const void*)BreakRotator);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeRotFromZY",(const void*)MakeRotFromZY);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeRotFromZX",(const void*)MakeRotFromZX);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeRotFromYZ",(const void*)MakeRotFromYZ);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeRotFromYX",(const void*)MakeRotFromYX);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeRotFromXZ",(const void*)MakeRotFromXZ);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeRotFromXY",(const void*)MakeRotFromXY);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeRotFromZ",(const void*)MakeRotFromZ);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeRotFromY",(const void*)MakeRotFromY);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeRotFromX",(const void*)MakeRotFromX);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FindLookAtRotation",(const void*)FindLookAtRotation);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeRotator",(const void*)MakeRotator);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetYawPitchFromVector",(const void*)GetYawPitchFromVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::CreateVectorFromYawPitch",(const void*)CreateVectorFromYawPitch);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetUpVector",(const void*)GetUpVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetRightVector",(const void*)GetRightVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetForwardVector",(const void*)GetForwardVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BreakVector2D",(const void*)BreakVector2D);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeVector2D",(const void*)MakeVector2D);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BreakVector",(const void*)BreakVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeVector",(const void*)MakeVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_FloatToLinearColor",(const void*)Conv_FloatToLinearColor);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_FloatToVector",(const void*)Conv_FloatToVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_Vector2DToVector",(const void*)Conv_Vector2DToVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_VectorToVector2D",(const void*)Conv_VectorToVector2D);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_VectorToTransform",(const void*)Conv_VectorToTransform);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_LinearColorToColor",(const void*)Conv_LinearColorToColor);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_ColorToLinearColor",(const void*)Conv_ColorToLinearColor);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_LinearColorToVector",(const void*)Conv_LinearColorToVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_VectorToLinearColor",(const void*)Conv_VectorToLinearColor);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_ByteToInt",(const void*)Conv_ByteToInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_BoolToByte",(const void*)Conv_BoolToByte);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_BoolToFloat",(const void*)Conv_BoolToFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_BoolToInt",(const void*)Conv_BoolToInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_IntToBool",(const void*)Conv_IntToBool);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_IntToByte",(const void*)Conv_IntToByte);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_IntToFloat",(const void*)Conv_IntToFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Conv_ByteToFloat",(const void*)Conv_ByteToFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::TimespanFromString",(const void*)TimespanFromString);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::TimespanZeroValue",(const void*)TimespanZeroValue);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::TimespanRatio",(const void*)TimespanRatio);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::TimespanMinValue",(const void*)TimespanMinValue);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::TimespanMaxValue",(const void*)TimespanMaxValue);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FromSeconds",(const void*)FromSeconds);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FromMinutes",(const void*)FromMinutes);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FromMilliseconds",(const void*)FromMilliseconds);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FromHours",(const void*)FromHours);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FromDays",(const void*)FromDays);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetTotalSeconds",(const void*)GetTotalSeconds);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetTotalMinutes",(const void*)GetTotalMinutes);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetTotalMilliseconds",(const void*)GetTotalMilliseconds);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetTotalHours",(const void*)GetTotalHours);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetTotalDays",(const void*)GetTotalDays);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetSeconds",(const void*)GetSeconds);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetMinutes",(const void*)GetMinutes);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetMilliseconds",(const void*)GetMilliseconds);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetHours",(const void*)GetHours);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetDuration",(const void*)GetDuration);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetDays",(const void*)GetDays);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::LessEqual_TimespanTimespan",(const void*)LessEqual_TimespanTimespan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Less_TimespanTimespan",(const void*)Less_TimespanTimespan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GreaterEqual_TimespanTimespan",(const void*)GreaterEqual_TimespanTimespan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Greater_TimespanTimespan",(const void*)Greater_TimespanTimespan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NotEqual_TimespanTimespan",(const void*)NotEqual_TimespanTimespan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::EqualEqual_TimespanTimespan",(const void*)EqualEqual_TimespanTimespan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Multiply_TimespanFloat",(const void*)Multiply_TimespanFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Subtract_TimespanTimespan",(const void*)Subtract_TimespanTimespan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Add_TimespanTimespan",(const void*)Add_TimespanTimespan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BreakTimespan",(const void*)BreakTimespan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeTimespan",(const void*)MakeTimespan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::DateTimeFromString",(const void*)DateTimeFromString);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::DateTimeFromIsoString",(const void*)DateTimeFromIsoString);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::UtcNow",(const void*)UtcNow);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Today",(const void*)Today);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Now",(const void*)Now);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::DateTimeMinValue",(const void*)DateTimeMinValue);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::DateTimeMaxValue",(const void*)DateTimeMaxValue);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::IsLeapYear",(const void*)IsLeapYear);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::DaysInYear",(const void*)DaysInYear);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::DaysInMonth",(const void*)DaysInMonth);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::IsMorning",(const void*)IsMorning);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::IsAfternoon",(const void*)IsAfternoon);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetYear",(const void*)GetYear);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetTimeOfDay",(const void*)GetTimeOfDay);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetSecond",(const void*)GetSecond);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetMonth",(const void*)GetMonth);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetMinute",(const void*)GetMinute);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetMillisecond",(const void*)GetMillisecond);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetHour12",(const void*)GetHour12);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetHour",(const void*)GetHour);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetDayOfYear",(const void*)GetDayOfYear);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetDay",(const void*)GetDay);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetDate",(const void*)GetDate);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::LessEqual_DateTimeDateTime",(const void*)LessEqual_DateTimeDateTime);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Less_DateTimeDateTime",(const void*)Less_DateTimeDateTime);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GreaterEqual_DateTimeDateTime",(const void*)GreaterEqual_DateTimeDateTime);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Greater_DateTimeDateTime",(const void*)Greater_DateTimeDateTime);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NotEqual_DateTimeDateTime",(const void*)NotEqual_DateTimeDateTime);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::EqualEqual_DateTimeDateTime",(const void*)EqualEqual_DateTimeDateTime);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Subtract_DateTimeDateTime",(const void*)Subtract_DateTimeDateTime);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Subtract_DateTimeTimespan",(const void*)Subtract_DateTimeTimespan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Add_DateTimeTimespan",(const void*)Add_DateTimeTimespan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BreakDateTime",(const void*)BreakDateTime);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakeDateTime",(const void*)MakeDateTime);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakePlaneFromPointAndNormal",(const void*)MakePlaneFromPointAndNormal);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Multiply_LinearColorFloat",(const void*)Multiply_LinearColorFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Multiply_LinearColorLinearColor",(const void*)Multiply_LinearColorLinearColor);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::LinearColorLerpUsingHSV",(const void*)LinearColorLerpUsingHSV);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::LinearColorLerp",(const void*)LinearColorLerp);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NormalizeAxis",(const void*)NormalizeAxis);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::ClampAxis",(const void*)ClampAxis);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RotatorFromAxisAndAngle",(const void*)RotatorFromAxisAndAngle);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NormalizedDeltaRotator",(const void*)NormalizedDeltaRotator);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::REase",(const void*)REase);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RLerp",(const void*)RLerp);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomRotator",(const void*)RandomRotator);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetAxes",(const void*)GetAxes);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NegateRotator",(const void*)NegateRotator);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::ComposeRotators",(const void*)ComposeRotators);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Multiply_RotatorInt",(const void*)Multiply_RotatorInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Multiply_RotatorFloat",(const void*)Multiply_RotatorFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NotEqual_RotatorRotator",(const void*)NotEqual_RotatorRotator);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::EqualEqual_RotatorRotator",(const void*)EqualEqual_RotatorRotator);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetDirectionVector",(const void*)GetDirectionVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetVectorArrayAverage",(const void*)GetVectorArrayAverage);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetMaxElement",(const void*)GetMaxElement);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetMinElement",(const void*)GetMinElement);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::ClampVectorSize",(const void*)ClampVectorSize);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NegateVector",(const void*)NegateVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::ProjectVectorOnToPlane",(const void*)ProjectVectorOnToPlane);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::ProjectPointOnToPlane",(const void*)ProjectPointOnToPlane);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetPointDistanceToLine",(const void*)GetPointDistanceToLine);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetPointDistanceToSegment",(const void*)GetPointDistanceToSegment);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FindClosestPointOnLine",(const void*)FindClosestPointOnLine);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FindClosestPointOnSegment",(const void*)FindClosestPointOnSegment);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FindNearestPointsOnLineSegments",(const void*)FindNearestPointsOnLineSegments);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::ProjectVectorOnToVector",(const void*)ProjectVectorOnToVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MirrorVectorByNormal",(const void*)MirrorVectorByNormal);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomUnitVectorInConeWithYawAndPitch",(const void*)RandomUnitVectorInConeWithYawAndPitch);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomUnitVectorInCone",(const void*)RandomUnitVectorInCone);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomPointInBoundingBox",(const void*)RandomPointInBoundingBox);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomUnitVector",(const void*)RandomUnitVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::VEase",(const void*)VEase);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::VLerp",(const void*)VLerp);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Normal2D",(const void*)Normal2D);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Normal",(const void*)Normal);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::VSize2DSquared",(const void*)VSize2DSquared);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::VSizeSquared",(const void*)VSizeSquared);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::VSize2D",(const void*)VSize2D);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::VSize",(const void*)VSize);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::CrossProduct2D",(const void*)CrossProduct2D);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::DotProduct2D",(const void*)DotProduct2D);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Cross_VectorVector",(const void*)Cross_VectorVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Dot_VectorVector",(const void*)Dot_VectorVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NotEqual_VectorVector",(const void*)NotEqual_VectorVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::EqualEqual_VectorVector",(const void*)EqualEqual_VectorVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RotateAngleAxis",(const void*)RotateAngleAxis);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GreaterGreater_VectorRotator",(const void*)GreaterGreater_VectorRotator);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::LessLess_VectorRotator",(const void*)LessLess_VectorRotator);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Subtract_VectorInt",(const void*)Subtract_VectorInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Subtract_VectorFloat",(const void*)Subtract_VectorFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Subtract_VectorVector",(const void*)Subtract_VectorVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Add_VectorInt",(const void*)Add_VectorInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Add_VectorFloat",(const void*)Add_VectorFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Add_VectorVector",(const void*)Add_VectorVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Divide_VectorVector",(const void*)Divide_VectorVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Divide_VectorInt",(const void*)Divide_VectorInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Divide_VectorFloat",(const void*)Divide_VectorFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Multiply_VectorVector",(const void*)Multiply_VectorVector);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Multiply_VectorInt",(const void*)Multiply_VectorInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Multiply_VectorFloat",(const void*)Multiply_VectorFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FixedTurn",(const void*)FixedTurn);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MakePulsatingValue",(const void*)MakePulsatingValue);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FInterpEaseInOut",(const void*)FInterpEaseInOut);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MultiplyByPi",(const void*)MultiplyByPi);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MapRangeClamped",(const void*)MapRangeClamped);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MapRangeUnclamped",(const void*)MapRangeUnclamped);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NormalizeToRange",(const void*)NormalizeToRange);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::SignOfFloat",(const void*)SignOfFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FMod",(const void*)FMod);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FCeil",(const void*)FCeil);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FTrunc",(const void*)FTrunc);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FFloor",(const void*)FFloor);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Round",(const void*)Round);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Ease",(const void*)Ease);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::InverseLerp",(const void*)InverseLerp);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Lerp",(const void*)Lerp);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MinOfByteArray",(const void*)MinOfByteArray);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MaxOfByteArray",(const void*)MaxOfByteArray);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MinOfFloatArray",(const void*)MinOfFloatArray);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MaxOfFloatArray",(const void*)MaxOfFloatArray);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MinOfIntArray",(const void*)MinOfIntArray);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MaxOfIntArray",(const void*)MaxOfIntArray);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FClamp",(const void*)FClamp);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FMax",(const void*)FMax);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::FMin",(const void*)FMin);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::ClampAngle",(const void*)ClampAngle);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::DegAtan2",(const void*)DegAtan2);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::DegAtan",(const void*)DegAtan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::DegTan",(const void*)DegTan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::DegAcos",(const void*)DegAcos);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::DegCos",(const void*)DegCos);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::DegAsin",(const void*)DegAsin);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::DegSin",(const void*)DegSin);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RadiansToDegrees",(const void*)RadiansToDegrees);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::DegreesToRadians",(const void*)DegreesToRadians);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetTAU",(const void*)GetTAU);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GetPI",(const void*)GetPI);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomFloatInRange",(const void*)RandomFloatInRange);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomFloat",(const void*)RandomFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Square",(const void*)Square);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Sqrt",(const void*)Sqrt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Loge",(const void*)Loge);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Exp",(const void*)Exp);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Atan2",(const void*)Atan2);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Atan",(const void*)Atan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Tan",(const void*)Tan);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Acos",(const void*)Acos);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Cos",(const void*)Cos);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Asin",(const void*)Asin);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Sin",(const void*)Sin);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Abs",(const void*)Abs);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GridSnap_Float",(const void*)GridSnap_Float);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Hypotenuse",(const void*)Hypotenuse);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::InRange_FloatFloat",(const void*)InRange_FloatFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NotEqual_FloatFloat",(const void*)NotEqual_FloatFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NearlyEqual_FloatFloat",(const void*)NearlyEqual_FloatFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::EqualEqual_FloatFloat",(const void*)EqualEqual_FloatFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GreaterEqual_FloatFloat",(const void*)GreaterEqual_FloatFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::LessEqual_FloatFloat",(const void*)LessEqual_FloatFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Greater_FloatFloat",(const void*)Greater_FloatFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Less_FloatFloat",(const void*)Less_FloatFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Subtract_FloatFloat",(const void*)Subtract_FloatFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Add_FloatFloat",(const void*)Add_FloatFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Fraction",(const void*)Fraction);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Percent_FloatFloat",(const void*)Percent_FloatFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Divide_FloatFloat",(const void*)Divide_FloatFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Multiply_IntFloat",(const void*)Multiply_IntFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Multiply_FloatFloat",(const void*)Multiply_FloatFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::MultiplyMultiply_FloatFloat",(const void*)MultiplyMultiply_FloatFloat);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Abs_Int",(const void*)Abs_Int);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Clamp",(const void*)Clamp);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Max",(const void*)Max);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Min",(const void*)Min);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomIntegerInRange",(const void*)RandomIntegerInRange);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomInteger",(const void*)RandomInteger);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::SignOfInteger",(const void*)SignOfInteger);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Not_Int",(const void*)Not_Int);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Or_IntInt",(const void*)Or_IntInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Xor_IntInt",(const void*)Xor_IntInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::And_IntInt",(const void*)And_IntInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NotEqual_IntInt",(const void*)NotEqual_IntInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::EqualEqual_IntInt",(const void*)EqualEqual_IntInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GreaterEqual_IntInt",(const void*)GreaterEqual_IntInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::LessEqual_IntInt",(const void*)LessEqual_IntInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Greater_IntInt",(const void*)Greater_IntInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Less_IntInt",(const void*)Less_IntInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Subtract_IntInt",(const void*)Subtract_IntInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Add_IntInt",(const void*)Add_IntInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Percent_IntInt",(const void*)Percent_IntInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Divide_IntInt",(const void*)Divide_IntInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Multiply_IntInt",(const void*)Multiply_IntInt);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NotEqual_ByteByte",(const void*)NotEqual_ByteByte);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::EqualEqual_ByteByte",(const void*)EqualEqual_ByteByte);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::GreaterEqual_ByteByte",(const void*)GreaterEqual_ByteByte);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::LessEqual_ByteByte",(const void*)LessEqual_ByteByte);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Greater_ByteByte",(const void*)Greater_ByteByte);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Less_ByteByte",(const void*)Less_ByteByte);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BMax",(const void*)BMax);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BMin",(const void*)BMin);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Subtract_ByteByte",(const void*)Subtract_ByteByte);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Add_ByteByte",(const void*)Add_ByteByte);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Percent_ByteByte",(const void*)Percent_ByteByte);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Divide_ByteByte",(const void*)Divide_ByteByte);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Multiply_ByteByte",(const void*)Multiply_ByteByte);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BooleanNOR",(const void*)BooleanNOR);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BooleanXOR",(const void*)BooleanXOR);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BooleanOR",(const void*)BooleanOR);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BooleanNAND",(const void*)BooleanNAND);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::BooleanAND",(const void*)BooleanAND);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::NotEqual_BoolBool",(const void*)NotEqual_BoolBool);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::EqualEqual_BoolBool",(const void*)EqualEqual_BoolBool);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::Not_PreBool",(const void*)Not_PreBool);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomBoolWithWeightFromStream",(const void*)RandomBoolWithWeightFromStream);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomBoolWithWeight",(const void*)RandomBoolWithWeight);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::RandomBool",(const void*)RandomBool);
			mono_add_internal_call("UnrealEngine.UKismetMathLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
