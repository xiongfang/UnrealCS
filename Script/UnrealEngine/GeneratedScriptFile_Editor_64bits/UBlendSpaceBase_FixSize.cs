#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Allows multiple animations to be blended between based on input parameters</summary>
	public partial class UBlendSpaceBase
	{
		static readonly int bRotationBlendInMeshSpace__Offset;
		/// <summary>
		/// When you use blend per bone, allows rotation to blend in mesh space. This only works if this does not contain additive animation samples
		/// This is more performance intensive
		/// </summary>
		public bool bRotationBlendInMeshSpace
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRotationBlendInMeshSpace__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int PreviewBasePose__Offset;
		/// <summary>Preview Base pose for additive BlendSpace *</summary>
		public UAnimSequence PreviewBasePose
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewBasePose__Offset); if (v == IntPtr.Zero)return null; UAnimSequence retValue = new UAnimSequence(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PreviewBasePose__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PreviewBasePose__Offset, value._this.Get()); }
			
		}
		
		static readonly int AnimLength__Offset;
		/// <summary>This animation length changes based on current input (resulting in different blend time)*</summary>
		public float AnimLength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnimLength__Offset, typeof(float));}
			
		}
		
		static readonly int PerBoneBlend__Offset;
		/// <summary>Define target weight interpolation per bone. This will blend in different speed per each bone setting</summary>
		public TStructArray<FPerBoneInterpolation> PerBoneBlend
		{
			get{ CheckIsValid();return new TStructArray<FPerBoneInterpolation>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PerBoneBlend__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PerBoneBlend__Offset, false);}
			
		}
		
		static readonly int InterpolationParam__Offset;
		/// <summary>Input interpolation parameter for all 3 axis, for each axis input, decide how you'd like to interpolate input to</summary>
		public FInterpolationParameter InterpolationParam
		{
			get{ CheckIsValid();return (FInterpolationParameter)Marshal.PtrToStructure(_this.Get()+InterpolationParam__Offset, typeof(FInterpolationParameter));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InterpolationParam__Offset, false);}
			
		}
		
		static readonly int TargetWeightInterpolationSpeedPerSec__Offset;
		/// <summary>
		/// Target weight interpolation. When target samples are set, how fast you'd like to get to target. Improve target blending.
		/// i.e. for locomotion, if you interpolate input, when you move from left to right rapidly, you'll interpolate through forward, but if you use target weight interpolation,
		/// you'll skip forward, but interpolate between left to right
		/// </summary>
		public float TargetWeightInterpolationSpeedPerSec
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TargetWeightInterpolationSpeedPerSec__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetWeightInterpolationSpeedPerSec__Offset, false);}
			
		}
		
		static readonly int NotifyTriggerMode__Offset;
		/// <summary>
		/// The current mode used by the blendspace to decide which animation notifies to fire. Valid options are:
		///       - AllAnimations - All notify events will fire
		///       - HighestWeightedAnimation - Notify events will only fire from the highest weighted animation
		///       - None - No notify events will fire from any animations
		/// </summary>
		public ENotifyTriggerMode NotifyTriggerMode
		{
			get{ CheckIsValid();return (ENotifyTriggerMode)Marshal.PtrToStructure(_this.Get()+NotifyTriggerMode__Offset, typeof(ENotifyTriggerMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NotifyTriggerMode__Offset, false);}
			
		}
		
		static readonly int SampleIndexWithMarkers__Offset;
		/// <summary>
		/// Track index to get marker data from. Samples are tested for the suitability of marker based sync
		///           during load and if we can use marker based sync we cache an index to a representative sample here
		/// </summary>
		public int SampleIndexWithMarkers
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SampleIndexWithMarkers__Offset, typeof(int));}
			
		}
		
		static readonly int SampleData__Offset;
		/// <summary>Sample animation data *</summary>
		public TStructArray<FBlendSample> SampleData
		{
			get{ CheckIsValid();return new TStructArray<FBlendSample>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SampleData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SampleData__Offset, false);}
			
		}
		
		static readonly int GridSamples__Offset;
		/// <summary>Grid samples, indexing scheme imposed by subclass *</summary>
		public TStructArray<FEditorElement> GridSamples
		{
			get{ CheckIsValid();return new TStructArray<FEditorElement>((FScriptArray)Marshal.PtrToStructure(_this.Get()+GridSamples__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+GridSamples__Offset, false);}
			
		}
		
		static readonly int BlendParameters__Offset;
		/// <summary>Blend Parameters for each axis. *</summary>
		public FBlendParameter BlendParameters
		{
			get{ CheckIsValid();return (FBlendParameter)Marshal.PtrToStructure(_this.Get()+BlendParameters__Offset, typeof(FBlendParameter));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendParameters__Offset, false);}
			
		}
		
		static UBlendSpaceBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BlendSpaceBase");
			bRotationBlendInMeshSpace__Offset=GetPropertyOffset(NativeClassPtr,"bRotationBlendInMeshSpace");
			PreviewBasePose__Offset=GetPropertyOffset(NativeClassPtr,"PreviewBasePose");
			AnimLength__Offset=GetPropertyOffset(NativeClassPtr,"AnimLength");
			PerBoneBlend__Offset=GetPropertyOffset(NativeClassPtr,"PerBoneBlend");
			InterpolationParam__Offset=GetPropertyOffset(NativeClassPtr,"InterpolationParam");
			TargetWeightInterpolationSpeedPerSec__Offset=GetPropertyOffset(NativeClassPtr,"TargetWeightInterpolationSpeedPerSec");
			NotifyTriggerMode__Offset=GetPropertyOffset(NativeClassPtr,"NotifyTriggerMode");
			SampleIndexWithMarkers__Offset=GetPropertyOffset(NativeClassPtr,"SampleIndexWithMarkers");
			SampleData__Offset=GetPropertyOffset(NativeClassPtr,"SampleData");
			GridSamples__Offset=GetPropertyOffset(NativeClassPtr,"GridSamples");
			BlendParameters__Offset=GetPropertyOffset(NativeClassPtr,"BlendParameters");
			
		}
		
	}
	
}
#endif
#endif
