// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

namespace UnrealEngine
{
	class _FTransform
	{
		static FMatrix ToMatrixWithScale(FTransform* This)
		{
			return This->ToMatrixWithScale();
		}
		static FMatrix ToMatrixNoScale(FTransform* This)
		{
			return This->ToMatrixNoScale();
		}
		static void Blend(FTransform* This,FTransform* Atom1,FTransform* Atom2, float Alpha)
		{
			This->Blend(*Atom1, *Atom2, Alpha);
		}
		static void BlendWith(FTransform* This,FTransform* OtherAtom, float Alpha)
		{
			This->BlendWith(*OtherAtom, Alpha);
		}
		static FTransform GetRelativeTransform(FTransform* This,FTransform* Other)
		{
			return This->GetRelativeTransform(*Other);
		}
		static FTransform GetRelativeTransformReverse(FTransform* This, FTransform* Other)
		{
			return This->GetRelativeTransformReverse(*Other);
		}
		static void SetToRelativeTransform(FTransform* This, FTransform* ParentTransform)
		{
			This->SetToRelativeTransform(*ParentTransform);
		}
		static FVector4 TransformFVector4(FTransform* This, FVector4* V)
		{
			FVector4 TempV;
			CopyStruct(&TempV, V);
			return This->TransformFVector4(TempV);
		}
		static FVector4 TransformFVector4NoScale(FTransform* This, FVector4* V)
		{
			FVector4 TempV;
			CopyStruct(&TempV, V);
			return This->TransformFVector4NoScale(TempV);
		}
		static void Multiply(FTransform* OutTransform,FTransform* A,FTransform* B)
		{
			FTransform::Multiply(OutTransform, A, B);
		}
	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.FTransform::ToMatrixWithScale", (const void*)ToMatrixWithScale);
			mono_add_internal_call("UnrealEngine.FTransform::ToMatrixNoScale", (const void*)ToMatrixNoScale);
			mono_add_internal_call("UnrealEngine.FTransform::Blend", (const void*)Blend);
			mono_add_internal_call("UnrealEngine.FTransform::BlendWith", (const void*)BlendWith);
			mono_add_internal_call("UnrealEngine.FTransform::GetRelativeTransform", (const void*)GetRelativeTransform);
			mono_add_internal_call("UnrealEngine.FTransform::GetRelativeTransformReverse", (const void*)GetRelativeTransformReverse);
			mono_add_internal_call("UnrealEngine.FTransform::SetToRelativeTransform", (const void*)SetToRelativeTransform);
			mono_add_internal_call("UnrealEngine.FTransform::TransformFVector4", (const void*)TransformFVector4);
			mono_add_internal_call("UnrealEngine.FTransform::TransformFVector4NoScale", (const void*)TransformFVector4NoScale);
			mono_add_internal_call("UnrealEngine.FTransform::Multiply", (const void*)Multiply);
		}
	};
}