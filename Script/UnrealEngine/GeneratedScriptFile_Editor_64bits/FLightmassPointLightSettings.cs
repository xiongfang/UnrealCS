#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Point/spot settings for Lightmass</summary>
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FLightmassPointLightSettings
	{
		/// <summary>0 will be completely desaturated, 1 will be unchanged</summary>
		[FieldOffset(0)]
		public float IndirectLightingSaturation;
		/// <summary>Controls the falloff of shadow penumbras</summary>
		[FieldOffset(4)]
		public float ShadowExponent;
		/// <summary>
		/// Whether to use area shadows for stationary light precomputed shadowmaps.
		/// Area shadows get softer the further they are from shadow casters, but require higher lightmap resolution to get the same quality where the shadow is sharp.
		/// </summary>
		public bool bUseAreaShadowsForStationaryLight
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
