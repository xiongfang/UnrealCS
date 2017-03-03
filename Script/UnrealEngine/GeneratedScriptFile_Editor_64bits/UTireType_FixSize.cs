#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>DEPRECATED - Only used to allow conversion to new TireConfig in PhysXVehicles plugin</summary>
	public partial class UTireType
	{
		static readonly int FrictionScale__Offset;
		public float FrictionScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FrictionScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FrictionScale__Offset, false);}
			
		}
		
		static UTireType()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TireType");
			FrictionScale__Offset=GetPropertyOffset(NativeClassPtr,"FrictionScale");
			
		}
		
	}
	
}
#endif
#endif
