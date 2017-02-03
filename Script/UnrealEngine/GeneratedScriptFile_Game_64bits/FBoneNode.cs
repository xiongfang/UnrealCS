#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FBoneNode
	{
		[FieldOffset(0)]
		public FName Name;
		[FieldOffset(8)]
		public int ParentIndex;
		[FieldOffset(12)]
		public EBoneTranslationRetargetingMode TranslationRetargetingMode;
		
	}
	
}
#endif
#endif
