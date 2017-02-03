#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Defines a delay</summary>
	public partial class USoundNodeDelay
	{
		static readonly int DelayMin__Offset;
		/// <summary>The lower bound of delay time in seconds.</summary>
		public float DelayMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DelayMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DelayMin__Offset, false);}
			
		}
		
		static readonly int DelayMax__Offset;
		/// <summary>The upper bound of delay time in seconds.</summary>
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
