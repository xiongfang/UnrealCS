#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class URichTextBlockDecorator
	{
		static readonly int bReveal__Offset;
		public bool bReveal
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReveal__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReveal__Offset, 1,0,1,255);}
			
		}
		
		static readonly int RevealedIndex__Offset;
		public int RevealedIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RevealedIndex__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RevealedIndex__Offset, false);}
			
		}
		
		static URichTextBlockDecorator()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("RichTextBlockDecorator");
			bReveal__Offset=GetPropertyOffset(NativeClassPtr,"bReveal");
			RevealedIndex__Offset=GetPropertyOffset(NativeClassPtr,"RevealedIndex");
			
		}
		
	}
	
}
#endif
#endif
