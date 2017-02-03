#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPhysicsThrusterComponent
	{
		static readonly int ThrustStrength__Offset;
		public float ThrustStrength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ThrustStrength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ThrustStrength__Offset, false);}
			
		}
		
		static UPhysicsThrusterComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PhysicsThrusterComponent");
			ThrustStrength__Offset=GetPropertyOffset(NativeClassPtr,"ThrustStrength");
			
		}
		
	}
	
}
#endif
#endif
