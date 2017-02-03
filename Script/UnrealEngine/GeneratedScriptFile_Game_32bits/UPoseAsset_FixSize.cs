#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPoseAsset
	{
		static readonly int PoseContainer__Offset;
		public FPoseDataContainer PoseContainer
		{
			get{ CheckIsValid();return (FPoseDataContainer)Marshal.PtrToStructure(_this.Get()+PoseContainer__Offset, typeof(FPoseDataContainer));}
			
		}
		
		static readonly int bAdditivePose__Offset;
		public bool bAdditivePose
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAdditivePose__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int BasePoseIndex__Offset;
		public int BasePoseIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+BasePoseIndex__Offset, typeof(int));}
			
		}
		
		static readonly int RetargetSource__Offset;
		public FName RetargetSource
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+RetargetSource__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RetargetSource__Offset, false);}
			
		}
		
		static UPoseAsset()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PoseAsset");
			PoseContainer__Offset=GetPropertyOffset(NativeClassPtr,"PoseContainer");
			bAdditivePose__Offset=GetPropertyOffset(NativeClassPtr,"bAdditivePose");
			BasePoseIndex__Offset=GetPropertyOffset(NativeClassPtr,"BasePoseIndex");
			RetargetSource__Offset=GetPropertyOffset(NativeClassPtr,"RetargetSource");
			
		}
		
	}
	
}
#endif
#endif
