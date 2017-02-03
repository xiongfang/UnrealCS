#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCameraComponent
	{
		static readonly int FieldOfView__Offset;
		public float FieldOfView
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FieldOfView__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FieldOfView__Offset, false);}
			
		}
		
		static readonly int OrthoWidth__Offset;
		public float OrthoWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OrthoWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OrthoWidth__Offset, false);}
			
		}
		
		static readonly int OrthoNearClipPlane__Offset;
		public float OrthoNearClipPlane
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OrthoNearClipPlane__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OrthoNearClipPlane__Offset, false);}
			
		}
		
		static readonly int OrthoFarClipPlane__Offset;
		public float OrthoFarClipPlane
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OrthoFarClipPlane__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OrthoFarClipPlane__Offset, false);}
			
		}
		
		static readonly int AspectRatio__Offset;
		public float AspectRatio
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AspectRatio__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AspectRatio__Offset, false);}
			
		}
		
		static readonly int bConstrainAspectRatio__Offset;
		public bool bConstrainAspectRatio
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bConstrainAspectRatio__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bConstrainAspectRatio__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUseFieldOfViewForLOD__Offset;
		public bool bUseFieldOfViewForLOD
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseFieldOfViewForLOD__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseFieldOfViewForLOD__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bLockToHmd__Offset;
		public bool bLockToHmd
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockToHmd__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLockToHmd__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bUsePawnControlRotation__Offset;
		public bool bUsePawnControlRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsePawnControlRotation__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsePawnControlRotation__Offset, 1,0,8,8);}
			
		}
		
		static readonly int ProjectionMode__Offset;
		public ECameraProjectionMode ProjectionMode
		{
			get{ CheckIsValid();return (ECameraProjectionMode)Marshal.PtrToStructure(_this.Get()+ProjectionMode__Offset, typeof(ECameraProjectionMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ProjectionMode__Offset, false);}
			
		}
		
		static readonly int PostProcessBlendWeight__Offset;
		public float PostProcessBlendWeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PostProcessBlendWeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PostProcessBlendWeight__Offset, false);}
			
		}
		
		static readonly int PostProcessSettings__Offset;
		public FPostProcessSettings PostProcessSettings
		{
			get{ CheckIsValid();return (FPostProcessSettings)Marshal.PtrToStructure(_this.Get()+PostProcessSettings__Offset, typeof(FPostProcessSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PostProcessSettings__Offset, false);}
			
		}
		
		static readonly int bUseControllerViewRotation__Offset;
		public bool bUseControllerViewRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseControllerViewRotation__Offset, 1, 0, 1, 1);}
			
		}
		
		static UCameraComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CameraComponent");
			FieldOfView__Offset=GetPropertyOffset(NativeClassPtr,"FieldOfView");
			OrthoWidth__Offset=GetPropertyOffset(NativeClassPtr,"OrthoWidth");
			OrthoNearClipPlane__Offset=GetPropertyOffset(NativeClassPtr,"OrthoNearClipPlane");
			OrthoFarClipPlane__Offset=GetPropertyOffset(NativeClassPtr,"OrthoFarClipPlane");
			AspectRatio__Offset=GetPropertyOffset(NativeClassPtr,"AspectRatio");
			bConstrainAspectRatio__Offset=GetPropertyOffset(NativeClassPtr,"bConstrainAspectRatio");
			bUseFieldOfViewForLOD__Offset=GetPropertyOffset(NativeClassPtr,"bUseFieldOfViewForLOD");
			bLockToHmd__Offset=GetPropertyOffset(NativeClassPtr,"bLockToHmd");
			bUsePawnControlRotation__Offset=GetPropertyOffset(NativeClassPtr,"bUsePawnControlRotation");
			ProjectionMode__Offset=GetPropertyOffset(NativeClassPtr,"ProjectionMode");
			PostProcessBlendWeight__Offset=GetPropertyOffset(NativeClassPtr,"PostProcessBlendWeight");
			PostProcessSettings__Offset=GetPropertyOffset(NativeClassPtr,"PostProcessSettings");
			bUseControllerViewRotation__Offset=GetPropertyOffset(NativeClassPtr,"bUseControllerViewRotation");
			
		}
		
	}
	
}
#endif
#endif
