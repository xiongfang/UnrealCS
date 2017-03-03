#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimBlueprint
	{
		static readonly int TargetSkeleton__Offset;
		public USkeleton TargetSkeleton
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TargetSkeleton__Offset); if (v == IntPtr.Zero)return null; USkeleton retValue = new USkeleton(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Groups__Offset;
		public TStructArray<FAnimGroupInfo> Groups
		{
			get{ CheckIsValid();return new TStructArray<FAnimGroupInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Groups__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Groups__Offset, false);}
			
		}
		
		static readonly int bUseMultiThreadedAnimationUpdate__Offset;
		public bool bUseMultiThreadedAnimationUpdate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseMultiThreadedAnimationUpdate__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseMultiThreadedAnimationUpdate__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bWarnAboutBlueprintUsage__Offset;
		public bool bWarnAboutBlueprintUsage
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWarnAboutBlueprintUsage__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bWarnAboutBlueprintUsage__Offset, 1,0,1,255);}
			
		}
		
		static UAnimBlueprint()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimBlueprint");
			TargetSkeleton__Offset=GetPropertyOffset(NativeClassPtr,"TargetSkeleton");
			Groups__Offset=GetPropertyOffset(NativeClassPtr,"Groups");
			bUseMultiThreadedAnimationUpdate__Offset=GetPropertyOffset(NativeClassPtr,"bUseMultiThreadedAnimationUpdate");
			bWarnAboutBlueprintUsage__Offset=GetPropertyOffset(NativeClassPtr,"bWarnAboutBlueprintUsage");
			
		}
		
	}
	
}
#endif
#endif
