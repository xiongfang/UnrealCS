#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A texture used for communicating data to the GPU.
	/// Used in combination with SlateVectorArtData and SlateVectorArtInstanceData to
	/// pass data to UI materials.
	/// </summary>
	public partial class USlateDataSheet
	{
		static readonly int DataTexture__Offset;
		public UTexture2D DataTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DataTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static USlateDataSheet()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SlateDataSheet");
			DataTexture__Offset=GetPropertyOffset(NativeClassPtr,"DataTexture");
			
		}
		
	}
	
}
#endif
#endif
