#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FMovieSceneSpawnable
	{
		[FieldOffset(0)]
		public FGuid Guid;
		[FieldOffset(16)]
		public FString Name;
		public TStructArray<FGuid> ChildPossessables
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FGuid>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		
	}
	
}
#endif
#endif
