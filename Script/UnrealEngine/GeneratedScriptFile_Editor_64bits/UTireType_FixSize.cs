#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTireType
	{
		static readonly int FrictionScale__Offset;
		/// <summary>Scale the tire friction for this tire type</summary>
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
