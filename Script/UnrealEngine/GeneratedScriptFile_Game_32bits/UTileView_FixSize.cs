#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTileView
	{
		static readonly int ItemWidth__Offset;
		public float ItemWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ItemWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ItemWidth__Offset, false);}
			
		}
		
		static readonly int ItemHeight__Offset;
		public float ItemHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ItemHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ItemHeight__Offset, false);}
			
		}
		
		static readonly int Items__Offset;
		public TObjectArray<UObject>  Items
		{
					get{ CheckIsValid();return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Items__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Items__Offset, false);}
			
		}
		
		static readonly int SelectionMode__Offset;
		public ESelectionMode SelectionMode
		{
			get{ CheckIsValid();return (ESelectionMode)Marshal.PtrToStructure(_this.Get()+SelectionMode__Offset, typeof(ESelectionMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SelectionMode__Offset, false);}
			
		}
		
		static UTileView()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TileView");
			ItemWidth__Offset=GetPropertyOffset(NativeClassPtr,"ItemWidth");
			ItemHeight__Offset=GetPropertyOffset(NativeClassPtr,"ItemHeight");
			Items__Offset=GetPropertyOffset(NativeClassPtr,"Items");
			SelectionMode__Offset=GetPropertyOffset(NativeClassPtr,"SelectionMode");
			
		}
		
	}
	
}
#endif
#endif
