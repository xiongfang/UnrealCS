#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A group and all the actors controlled by the group</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FInterpGroupActorInfo
	{
		[FieldOffset(0)]
		public FName ObjectName;
		public TObjectArray<AActor> Actors
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+16, false);}}}
			
		}
		
	}
	
}
#endif
#endif
