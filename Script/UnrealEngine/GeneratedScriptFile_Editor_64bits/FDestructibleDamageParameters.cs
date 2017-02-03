#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Parameters that pertain to chunk damage.</summary>
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FDestructibleDamageParameters
	{
		/// <summary>The damage amount which will cause a chunk to fracture (break free).</summary>
		[FieldOffset(0)]
		public float DamageThreshold;
		/// <summary>Controls how easily damage spreads. DamageRadius = Damage*DamageSpread. All chunks within DamageRadius will take damage. Full damage is taken at zero distance, and zero damage at the DamageRadius.</summary>
		[FieldOffset(4)]
		public float DamageSpread;
		/// <summary>
		/// Whether to apply damage to destructible when colliding with an object.
		/// @see ImpactDamage
		/// </summary>
		public bool bEnableImpactDamage
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 255); } }}
			
		}
		/// <summary>
		/// Controls how much damage is applied upon collision. Damage = ImpactDamage * ImpactForce.
		/// @see DepthParameters for per level control of ImpactDamage
		/// </summary>
		[FieldOffset(12)]
		public float ImpactDamage;
		/// <summary>
		/// Max depth level where impact damage is enabled. @see DepthParameters for per level control of ImpactDamage
		/// If negative, impact damage is disabled
		/// </summary>
		[FieldOffset(16)]
		public int DefaultImpactDamageDepth;
		/// <summary>
		/// By default, objects that collide with destructibles will bounce back. Custom resistance allows for finer control of how much a destructible "pushes back" against a colliding object.
		/// @see ImpactResistance
		/// </summary>
		public bool bCustomImpactResistance
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 1, 255); } }}
			
		}
		/// <summary>
		/// Controls how much resistance is applied to colliding objects. Weak materials like glass should set this to a low value so that objects will pass right through them during fracture.
		/// @see DepthParameters for per level control of ImpactResistance
		/// </summary>
		[FieldOffset(24)]
		public float ImpactResistance;
		
	}
	
}
#endif
#endif
