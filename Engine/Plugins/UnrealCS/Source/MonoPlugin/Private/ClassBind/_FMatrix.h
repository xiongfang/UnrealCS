// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

namespace UnrealEngine
{
	class _FMatrix
	{
		static FMatrix Multiply(FMatrix* This, FMatrix* Other)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis,This);
			FMatrix TempOther;
			CopyStruct(&TempOther,Other);
			return TempThis * TempOther;
		}
		static FVector4 TransformFVector4(FMatrix* This,FVector4* V)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			FVector4 TempV;
			CopyStruct(&TempV,V);
			return TempThis.TransformFVector4(TempV);
		}
		static FMatrix InverseFast(FMatrix* This)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			return TempThis.InverseFast();
		}
		static FMatrix Inverse(FMatrix* This)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			return TempThis.Inverse();
		}
		static FMatrix TransposeAdjoint(FMatrix* This)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			return TempThis.TransposeAdjoint();
		}
		static void RemoveScaling(FMatrix* This, float Tolerance)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			TempThis.RemoveScaling(Tolerance);
			CopyStruct(This, &TempThis);
		}
		static FVector ExtractScaling(FMatrix* This, float Tolerance)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			return TempThis.ExtractScaling(Tolerance);
		}
		static FMatrix ConcatTranslation(FMatrix* This, FVector* Translation)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			return TempThis.ConcatTranslation(*Translation);
		}
		static  FMatrix ApplyScale(FMatrix* This, float Scale)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			return TempThis.ApplyScale(Scale);
		}

		static  FRotator Rotator(FMatrix* This)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			return TempThis.Rotator();
		}

		static  bool GetFrustumNearPlane(FMatrix* This,FPlane* OutPlane)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			FPlane TempPlane;
			bool ___ret = TempThis.GetFrustumNearPlane(TempPlane);
			CopyStruct(OutPlane, &TempPlane);
			return ___ret;
		}
		static  bool GetFrustumFarPlane(FMatrix* This, FPlane* OutPlane)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			FPlane TempPlane;
			bool ___ret = TempThis.GetFrustumFarPlane(TempPlane);
			CopyStruct(OutPlane, &TempPlane);
			return ___ret;
		}
		static  bool GetFrustumLeftPlane(FMatrix* This, FPlane* OutPlane)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			FPlane TempPlane;
			bool ___ret = TempThis.GetFrustumLeftPlane(TempPlane);
			CopyStruct(OutPlane, &TempPlane);
			return ___ret;
		}
		static  bool GetFrustumRightPlane(FMatrix* This, FPlane* OutPlane)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			FPlane TempPlane;
			bool ___ret = TempThis.GetFrustumRightPlane(TempPlane);
			CopyStruct(OutPlane, &TempPlane);
			return ___ret;
		}
		static  bool GetFrustumTopPlane(FMatrix* This, FPlane* OutPlane)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			FPlane TempPlane;
			bool ___ret = TempThis.GetFrustumTopPlane(TempPlane);
			CopyStruct(OutPlane, &TempPlane);
			return ___ret;
		}
		static  bool GetFrustumBottomPlane(FMatrix* This, FPlane* OutPlane)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			FPlane TempPlane;
			bool ___ret = TempThis.GetFrustumBottomPlane(TempPlane);
			CopyStruct(OutPlane, &TempPlane);
			return ___ret;
		}
		static  void Mirror(FMatrix* This, int32 MirrorAxis, int32 FlipAxis)
		{
			FMatrix TempThis;
			CopyStruct(&TempThis, This);
			TempThis.Mirror((EAxis::Type)MirrorAxis, (EAxis::Type)FlipAxis);
			CopyStruct(This, &TempThis);
		}
	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.FMatrix::Multiply", (const void*)Multiply);
			mono_add_internal_call("UnrealEngine.FMatrix::TransformFVector4", (const void*)TransformFVector4);
			mono_add_internal_call("UnrealEngine.FMatrix::InverseFast", (const void*)InverseFast);
			mono_add_internal_call("UnrealEngine.FMatrix::Inverse", (const void*)Inverse);
			mono_add_internal_call("UnrealEngine.FMatrix::TransposeAdjoint", (const void*)TransposeAdjoint);
			mono_add_internal_call("UnrealEngine.FMatrix::RemoveScaling", (const void*)RemoveScaling);
			mono_add_internal_call("UnrealEngine.FMatrix::ExtractScaling", (const void*)ExtractScaling);
			mono_add_internal_call("UnrealEngine.FMatrix::ConcatTranslation", (const void*)ConcatTranslation);
			mono_add_internal_call("UnrealEngine.FMatrix::ApplyScale", (const void*)ApplyScale);
			mono_add_internal_call("UnrealEngine.FMatrix::Rotator", (const void*)Rotator);
			mono_add_internal_call("UnrealEngine.FMatrix::GetFrustumNearPlane", (const void*)GetFrustumNearPlane);
			mono_add_internal_call("UnrealEngine.FMatrix::GetFrustumFarPlane", (const void*)GetFrustumFarPlane);
			mono_add_internal_call("UnrealEngine.FMatrix::GetFrustumLeftPlane", (const void*)GetFrustumLeftPlane);
			mono_add_internal_call("UnrealEngine.FMatrix::GetFrustumRightPlane", (const void*)GetFrustumRightPlane);
			mono_add_internal_call("UnrealEngine.FMatrix::GetFrustumTopPlane", (const void*)GetFrustumTopPlane);
			mono_add_internal_call("UnrealEngine.FMatrix::GetFrustumBottomPlane", (const void*)GetFrustumBottomPlane);
			mono_add_internal_call("UnrealEngine.FMatrix::Mirror", (const void*)Mirror);
		}
	};
}