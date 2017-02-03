#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ANavModifierVolume
	{
		static readonly int AreaClass__Offset;
		public TSubclassOf<UNavArea>  AreaClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AreaClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + AreaClass__Offset, value); }
			
		}
		
		static ANavModifierVolume()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavModifierVolume");
			AreaClass__Offset=GetPropertyOffset(NativeClassPtr,"AreaClass");
			
		}
		
	}
	
}
#endif
#endif
