#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A spot light component emits a directional cone shaped light (Eg a Torch).</summary>
	public partial class USpotLightComponent
	{
		static readonly int InnerConeAngle__Offset;
		/// <summary>Degrees.</summary>
		public float InnerConeAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InnerConeAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InnerConeAngle__Offset, false);}
			
		}
		
		static readonly int OuterConeAngle__Offset;
		/// <summary>Degrees.</summary>
		public float OuterConeAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OuterConeAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OuterConeAngle__Offset, false);}
			
		}
		
		static readonly int LightShaftConeAngle__Offset;
		/// <summary>EditAnywhere, BlueprintReadOnly, Category=LightShaft, meta=(UIMin = "1.0", UIMax = "180.0")</summary>
		public float LightShaftConeAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LightShaftConeAngle__Offset, typeof(float));}
			
		}
		
		static USpotLightComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SpotLightComponent");
			InnerConeAngle__Offset=GetPropertyOffset(NativeClassPtr,"InnerConeAngle");
			OuterConeAngle__Offset=GetPropertyOffset(NativeClassPtr,"OuterConeAngle");
			LightShaftConeAngle__Offset=GetPropertyOffset(NativeClassPtr,"LightShaftConeAngle");
			
		}
		
	}
	
}
#endif
#endif
