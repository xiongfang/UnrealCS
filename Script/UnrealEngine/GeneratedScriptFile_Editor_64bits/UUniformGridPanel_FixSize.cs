#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A panel that evenly divides up available space between all of its children.</summary>
	public partial class UUniformGridPanel
	{
		static readonly int SlotPadding__Offset;
		/// <summary>Padding given to each slot</summary>
		public FMargin SlotPadding
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+SlotPadding__Offset, typeof(FMargin));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SlotPadding__Offset, false);}
			
		}
		
		static readonly int MinDesiredSlotWidth__Offset;
		/// <summary>The minimum desired width of the slots</summary>
		public float MinDesiredSlotWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinDesiredSlotWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinDesiredSlotWidth__Offset, false);}
			
		}
		
		static readonly int MinDesiredSlotHeight__Offset;
		/// <summary>The minimum desired height of the slots</summary>
		public float MinDesiredSlotHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinDesiredSlotHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinDesiredSlotHeight__Offset, false);}
			
		}
		
		static UUniformGridPanel()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("UniformGridPanel");
			SlotPadding__Offset=GetPropertyOffset(NativeClassPtr,"SlotPadding");
			MinDesiredSlotWidth__Offset=GetPropertyOffset(NativeClassPtr,"MinDesiredSlotWidth");
			MinDesiredSlotHeight__Offset=GetPropertyOffset(NativeClassPtr,"MinDesiredSlotHeight");
			
		}
		
	}
	
}
#endif
#endif
