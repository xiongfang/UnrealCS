#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionTextureProperty
	{
		static readonly int TextureObject__Offset;
		public FExpressionInput TextureObject
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+TextureObject__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Property__Offset;
		public EMaterialExposedTextureProperty Property
		{
			get{ CheckIsValid();return (EMaterialExposedTextureProperty)Marshal.PtrToStructure(_this.Get()+Property__Offset, typeof(EMaterialExposedTextureProperty));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Property__Offset, false);}
			
		}
		
		static UMaterialExpressionTextureProperty()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionTextureProperty");
			TextureObject__Offset=GetPropertyOffset(NativeClassPtr,"TextureObject");
			Property__Offset=GetPropertyOffset(NativeClassPtr,"Property");
			
		}
		
	}
	
}
#endif
#endif
