#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// An asset describing how a texture can exist in slate's DPI-aware environment
	/// and how this texture responds to resizing. e.g. Scale9-stretching? Tiling?
	/// </summary>
	public partial class USlateBrushAsset
	{
		static readonly int Brush__Offset;
		/// <summary>The slate brush resource describing the texture's behavior.</summary>
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
