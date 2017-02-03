#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FCollisionResponse
	{
		/// <summary>
		/// Types of objects that this physics objects will collide with. // @todo : make this to be transient, so that it doesn't have to save anymore
		/// // we have to still load them until resave
		/// </summary>
		[FieldOffset(0)]
		public FCollisionResponseContainer ResponseToChannels;
		/// <summary>Custom Channels for Responses</summary>
		public TStructArray<FResponseChannel> ResponseArray
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FResponseChannel>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		
	}
	
}
#endif
#endif
