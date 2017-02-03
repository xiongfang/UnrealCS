#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackInstEvent
	{
		static readonly int LastUpdatePosition__Offset;
		/// <summary>
		/// Position we were in last time we evaluated Events.
		/// During UpdateTrack, events between this time and the current time will be fired.
		/// </summary>
		public float LastUpdatePosition
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastUpdatePosition__Offset, typeof(float));}
			
		}
		
		static UInterpTrackInstEvent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackInstEvent");
			LastUpdatePosition__Offset=GetPropertyOffset(NativeClassPtr,"LastUpdatePosition");
			
		}
		
	}
	
}
#endif
#endif
