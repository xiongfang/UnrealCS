#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundConcurrency
	{
		static readonly int Concurrency__Offset;
		public FSoundConcurrencySettings Concurrency
		{
			get{ CheckIsValid();return (FSoundConcurrencySettings)Marshal.PtrToStructure(_this.Get()+Concurrency__Offset, typeof(FSoundConcurrencySettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Concurrency__Offset, false);}
			
		}
		
		static USoundConcurrency()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundConcurrency");
			Concurrency__Offset=GetPropertyOffset(NativeClassPtr,"Concurrency");
			
		}
		
	}
	
}
#endif
#endif
