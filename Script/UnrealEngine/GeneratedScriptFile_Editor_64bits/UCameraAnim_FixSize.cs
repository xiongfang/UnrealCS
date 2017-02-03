#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A predefined animation to be played on a camera</summary>
	public partial class UCameraAnim
	{
		static readonly int CameraInterpGroup__Offset;
		/// <summary>The UInterpGroup that holds our actual interpolation data.</summary>
		public UInterpGroup CameraInterpGroup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CameraInterpGroup__Offset); if (v == IntPtr.Zero)return null; UInterpGroup retValue = new UInterpGroup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PreviewInterpGroup__Offset;
		/// <summary>This is to preview and they only exists in editor</summary>
		public UInterpGroup PreviewInterpGroup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewInterpGroup__Offset); if (v == IntPtr.Zero)return null; UInterpGroup retValue = new UInterpGroup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AnimLength__Offset;
		/// <summary>Length, in seconds.</summary>
		public float AnimLength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnimLength__Offset, typeof(float));}
			
		}
		
		static readonly int BoundingBox__Offset;
		/// <summary>AABB in local space.</summary>
		public FBox BoundingBox
		{
			get{ CheckIsValid();return (FBox)Marshal.PtrToStructure(_this.Get()+BoundingBox__Offset, typeof(FBox));}
			
		}
		
		static readonly int bRelativeToInitialTransform__Offset;
		/// <summary>
		/// If true, assume all transform keys are intended be offsets from the start of the animation. This allows the animation to be authored at any world location and be applied as a delta to the camera.
		/// If false, assume all transform keys are authored relative to the world origin. Positions will be directly applied as deltas to the camera.
		/// </summary>
		public bool bRelativeToInitialTransform
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRelativeToInitialTransform__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRelativeToInitialTransform__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bRelativeToInitialFOV__Offset;
		/// <summary>
		/// If true, assume all FOV keys are intended be offsets from the start of the animation.
		/// If false, assume all FOV keys are authored relative to the current FOV of the camera at the start of the animation.
		/// </summary>
		public bool bRelativeToInitialFOV
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRelativeToInitialFOV__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRelativeToInitialFOV__Offset, 1,0,2,2);}
			
		}
		
		static readonly int BaseFOV__Offset;
		/// <summary>The base FOV that all FOV keys are relative to.</summary>
		public float BaseFOV
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BaseFOV__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BaseFOV__Offset, false);}
			
		}
		
		static readonly int BasePostProcessSettings__Offset;
		/// <summary>Default PP settings to put on the animated camera. For modifying PP without keyframes.</summary>
		public FPostProcessSettings BasePostProcessSettings
		{
			get{ CheckIsValid();return (FPostProcessSettings)Marshal.PtrToStructure(_this.Get()+BasePostProcessSettings__Offset, typeof(FPostProcessSettings));}
			
		}
		
		static readonly int BasePostProcessBlendWeight__Offset;
		/// <summary>Default PP blend weight to put on the animated camera. For modifying PP without keyframes.</summary>
		public float BasePostProcessBlendWeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BasePostProcessBlendWeight__Offset, typeof(float));}
			
		}
		
		static UCameraAnim()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CameraAnim");
			CameraInterpGroup__Offset=GetPropertyOffset(NativeClassPtr,"CameraInterpGroup");
			PreviewInterpGroup__Offset=GetPropertyOffset(NativeClassPtr,"PreviewInterpGroup");
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
