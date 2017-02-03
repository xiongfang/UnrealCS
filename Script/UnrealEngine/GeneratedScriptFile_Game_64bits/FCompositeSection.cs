#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=88)]
	public partial struct FCompositeSection
	{
		[FieldOffset(48)]
		public FName SectionName;
		[FieldOffset(56)]
		public float StartTime;
		[FieldOffset(64)]
		public FName NextSectionName;
		public TObjectArray<UAnimMetaData> MetaData
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UAnimMetaData>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+72, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+72, false);}}}
			
		}
		[FieldOffset(16)]
		public int SlotIndex;
		[FieldOffset(20)]
		public int SegmentIndex;
		[FieldOffset(24)]
		public EAnimLinkMethod LinkMethod;
		[FieldOffset(25)]
		public EAnimLinkMethod CachedLinkMethod;
		[FieldOffset(28)]
		public float SegmentBeginTime;
		[FieldOffset(32)]
		public float SegmentLength;
		[FieldOffset(36)]
		public float LinkValue;
		
	}
	
}
#endif
#endif
