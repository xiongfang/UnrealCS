#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Used to emit a radial force or impulse that can affect physics objects and or destructible objects.</summary>
	public partial class URadialForceComponent
	{
		static readonly int Radius__Offset;
		/// <summary>The radius to apply the force or impulse in</summary>
		public float Radius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Radius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Radius__Offset, false);}
			
		}
		
		static readonly int Falloff__Offset;
		/// <summary>How the force or impulse should fall off as object are further away from the center</summary>
		public ERadialImpulseFalloff Falloff
		{
			get{ CheckIsValid();return (ERadialImpulseFalloff)Marshal.PtrToStructure(_this.Get()+Falloff__Offset, typeof(ERadialImpulseFalloff));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Falloff__Offset, false);}
			
		}
		
		static readonly int ImpulseStrength__Offset;
		/// <summary>How strong the impulse should be</summary>
		public float ImpulseStrength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ImpulseStrength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ImpulseStrength__Offset, false);}
			
		}
		
		static readonly int bImpulseVelChange__Offset;
		/// <summary>If true, the impulse will ignore mass of objects and will always result in a fixed velocity change</summary>
		public bool bImpulseVelChange
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bImpulseVelChange__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bImpulseVelChange__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bIgnoreOwningActor__Offset;
		/// <summary>If true, do not apply force/impulse to any physics objects that are part of the Actor that owns this component.</summary>
		public bool bIgnoreOwningActor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreOwningActor__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreOwningActor__Offset, 1,0,2,2);}
			
		}
		
		static readonly int ForceStrength__Offset;
		/// <summary>How strong the force should be</summary>
		public float ForceStrength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ForceStrength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ForceStrength__Offset, false);}
			
		}
		
		static readonly int DestructibleDamage__Offset;
		/// <summary>If > 0.f, will cause damage to destructible meshes as well</summary>
		public float DestructibleDamage
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DestructibleDamage__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DestructibleDamage__Offset, false);}
			
		}
		
		static readonly int ObjectTypesToAffect__Offset;
		/// <summary>The object types that are affected by this radial force</summary>
		public TStructArray<EObjectTypeQuery> ObjectTypesToAffect
		{
			get{ CheckIsValid();return new TStructArray<EObjectTypeQuery>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ObjectTypesToAffect__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ObjectTypesToAffect__Offset, false);}
			
		}
		
		static URadialForceComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("RadialForceComponent");
			Radius__Offset=GetPropertyOffset(NativeClassPtr,"Radius");
			Falloff__Offset=GetPropertyOffset(NativeClassPtr,"Falloff");
			ImpulseStrength__Offset=GetPropertyOffset(NativeClassPtr,"ImpulseStrength");
			bImpulseVelChange__Offset=GetPropertyOffset(NativeClassPtr,"bImpulseVelChange");
			bIgnoreOwningActor__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreOwningActor");
			ForceStrength__Offset=GetPropertyOffset(NativeClassPtr,"ForceStrength");
			DestructibleDamage__Offset=GetPropertyOffset(NativeClassPtr,"DestructibleDamage");
			ObjectTypesToAffect__Offset=GetPropertyOffset(NativeClassPtr,"ObjectTypesToAffect");
			
		}
		
	}
	
}
#endif
#endif
