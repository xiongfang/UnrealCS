#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USlateBrushAsset
	{
		static readonly int Brush__Offset;
		public FSlateBrush Brush
		{
			get{ CheckIsValid();return (FSlateBrush)Marshal.PtrToStructure(_this.Get()+Brush__Offset, typeof(FSlateBrush));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Brush__Offset, false);}
			
		}
		
		static USlateBrushAsset()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SlateBrushAsset");
			Brush__Offset=GetPropertyOffset(NativeClassPtr,"Brush");
			
		}
		
	}
	
}
#endif
#endif
