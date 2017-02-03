#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionFontSample
	{
		static readonly int Font__Offset;
		/// <summary>font resource that will be sampled</summary>
		public UFont Font
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Font__Offset); if (v == IntPtr.Zero)return null; UFont retValue = new UFont(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Font__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Font__Offset, value._this.Get()); }
			
		}
		
		static readonly int FontTexturePage__Offset;
		/// <summary>allow access to the various font pages</summary>
		public int FontTexturePage
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+FontTexturePage__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FontTexturePage__Offset, false);}
			
		}
		
		static UMaterialExpressionFontSample()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionFontSample");
			Font__Offset=GetPropertyOffset(NativeClassPtr,"Font");
			FontTexturePage__Offset=GetPropertyOffset(NativeClassPtr,"FontTexturePage");
			
		}
		
	}
	
}
#endif
#endif
