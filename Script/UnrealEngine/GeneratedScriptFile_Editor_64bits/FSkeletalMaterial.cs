#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FSkeletalMaterial
	{
		public bool bEnableShadowCasting
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 255); } }}
			
		}
		public bool bRecomputeTangent
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 9, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 9, 1, 0, 1, 255); } }}
			
		}
		/// <summary>This name should be use by the gameplay to avoid error if the skeletal mesh Materials array topology change</summary>
		[FieldOffset(12)]
		public FName MaterialSlotName;
		/// <summary>This name should be use when we re-import a skeletal mesh so we can order the Materials array like it should be</summary>
		[FieldOffset(24)]
		public FName ImportedMaterialSlotName;
		/// <summary>Data used for texture streaming relative to each UV channels.</summary>
		[FieldOffset(36)]
		public FMeshUVChannelInfo UVChannelData;
		
	}
	
}
#endif
#endif
