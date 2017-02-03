#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundNodeGroupControl
	{
		static readonly int GroupSizes__Offset;
		public TStructArray<int> GroupSizes
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+GroupSizes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+GroupSizes__Offset, false);}
			
		}
		
		static USoundNodeGroupControl()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeGroupControl");
			GroupSizes__Offset=GetPropertyOffset(NativeClassPtr,"GroupSizes");
			
		}
		
	}
	
}
#endif
#endif
