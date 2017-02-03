#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundNodeBranch
	{
		static readonly int BoolParameterName__Offset;
		public FName BoolParameterName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+BoolParameterName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BoolParameterName__Offset, false);}
			
		}
		
		static USoundNodeBranch()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeBranch");
			BoolParameterName__Offset=GetPropertyOffset(NativeClassPtr,"BoolParameterName");
			
		}
		
	}
	
}
#endif
#endif
