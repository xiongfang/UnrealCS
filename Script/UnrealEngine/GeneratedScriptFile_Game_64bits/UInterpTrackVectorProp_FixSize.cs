#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackVectorProp
	{
		static readonly int PropertyName__Offset;
		public FName PropertyName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+PropertyName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PropertyName__Offset, false);}
			
		}
		
		static UInterpTrackVectorProp()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackVectorProp");
			PropertyName__Offset=GetPropertyOffset(NativeClassPtr,"PropertyName");
			
		}
		
	}
	
}
#endif
#endif
