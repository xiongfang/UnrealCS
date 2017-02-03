#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackInstAnimControl
	{
		static readonly int LastUpdatePosition__Offset;
		public float LastUpdatePosition
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastUpdatePosition__Offset, typeof(float));}
			
		}
		
		static readonly int InitPosition__Offset;
		public FVector InitPosition
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+InitPosition__Offset, typeof(FVector));}
			
		}
		
		static readonly int InitRotation__Offset;
		public FRotator InitRotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+InitRotation__Offset, typeof(FRotator));}
			
		}
		
		static UInterpTrackInstAnimControl()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackInstAnimControl");
			LastUpdatePosition__Offset=GetPropertyOffset(NativeClassPtr,"LastUpdatePosition");
			InitPosition__Offset=GetPropertyOffset(NativeClassPtr,"InitPosition");
			InitRotation__Offset=GetPropertyOffset(NativeClassPtr,"InitRotation");
			
		}
		
	}
	
}
#endif
#endif
