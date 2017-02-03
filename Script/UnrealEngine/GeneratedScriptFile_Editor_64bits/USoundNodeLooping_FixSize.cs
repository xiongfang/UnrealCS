#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Defines how a sound loops; either indefinitely, or for a set number of times.
	/// Note: The Looping node should only be used for logical or procedural looping such as introducing a delay.
	/// These sounds will not be played seamlessly. If you want a sound to loop seamlessly and indefinitely,
	/// use the Looping flag on the Wave Player node for that sound.
	/// </summary>
	public partial class USoundNodeLooping
	{
		static readonly int LoopCount__Offset;
		/// <summary>The amount of times to loop</summary>
		public int LoopCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LoopCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LoopCount__Offset, false);}
			
		}
		
		static readonly int bLoopIndefinitely__Offset;
		/// <summary>If enabled, the node will continue to loop indefinitely regardless of the Loop Count value.</summary>
		public bool bLoopIndefinitely
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLoopIndefinitely__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLoopIndefinitely__Offset, 1,0,1,1);}
			
		}
		
		static USoundNodeLooping()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeLooping");
			LoopCount__Offset=GetPropertyOffset(NativeClassPtr,"LoopCount");
			bLoopIndefinitely__Offset=GetPropertyOffset(NativeClassPtr,"bLoopIndefinitely");
			
		}
		
	}
	
}
#endif
#endif
