#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCapsuleComponent
	{
		static readonly int CapsuleHalfHeight__Offset;
		public float CapsuleHalfHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CapsuleHalfHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CapsuleHalfHeight__Offset, false);}
			
		}
		
		static readonly int CapsuleRadius__Offset;
		public float CapsuleRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CapsuleRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CapsuleRadius__Offset, false);}
			
		}
		
		static readonly int CapsuleHeight__Offset;
		public float CapsuleHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CapsuleHeight__Offset, typeof(float));}
			
		}
		
		static UCapsuleComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CapsuleComponent");
			CapsuleHalfHeight__Offset=GetPropertyOffset(NativeClassPtr,"CapsuleHalfHeight");
			CapsuleRadius__Offset=GetPropertyOffset(NativeClassPtr,"CapsuleRadius");
			CapsuleHeight__Offset=GetPropertyOffset(NativeClassPtr,"CapsuleHeight");
			
		}
		
	}
	
}
#endif
#endif
