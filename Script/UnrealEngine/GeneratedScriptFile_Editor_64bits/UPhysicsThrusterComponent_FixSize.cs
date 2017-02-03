#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Used with objects that have physics to apply a force down the negative-X direction
	/// ie. point X in the direction you want the thrust in.
	/// </summary>
	public partial class UPhysicsThrusterComponent
	{
		static readonly int ThrustStrength__Offset;
		/// <summary>Strength of thrust force applied to the base object.</summary>
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
