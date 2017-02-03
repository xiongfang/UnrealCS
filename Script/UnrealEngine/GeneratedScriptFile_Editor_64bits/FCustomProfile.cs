#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Structure for custom profiles.
	/// if you'd like to just add custom channels, not changing anything else engine defined
	/// if you'd like to override all about profile, please use
	/// +Profiles=(Name=NameOfProfileYouLikeToOverwrite,....)
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FCustomProfile
	{
		[FieldOffset(0)]
		public FName Name;
		/// <summary>Types of objects that this physics objects will collide with.</summary>
		public TStructArray<FResponseChannel> CustomResponses
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FResponseChannel>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		
	}
	
}
#endif
#endif
