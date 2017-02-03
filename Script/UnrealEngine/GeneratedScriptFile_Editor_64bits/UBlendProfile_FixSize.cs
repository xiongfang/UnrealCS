#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A blend profile is a set of per-bone scales that can be used in transitions and blend lists
	/// to tweak the weights of specific bones. The scales are applied to the normal weight for that bone
	/// </summary>
	public partial class UBlendProfile
	{
		static readonly int OwningSkeleton__Offset;
		/// <summary>The skeleton that owns this profile</summary>
		public USkeleton OwningSkeleton
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OwningSkeleton__Offset); if (v == IntPtr.Zero)return null; USkeleton retValue = new USkeleton(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ProfileEntries__Offset;
		/// <summary>List of blend scale entries</summary>
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
