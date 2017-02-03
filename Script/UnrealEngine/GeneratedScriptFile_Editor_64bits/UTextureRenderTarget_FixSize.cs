#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTextureRenderTarget
	{
		static readonly int TargetGamma__Offset;
		/// <summary>Will override FTextureRenderTarget2DResource::GetDisplayGamma if > 0.</summary>
		public float TargetGamma
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TargetGamma__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetGamma__Offset, false);}
			
		}
		
		static UTextureRenderTarget()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TextureRenderTarget");
			TargetGamma__Offset=GetPropertyOffset(NativeClassPtr,"TargetGamma");
			
		}
		
	}
	
}
#endif
#endif
