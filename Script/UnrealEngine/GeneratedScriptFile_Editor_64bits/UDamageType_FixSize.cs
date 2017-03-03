#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A DamageType is intended to define and describe a particular form of damage and to provide an avenue
	/// for customizing responses to damage from various sources.
	/// For example, a game could make a DamageType_Fire set it up to ignite the damaged actor.
	/// DamageTypes are never instanced and should be treated as immutable data holders with static code
	/// functionality.  They should never be stateful.
	/// </summary>
	public partial class UDamageType
	{
		static readonly int bCausedByWorld__Offset;
		/// <summary>True if this damagetype is caused by the world (falling off level, into lava, etc).</summary>
		public bool bCausedByWorld
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCausedByWorld__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCausedByWorld__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bScaleMomentumByMass__Offset;
		/// <summary>True to scale imparted momentum by the receiving pawn's mass for pawns using character movement</summary>
		public bool bScaleMomentumByMass
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bScaleMomentumByMass__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bScaleMomentumByMass__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bRadialDamageVelChange__Offset;
		/// <summary>When applying radial impulses, whether to treat as impulse or velocity change.</summary>
		public bool bRadialDamageVelChange
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRadialDamageVelChange__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRadialDamageVelChange__Offset, 1,0,4,4);}
			
		}
		
		static readonly int DamageImpulse__Offset;
		/// <summary>The magnitude of impulse to apply to the Actors damaged by this type.</summary>
		public float DamageImpulse
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DamageImpulse__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DamageImpulse__Offset, false);}
			
		}
		
		static readonly int DestructibleImpulse__Offset;
		/// <summary>How large the impulse should be applied to destructible meshes</summary>
		public float DestructibleImpulse
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DestructibleImpulse__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DestructibleImpulse__Offset, false);}
			
		}
		
		static readonly int DestructibleDamageSpreadScale__Offset;
		/// <summary>How much the damage spreads on a destructible mesh</summary>
		public float DestructibleDamageSpreadScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DestructibleDamageSpreadScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DestructibleDamageSpreadScale__Offset, false);}
			
		}
		
		static readonly int DamageFalloff__Offset;
		/// <summary>Damage fall-off for radius damage (exponent).  Default 1.0=linear, 2.0=square of distance, etc.</summary>
		public float DamageFalloff
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DamageFalloff__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DamageFalloff__Offset, false);}
			
		}
		
		static UDamageType()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DamageType");
			bCausedByWorld__Offset=GetPropertyOffset(NativeClassPtr,"bCausedByWorld");
			bScaleMomentumByMass__Offset=GetPropertyOffset(NativeClassPtr,"bScaleMomentumByMass");
			bRadialDamageVelChange__Offset=GetPropertyOffset(NativeClassPtr,"bRadialDamageVelChange");
			DamageImpulse__Offset=GetPropertyOffset(NativeClassPtr,"DamageImpulse");
			DestructibleImpulse__Offset=GetPropertyOffset(NativeClassPtr,"DestructibleImpulse");
			DestructibleDamageSpreadScale__Offset=GetPropertyOffset(NativeClassPtr,"DestructibleDamageSpreadScale");
			DamageFalloff__Offset=GetPropertyOffset(NativeClassPtr,"DamageFalloff");
			
		}
		
	}
	
}
#endif
#endif
