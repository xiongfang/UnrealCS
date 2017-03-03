#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCameraAnim
	{
		static readonly int CameraInterpGroup__Offset;
		public UInterpGroup CameraInterpGroup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CameraInterpGroup__Offset); if (v == IntPtr.Zero)return null; UInterpGroup retValue = new UInterpGroup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AnimLength__Offset;
		public float AnimLength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnimLength__Offset, typeof(float));}
			
		}
		
		static readonly int BoundingBox__Offset;
		public FBox BoundingBox
		{
			get{ CheckIsValid();return (FBox)Marshal.PtrToStructure(_this.Get()+BoundingBox__Offset, typeof(FBox));}
			
		}
		
		static readonly int bRelativeToInitialTransform__Offset;
		public bool bRelativeToInitialTransform
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRelativeToInitialTransform__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRelativeToInitialTransform__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bRelativeToInitialFOV__Offset;
		public bool bRelativeToInitialFOV
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRelativeToInitialFOV__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRelativeToInitialFOV__Offset, 1,0,2,2);}
			
		}
		
		static readonly int BaseFOV__Offset;
		public float BaseFOV
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BaseFOV__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BaseFOV__Offset, false);}
			
		}
		
		static readonly int BasePostProcessSettings__Offset;
		public FPostProcessSettings BasePostProcessSettings
		{
			get{ CheckIsValid();return (FPostProcessSettings)Marshal.PtrToStructure(_this.Get()+BasePostProcessSettings__Offset, typeof(FPostProcessSettings));}
			
		}
		
		static readonly int BasePostProcessBlendWeight__Offset;
		public float BasePostProcessBlendWeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BasePostProcessBlendWeight__Offset, typeof(float));}
			
		}
		
		static UCameraAnim()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CameraAnim");
			CameraInterpGroup__Offset=GetPropertyOffset(NativeClassPtr,"CameraInterpGroup");
			AnimLength__Offset=GetPropertyOffset(NativeClassPtr,"AnimLength");
			BoundingBox__Offset=GetPropertyOffset(NativeClassPtr,"BoundingBox");
			bRelativeToInitialTransform__Offset=GetPropertyOffset(NativeClassPtr,"bRelativeToInitialTransform");
			bRelativeToInitialFOV__Offset=GetPropertyOffset(NativeClassPtr,"bRelativeToInitialFOV");
			BaseFOV__Offset=GetPropertyOffset(NativeClassPtr,"BaseFOV");
			BasePostProcessSettings__Offset=GetPropertyOffset(NativeClassPtr,"BasePostProcessSettings");
			BasePostProcessBlendWeight__Offset=GetPropertyOffset(NativeClassPtr,"BasePostProcessBlendWeight");
			
		}
		
	}
	
}
#endif
#endif
