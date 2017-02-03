#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USpectatorPawnMovement
	{
		static readonly int bIgnoreTimeDilation__Offset;
		/// <summary>If true, component moves at full speed no matter the time dilation. Default is false.</summary>
		public bool bIgnoreTimeDilation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreTimeDilation__Offset, 1, 0, 1, 1);}
			
		}
		
		static USpectatorPawnMovement()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SpectatorPawnMovement");
			bIgnoreTimeDilation__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreTimeDilation");
			
		}
		
	}
	
}
#endif
#endif
