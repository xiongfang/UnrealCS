#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>* Pose Asset that can be blended by weight of curves</summary>
	public partial class UPoseAsset
	{
		static readonly int PoseContainer__Offset;
		/// <summary>Animation Pose Data</summary>
		public FPoseDataContainer PoseContainer
		{
			get{ CheckIsValid();return (FPoseDataContainer)Marshal.PtrToStructure(_this.Get()+PoseContainer__Offset, typeof(FPoseDataContainer));}
			
		}
		
		static readonly int bAdditivePose__Offset;
		/// <summary>Whether or not Additive Pose or not - these are property that needs post process, so</summary>
		public bool bAdditivePose
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAdditivePose__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int BasePoseIndex__Offset;
		/// <summary>if -1, use ref pose</summary>
		public int BasePoseIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+BasePoseIndex__Offset, typeof(int));}
			
		}
		
		static readonly int RetargetSource__Offset;
		/// <summary>Base pose to use when retargeting</summary>
		public FName RetargetSource
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+RetargetSource__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RetargetSource__Offset, false);}
			
		}
		
		static readonly int SourceAnimation__Offset;
		public UAnimSequence SourceAnimation
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SourceAnimation__Offset); if (v == IntPtr.Zero)return null; UAnimSequence retValue = new UAnimSequence(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SourceAnimation__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SourceAnimation__Offset, value._this.Get()); }
			
		}
		
		static UPoseAsset()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PoseAsset");
			PoseContainer__Offset=GetPropertyOffset(NativeClassPtr,"PoseContainer");
			bAdditivePose__Offset=GetPropertyOffset(NativeClassPtr,"bAdditivePose");
			BasePoseIndex__Offset=GetPropertyOffset(NativeClassPtr,"BasePoseIndex");
			RetargetSource__Offset=GetPropertyOffset(NativeClassPtr,"RetargetSource");
			SourceAnimation__Offset=GetPropertyOffset(NativeClassPtr,"SourceAnimation");
			
		}
		
	}
	
}
#endif
#endif
