#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class URendererOverrideSettings
	{
		static readonly int bSupportAllShaderPermutations__Offset;
		/// <summary>"Enabling will locally override all ShaderPermutationReduction settings from the Renderer section to be enabled.  Saved to local user config only.."</summary>
		public bool bSupportAllShaderPermutations
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportAllShaderPermutations__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSupportAllShaderPermutations__Offset, 1,0,1,1);}
			
		}
		
		static URendererOverrideSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("RendererOverrideSettings");
			bSupportAllShaderPermutations__Offset=GetPropertyOffset(NativeClassPtr,"bSupportAllShaderPermutations");
			
		}
		
	}
	
}
#endif
#endif
