#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDamageType
	{
		static readonly int bCausedByWorld__Offset;
		public bool bCausedByWorld
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCausedByWorld__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCausedByWorld__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bScaleMomentumByMass__Offset;
		public bool bScaleMomentumByMass
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bScaleMomentumByMass__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bScaleMomentumByMass__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bRadialDamageVelChange__Offset;
		public bool bRadialDamageVelChange
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRadialDamageVelChange__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRadialDamageVelChange__Offset, 1,0,4,4);}
			
		}
		
		static readonly int DamageImpulse__Offset;
		public float DamageImpulse
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DamageImpulse__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DamageImpulse__Offset, false);}
			
		}
		
		static readonly int DestructibleImpulse__Offset;
		public float DestructibleImpulse
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DestructibleImpulse__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DestructibleImpulse__Offset, false);}
			
		}
		
		static readonly int DestructibleDamageSpreadScale__Offset;
		public float DestructibleDamageSpreadScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DestructibleDamageSpreadScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DestructibleDamageSpreadScale__Offset, false);}
			
		}
		
		static readonly int DamageFalloff__Offset;
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
