#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A placeable fog actor that simulates atmospheric light scattering
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Actors/FogEffects/AtmosphericFog/index.html
	/// </summary>
	public partial class AAtmosphericFog
	{
		static readonly int AtmosphericFogComponent__Offset;
		public UAtmosphericFogComponent AtmosphericFogComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AtmosphericFogComponent__Offset); if (v == IntPtr.Zero)return null; UAtmosphericFogComponent retValue = new UAtmosphericFogComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AtmosphericFogComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AtmosphericFogComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int ArrowComponent__Offset;
		public UArrowComponent ArrowComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ArrowComponent__Offset); if (v == IntPtr.Zero)return null; UArrowComponent retValue = new UArrowComponent(); retValue._this = v; return retValue; }
			
		}
		
		static AAtmosphericFog()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AtmosphericFog");
			AtmosphericFogComponent__Offset=GetPropertyOffset(NativeClassPtr,"AtmosphericFogComponent");
			ArrowComponent__Offset=GetPropertyOffset(NativeClassPtr,"ArrowComponent");
			
		}
		
	}
	
}
#endif
#endif
