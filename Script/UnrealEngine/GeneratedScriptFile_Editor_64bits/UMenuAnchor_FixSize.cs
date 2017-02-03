#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// The Menu Anchor allows you to specify an location that a popup menu should be anchored to,
	/// and should be summoned from.
	/// * Single Child
	/// * Popup
	/// </summary>
	public partial class UMenuAnchor
	{
		static readonly int MenuClass__Offset;
		/// <summary>
		/// The widget class to spawn when the menu is required.  Creates the widget freshly each time.
		/// If you want to customize the creation of the popup, you should bind a function to OnGetMenuContentEvent
		/// instead.
		/// </summary>
		public TSubclassOf<UUserWidget>  MenuClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MenuClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + MenuClass__Offset, value); }
			
		}
		
		static readonly int Placement__Offset;
		/// <summary>The placement location of the summoned widget.</summary>
		public EMenuPlacement Placement
		{
			get{ CheckIsValid();return (EMenuPlacement)Marshal.PtrToStructure(_this.Get()+Placement__Offset, typeof(EMenuPlacement));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Placement__Offset, false);}
			
		}
		
		static readonly int ShouldDeferPaintingAfterWindowContent__Offset;
		public bool ShouldDeferPaintingAfterWindowContent
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), ShouldDeferPaintingAfterWindowContent__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), ShouldDeferPaintingAfterWindowContent__Offset, 1,0,1,255);}
			
		}
		
		static readonly int UseApplicationMenuStack__Offset;
		/// <summary>Does this menu behave like a normal stacked menu? Set it to false to control the menu's lifetime yourself.</summary>
		public bool UseApplicationMenuStack
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), UseApplicationMenuStack__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), UseApplicationMenuStack__Offset, 1,0,1,255);}
			
		}
		
		static readonly int OnMenuOpenChanged__Offset;
		/// <summary>Called when the opened state of the menu changes</summary>
		public FMulticastScriptDelegate OnMenuOpenChanged
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnMenuOpenChanged__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnMenuOpenChanged__Offset, false);}
			
		}
		
		static UMenuAnchor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MenuAnchor");
			MenuClass__Offset=GetPropertyOffset(NativeClassPtr,"MenuClass");
			Placement__Offset=GetPropertyOffset(NativeClassPtr,"Placement");
			ShouldDeferPaintingAfterWindowContent__Offset=GetPropertyOffset(NativeClassPtr,"ShouldDeferPaintingAfterWindowContent");
			UseApplicationMenuStack__Offset=GetPropertyOffset(NativeClassPtr,"UseApplicationMenuStack");
			OnMenuOpenChanged__Offset=GetPropertyOffset(NativeClassPtr,"OnMenuOpenChanged");
			
		}
		
	}
	
}
#endif
#endif
