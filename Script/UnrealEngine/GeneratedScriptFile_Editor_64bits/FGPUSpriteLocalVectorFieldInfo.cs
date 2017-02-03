#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Data needed for local vector fields.</summary>
	[StructLayout(LayoutKind.Explicit,Size=112)]
	public partial struct FGPUSpriteLocalVectorFieldInfo
	{
		/// <summary>Local vector field to apply to this emitter.</summary>
		/// <summary>Local vector field transform.</summary>
		[FieldOffset(16)]
		public FTransform Transform;
		/// <summary>Minimum initial rotation.</summary>
		[FieldOffset(64)]
		public FRotator MinInitialRotation;
		/// <summary>Maximum initial rotation.</summary>
		[FieldOffset(76)]
		public FRotator MaxInitialRotation;
		/// <summary>Local vector field rotation rate.</summary>
		[FieldOffset(88)]
		public FRotator RotationRate;
		/// <summary>Local vector field intensity.</summary>
		[FieldOffset(100)]
		public float Intensity;
		/// <summary>Local vector field tightness.</summary>
		[FieldOffset(104)]
		public float Tightness;
		/// <summary>Ignore Components Transform</summary>
		public bool bIgnoreComponentTransform
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Tile vector field in x axis?</summary>
		public bool bTileX
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Tile vector field in y axis?</summary>
		public bool bTileY
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 4, 4); } }}
			
		}
		/// <summary>Tile vector field in z axis?</summary>
		public bool bTileZ
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 8, 8); } }}
			
		}
		/// <summary>Use fix delta time in the simulation?</summary>
		public bool bUseFixDT
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 16, 16); } }}
			
		}
		
	}
	
}
#endif
#endif
