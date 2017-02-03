#if WITH_EDITOR
#if PLATFORM_64BITS
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
		
		static readonly int SpriteComponent__Offset;
		public UBillboardComponent SpriteComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpriteComponent__Offset); if (v == IntPtr.Zero)return null; UBillboardComponent retValue = new UBillboardComponent(); retValue._this = v; return retValue; }
			
		}
		
		static ATextRenderActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TextRenderActor");
			TextRender__Offset=GetPropertyOffset(NativeClassPtr,"TextRender");
			SpriteComponent__Offset=GetPropertyOffset(NativeClassPtr,"SpriteComponent");
			
		}
		
	}
	
}
#endif
#endif
