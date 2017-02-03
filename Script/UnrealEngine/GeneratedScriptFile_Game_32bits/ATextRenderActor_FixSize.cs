#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ATextRenderActor
	{
		static readonly int TextRender__Offset;
		public UTextRenderComponent TextRender
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TextRender__Offset); if (v == IntPtr.Zero)return null; UTextRenderComponent retValue = new UTextRenderComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + TextRender__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + TextRender__Offset, value._this.Get()); }
			
		}
		
		static ATextRenderActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TextRenderActor");
			TextRender__Offset=GetPropertyOffset(NativeClassPtr,"TextRender");
			
		}
		
	}
	
}
#endif
#endif
