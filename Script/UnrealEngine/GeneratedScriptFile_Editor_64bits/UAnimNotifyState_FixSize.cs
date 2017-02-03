#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimNotifyState
	{
		static readonly int NotifyColor__Offset;
		/// <summary>Color of Notify in editor</summary>
		public FColor NotifyColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+NotifyColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NotifyColor__Offset, false);}
			
		}
		
		static UAnimNotifyState()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimNotifyState");
			NotifyColor__Offset=GetPropertyOffset(NativeClassPtr,"NotifyColor");
			
		}
		
	}
	
}
#endif
#endif
