#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A spacer widget; it does not have a visual representation, and just provides padding between other widgets.
	/// * No Children
	/// </summary>
	public partial class USpacer
	{
		static readonly int Size__Offset;
		/// <summary>The size of the spacer</summary>
		public FVector2D Size
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+Size__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Size__Offset, false);}
			
		}
		
		static USpacer()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Spacer");
			Size__Offset=GetPropertyOffset(NativeClassPtr,"Size");
			
		}
		
	}
	
}
#endif
#endif
