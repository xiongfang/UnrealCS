#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBlendProfile
	{
		static readonly int OwningSkeleton__Offset;
		public USkeleton OwningSkeleton
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OwningSkeleton__Offset); if (v == IntPtr.Zero)return null; USkeleton retValue = new USkeleton(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ProfileEntries__Offset;
		public TStructArray<FBlendProfileBoneEntry> ProfileEntries
		{
			get{ CheckIsValid();return new TStructArray<FBlendProfileBoneEntry>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ProfileEntries__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ProfileEntries__Offset, false);}
			
		}
		
		static UBlendProfile()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BlendProfile");
			OwningSkeleton__Offset=GetPropertyOffset(NativeClassPtr,"OwningSkeleton");
			ProfileEntries__Offset=GetPropertyOffset(NativeClassPtr,"ProfileEntries");
			
		}
		
	}
	
}
#endif
#endif
