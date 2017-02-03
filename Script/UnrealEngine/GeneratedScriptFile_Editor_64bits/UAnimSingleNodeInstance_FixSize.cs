#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimSingleNodeInstance
	{
		static readonly int CurrentAsset__Offset;
		/// <summary>Current Asset being played *</summary>
		public UAnimationAsset CurrentAsset
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CurrentAsset__Offset); if (v == IntPtr.Zero)return null; UAnimationAsset retValue = new UAnimationAsset(); retValue._this = v; return retValue; }
			
		}
		
		static UAnimSingleNodeInstance()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimSingleNodeInstance");
			CurrentAsset__Offset=GetPropertyOffset(NativeClassPtr,"CurrentAsset");
			
		}
		
	}
	
}
#endif
#endif
