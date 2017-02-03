#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A box generally used for simple collision. Bounds are rendered as lines in the editor.</summary>
	public partial class UBoxComponent
	{
		static readonly int BoxExtent__Offset;
		/// <summary>The extents (radii dimensions) of the box *</summary>
		public FVector BoxExtent
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+BoxExtent__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BoxExtent__Offset, false);}
			
		}
		
		static UBoxComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BoxComponent");
			BoxExtent__Offset=GetPropertyOffset(NativeClassPtr,"BoxExtent");
			
		}
		
	}
	
}
#endif
#endif
