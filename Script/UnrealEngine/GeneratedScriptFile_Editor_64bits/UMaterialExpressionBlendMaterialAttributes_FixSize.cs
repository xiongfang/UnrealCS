#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionBlendMaterialAttributes
	{
		static readonly int A__Offset;
		public FMaterialAttributesInput A
		{
			get{ CheckIsValid();return (FMaterialAttributesInput)Marshal.PtrToStructure(_this.Get()+A__Offset, typeof(FMaterialAttributesInput));}
			
		}
		
		static readonly int B__Offset;
		public FMaterialAttributesInput B
		{
			get{ CheckIsValid();return (FMaterialAttributesInput)Marshal.PtrToStructure(_this.Get()+B__Offset, typeof(FMaterialAttributesInput));}
			
		}
		
		static readonly int Alpha__Offset;
		public FExpressionInput Alpha
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Alpha__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int PixelAttributeBlendType__Offset;
		/// <summary>Optionally skip blending attributes of this type.</summary>
		public EMaterialAttributeBlend PixelAttributeBlendType
		{
			get{ CheckIsValid();return (EMaterialAttributeBlend)Marshal.PtrToStructure(_this.Get()+PixelAttributeBlendType__Offset, typeof(EMaterialAttributeBlend));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PixelAttributeBlendType__Offset, false);}
			
		}
		
		static readonly int VertexAttributeBlendType__Offset;
		/// <summary>Optionally skip blending attributes of this type.</summary>
		public EMaterialAttributeBlend VertexAttributeBlendType
		{
			get{ CheckIsValid();return (EMaterialAttributeBlend)Marshal.PtrToStructure(_this.Get()+VertexAttributeBlendType__Offset, typeof(EMaterialAttributeBlend));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VertexAttributeBlendType__Offset, false);}
			
		}
		
		static UMaterialExpressionBlendMaterialAttributes()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionBlendMaterialAttributes");
			A__Offset=GetPropertyOffset(NativeClassPtr,"A");
			B__Offset=GetPropertyOffset(NativeClassPtr,"B");
			Alpha__Offset=GetPropertyOffset(NativeClassPtr,"Alpha");
			PixelAttributeBlendType__Offset=GetPropertyOffset(NativeClassPtr,"PixelAttributeBlendType");
			VertexAttributeBlendType__Offset=GetPropertyOffset(NativeClassPtr,"VertexAttributeBlendType");
			
		}
		
	}
	
}
#endif
#endif
