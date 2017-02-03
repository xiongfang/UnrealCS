#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCanvasPanelSlot
	{
		static readonly int LayoutData__Offset;
		public FAnchorData LayoutData
		{
			get{ CheckIsValid();return (FAnchorData)Marshal.PtrToStructure(_this.Get()+LayoutData__Offset, typeof(FAnchorData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LayoutData__Offset, false);}
			
		}
		
		static readonly int bAutoSize__Offset;
		public bool bAutoSize
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoSize__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoSize__Offset, 1,0,1,255);}
			
		}
		
		static readonly int ZOrder__Offset;
		public int ZOrder
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ZOrder__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ZOrder__Offset, false);}
			
		}
		
		static UCanvasPanelSlot()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CanvasPanelSlot");
			LayoutData__Offset=GetPropertyOffset(NativeClassPtr,"LayoutData");
			bAutoSize__Offset=GetPropertyOffset(NativeClassPtr,"bAutoSize");
			ZOrder__Offset=GetPropertyOffset(NativeClassPtr,"ZOrder");
			
		}
		
	}
	
}
#endif
#endif
