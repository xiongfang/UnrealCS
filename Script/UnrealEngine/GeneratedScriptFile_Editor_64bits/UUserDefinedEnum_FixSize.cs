#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>An Enumeration is a list of named values.</summary>
	public partial class UUserDefinedEnum
	{
		static readonly int UniqueNameIndex__Offset;
		public uint UniqueNameIndex
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+UniqueNameIndex__Offset, typeof(uint));}
			
		}
		
		static UUserDefinedEnum()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("UserDefinedEnum");
			UniqueNameIndex__Offset=GetPropertyOffset(NativeClassPtr,"UniqueNameIndex");
			
		}
		
	}
	
}
#endif
#endif
