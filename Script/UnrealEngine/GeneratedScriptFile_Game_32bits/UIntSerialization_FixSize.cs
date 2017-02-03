#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UIntSerialization
	{
		static readonly int UnsignedInt16Variable__Offset;
		public ushort UnsignedInt16Variable
		{
			get{ CheckIsValid();return (ushort)Marshal.PtrToStructure(_this.Get()+UnsignedInt16Variable__Offset, typeof(ushort));}
			
		}
		
		static readonly int UnsignedInt32Variable__Offset;
		public uint UnsignedInt32Variable
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+UnsignedInt32Variable__Offset, typeof(uint));}
			
		}
		
		static readonly int UnsignedInt64Variable__Offset;
		public ulong UnsignedInt64Variable
		{
			get{ CheckIsValid();return (ulong)Marshal.PtrToStructure(_this.Get()+UnsignedInt64Variable__Offset, typeof(ulong));}
			
		}
		
		static readonly int SignedInt8Variable__Offset;
		public byte SignedInt8Variable
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+SignedInt8Variable__Offset, typeof(byte));}
			
		}
		
		static readonly int SignedInt16Variable__Offset;
		public ushort SignedInt16Variable
		{
			get{ CheckIsValid();return (ushort)Marshal.PtrToStructure(_this.Get()+SignedInt16Variable__Offset, typeof(ushort));}
			
		}
		
		static readonly int SignedInt64Variable__Offset;
		public ulong SignedInt64Variable
		{
			get{ CheckIsValid();return (ulong)Marshal.PtrToStructure(_this.Get()+SignedInt64Variable__Offset, typeof(ulong));}
			
		}
		
		static readonly int UnsignedInt8Variable__Offset;
		public byte UnsignedInt8Variable
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+UnsignedInt8Variable__Offset, typeof(byte));}
			
		}
		
		static readonly int SignedInt32Variable__Offset;
		public int SignedInt32Variable
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SignedInt32Variable__Offset, typeof(int));}
			
		}
		
		static UIntSerialization()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("IntSerialization");
			UnsignedInt16Variable__Offset=GetPropertyOffset(NativeClassPtr,"UnsignedInt16Variable");
			UnsignedInt32Variable__Offset=GetPropertyOffset(NativeClassPtr,"UnsignedInt32Variable");
			UnsignedInt64Variable__Offset=GetPropertyOffset(NativeClassPtr,"UnsignedInt64Variable");
			SignedInt8Variable__Offset=GetPropertyOffset(NativeClassPtr,"SignedInt8Variable");
			SignedInt16Variable__Offset=GetPropertyOffset(NativeClassPtr,"SignedInt16Variable");
			SignedInt64Variable__Offset=GetPropertyOffset(NativeClassPtr,"SignedInt64Variable");
			UnsignedInt8Variable__Offset=GetPropertyOffset(NativeClassPtr,"UnsignedInt8Variable");
			SignedInt32Variable__Offset=GetPropertyOffset(NativeClassPtr,"SignedInt32Variable");
			
		}
		
	}
	
}
#endif
#endif
