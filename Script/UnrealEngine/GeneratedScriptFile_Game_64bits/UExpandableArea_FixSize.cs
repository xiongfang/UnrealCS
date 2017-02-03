#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UExpandableArea
	{
		static readonly int Style__Offset;
		public FExpandableAreaStyle Style
		{
			get{ CheckIsValid();return (FExpandableAreaStyle)Marshal.PtrToStructure(_this.Get()+Style__Offset, typeof(FExpandableAreaStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Style__Offset, false);}
			
		}
		
		static readonly int BorderBrush__Offset;
		public FSlateBrush BorderBrush
		{
			get{ CheckIsValid();return (FSlateBrush)Marshal.PtrToStructure(_this.Get()+BorderBrush__Offset, typeof(FSlateBrush));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BorderBrush__Offset, false);}
			
		}
		
		static readonly int BorderColor__Offset;
		public FSlateColor BorderColor
		{
			get{ CheckIsValid();return (FSlateColor)Marshal.PtrToStructure(_this.Get()+BorderColor__Offset, typeof(FSlateColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BorderColor__Offset, false);}
			
		}
		
		static readonly int bIsExpanded__Offset;
		public bool bIsExpanded
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsExpanded__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsExpanded__Offset, 1,0,1,255);}
			
		}
		
		static readonly int MaxHeight__Offset;
		public float MaxHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxHeight__Offset, false);}
			
		}
		
		static readonly int HeaderPadding__Offset;
		public FMargin HeaderPadding
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+HeaderPadding__Offset, typeof(FMargin));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HeaderPadding__Offset, false);}
			
		}
		
		static readonly int AreaPadding__Offset;
		public FMargin AreaPadding
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+AreaPadding__Offset, typeof(FMargin));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AreaPadding__Offset, false);}
			
		}
		
		static readonly int OnExpansionChanged__Offset;
		public FMulticastScriptDelegate OnExpansionChanged
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnExpansionChanged__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnExpansionChanged__Offset, false);}
			
		}
		
		static readonly int HeaderContent__Offset;
		public UWidget HeaderContent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + HeaderContent__Offset); if (v == IntPtr.Zero)return null; UWidget retValue = new UWidget(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BodyContent__Offset;
		public UWidget BodyContent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BodyContent__Offset); if (v == IntPtr.Zero)return null; UWidget retValue = new UWidget(); retValue._this = v; return retValue; }
			
		}
		
		static UExpandableArea()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ExpandableArea");
			Style__Offset=GetPropertyOffset(NativeClassPtr,"Style");
			BorderBrush__Offset=GetPropertyOffset(NativeClassPtr,"BorderBrush");
			BorderColor__Offset=GetPropertyOffset(NativeClassPtr,"BorderColor");
			bIsExpanded__Offset=GetPropertyOffset(NativeClassPtr,"bIsExpanded");
			MaxHeight__Offset=GetPropertyOffset(NativeClassPtr,"MaxHeight");
			HeaderPadding__Offset=GetPropertyOffset(NativeClassPtr,"HeaderPadding");
			AreaPadding__Offset=GetPropertyOffset(NativeClassPtr,"AreaPadding");
			OnExpansionChanged__Offset=GetPropertyOffset(NativeClassPtr,"OnExpansionChanged");
			HeaderContent__Offset=GetPropertyOffset(NativeClassPtr,"HeaderContent");
			BodyContent__Offset=GetPropertyOffset(NativeClassPtr,"BodyContent");
			
		}
		
	}
	
}
#endif
#endif
