#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Each Bone node in BoneTree</summary>
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FBoneNode
	{
		/// <summary>Name of bone, this is the search criteria to match with mesh bone. This will be NAME_None if deleted.</summary>
		[FieldOffset(0)]
		public FName Name;
		/// <summary>Parent Index. -1 if not used. The root has 0 as its parent. Do not delete the element but set this to -1. If it is revived by other reason, fix up this link.</summary>
		[FieldOffset(12)]
		public int ParentIndex;
		/// <summary>Retargeting Mode for Translation Component.</summary>
		[FieldOffset(16)]
		public EBoneTranslationRetargetingMode TranslationRetargetingMode;
		
	}
	
}
#endif
#endif
