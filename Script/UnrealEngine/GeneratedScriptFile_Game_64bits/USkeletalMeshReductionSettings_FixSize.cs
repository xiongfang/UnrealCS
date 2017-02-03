#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USkeletalMeshReductionSettings
	{
		static readonly int Settings__Offset;
		public TStructArray<FSkeletalMeshLODGroupSettings> Settings
		{
			get{ CheckIsValid();return new TStructArray<FSkeletalMeshLODGroupSettings>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Settings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Settings__Offset, false);}
			
		}
		
		static USkeletalMeshReductionSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SkeletalMeshReductionSettings");
			Settings__Offset=GetPropertyOffset(NativeClassPtr,"Settings");
			
		}
		
	}
	
}
#endif
#endif
