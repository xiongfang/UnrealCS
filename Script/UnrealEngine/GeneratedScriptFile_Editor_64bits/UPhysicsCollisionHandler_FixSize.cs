#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPhysicsCollisionHandler
	{
		static readonly int ImpactThreshold__Offset;
		/// <summary>How hard an impact must be to trigger effect/sound</summary>
		public float ImpactThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ImpactThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ImpactThreshold__Offset, false);}
			
		}
		
		static readonly int ImpactReFireDelay__Offset;
		/// <summary>Min time between effect/sound being triggered</summary>
		public float ImpactReFireDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ImpactReFireDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ImpactReFireDelay__Offset, false);}
			
		}
		
		static readonly int DefaultImpactSound__Offset;
		/// <summary>Sound to play</summary>
		public USoundBase DefaultImpactSound
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultImpactSound__Offset); if (v == IntPtr.Zero)return null; USoundBase retValue = new USoundBase(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + DefaultImpactSound__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + DefaultImpactSound__Offset, value._this.Get()); }
			
		}
		
		static readonly int LastImpactSoundTime__Offset;
		/// <summary>Time since last impact sound</summary>
		public float LastImpactSoundTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastImpactSoundTime__Offset, typeof(float));}
			
		}
		
		static UPhysicsCollisionHandler()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PhysicsCollisionHandler");
			ImpactThreshold__Offset=GetPropertyOffset(NativeClassPtr,"ImpactThreshold");
			ImpactReFireDelay__Offset=GetPropertyOffset(NativeClassPtr,"ImpactReFireDelay");
			DefaultImpactSound__Offset=GetPropertyOffset(NativeClassPtr,"DefaultImpactSound");
			LastImpactSoundTime__Offset=GetPropertyOffset(NativeClassPtr,"LastImpactSoundTime");
			
		}
		
	}
	
}
#endif
#endif
