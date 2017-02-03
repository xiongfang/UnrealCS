#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UArrowComponent
	{
		static readonly int ArrowColor__Offset;
		public FColor ArrowColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+ArrowColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ArrowColor__Offset, false);}
			
		}
		
		static readonly int ArrowSize__Offset;
		public float ArrowSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ArrowSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ArrowSize__Offset, false);}
			
		}
		
		static readonly int bIsScreenSizeScaled__Offset;
		public bool bIsScreenSizeScaled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsScreenSizeScaled__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsScreenSizeScaled__Offset, 1,0,1,255);}
			
		}
		
		static readonly int ScreenSize__Offset;
		public float ScreenSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ScreenSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ScreenSize__Offset, false);}
			
		}
		
		static readonly int bTreatAsASprite__Offset;
		public bool bTreatAsASprite
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTreatAsASprite__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTreatAsASprite__Offset, 1,0,1,1);}
			
		}
		
		static UArrowComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ArrowComponent");
			ArrowColor__Offset=GetPropertyOffset(NativeClassPtr,"ArrowColor");
			ArrowSize__Offset=GetPropertyOffset(NativeClassPtr,"ArrowSize");
			bIsScreenSizeScaled__Offset=GetPropertyOffset(NativeClassPtr,"bIsScreenSizeScaled");
			ScreenSize__Offset=GetPropertyOffset(NativeClassPtr,"ScreenSize");
			bTreatAsASprite__Offset=GetPropertyOffset(NativeClassPtr,"bTreatAsASprite");
			
		}
		
	}
	
}
#endif
#endif
