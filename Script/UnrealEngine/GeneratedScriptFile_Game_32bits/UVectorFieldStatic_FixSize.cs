#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UVectorFieldStatic
	{
		static readonly int SizeX__Offset;
		public int SizeX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SizeX__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SizeX__Offset, false);}
			
		}
		
		static readonly int SizeY__Offset;
		public int SizeY
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SizeY__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SizeY__Offset, false);}
			
		}
		
		static readonly int SizeZ__Offset;
		public int SizeZ
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SizeZ__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SizeZ__Offset, false);}
			
		}
		
		static UVectorFieldStatic()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("VectorFieldStatic");
			SizeX__Offset=GetPropertyOffset(NativeClassPtr,"SizeX");
			SizeY__Offset=GetPropertyOffset(NativeClassPtr,"SizeY");
			SizeZ__Offset=GetPropertyOffset(NativeClassPtr,"SizeZ");
			
		}
		
	}
	
}
#endif
#endif
