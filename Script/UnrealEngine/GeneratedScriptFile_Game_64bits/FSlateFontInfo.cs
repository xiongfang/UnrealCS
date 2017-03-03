#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=104)]
	public partial struct FSlateFontInfo
	{
		[FieldOffset(16)]
		public FFontOutlineSettings OutlineSettings;
		[FieldOffset(72)]
		public FName TypefaceFontName;
		[FieldOffset(80)]
		public int Size;
		[FieldOffset(88)]
		public FName FontName;
		
	}
	
}
#endif
#endif
