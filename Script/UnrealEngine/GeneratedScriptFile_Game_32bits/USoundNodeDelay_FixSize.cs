#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundNodeDelay
	{
		static readonly int DelayMin__Offset;
		public float DelayMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DelayMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DelayMin__Offset, false);}
			
		}
		
		static readonly int DelayMax__Offset;
		public float DelayMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DelayMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DelayMax__Offset, false);}
			
		}
		
		static USoundNodeDelay()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeDelay");
			DelayMin__Offset=GetPropertyOffset(NativeClassPtr,"DelayMin");
			DelayMax__Offset=GetPropertyOffset(NativeClassPtr,"DelayMax");
			
		}
		
	}
	
}
#endif
#endif
