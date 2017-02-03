#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Arranges widgets left-to-right.  When the widgets exceed the Width it will place widgets on the next line.
	/// * Many Children
	/// * Flows
	/// * Wraps
	/// </summary>
	public partial class UWrapBox
	{
		static readonly int InnerSlotPadding__Offset;
		/// <summary>The inner slot padding goes between slots sharing borders</summary>
		public FVector2D InnerSlotPadding
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+InnerSlotPadding__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InnerSlotPadding__Offset, false);}
			
		}
		
		static UWrapBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WrapBox");
			InnerSlotPadding__Offset=GetPropertyOffset(NativeClassPtr,"InnerSlotPadding");
			
		}
		
	}
	
}
#endif
#endif
