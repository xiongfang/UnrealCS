#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FParticleRandomSeedInfo
	{
		/// <summary>The name to expose to the placed instances for setting this seed</summary>
		[FieldOffset(0)]
		public FName ParameterName;
		/// <summary>
		/// If true, the module will attempt to get the seed from the owner
		/// instance. If that fails, it will fall back to getting it from
		/// the RandomSeeds array.
		/// </summary>
		public bool bGetSeedFromInstance
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 1); } }}
			
		}
		/// <summary>
		/// If true, the seed value retrieved from the instance will be an
		/// index into the array of seeds.
		/// </summary>
		public bool bInstanceSeedIsIndex
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 2, 2); } }}
			
		}
		/// <summary>
		/// If true, then reset the seed upon the emitter looping.
		/// For looping environmental effects this should likely be set to false to avoid
		/// a repeating pattern.
		/// </summary>
		public bool bResetSeedOnEmitterLooping
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 4, 4); } }}
			
		}
		/// <summary>If true, then randomly select a seed entry from the RandomSeeds array</summary>
		public bool bRandomlySelectSeedArray
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 8, 8); } }}
			
		}
		/// <summary>
		/// The random seed values to utilize for the module.
		/// More than 1 means the instance will randomly select one.
		/// </summary>
		public TStructArray<int> RandomSeeds
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		
	}
	
}
#endif
#endif
