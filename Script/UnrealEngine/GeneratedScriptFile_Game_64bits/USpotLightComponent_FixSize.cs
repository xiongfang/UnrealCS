#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USpotLightComponent
	{
		static readonly int InnerConeAngle__Offset;
		public float InnerConeAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InnerConeAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InnerConeAngle__Offset, false);}
			
		}
		
		static readonly int OuterConeAngle__Offset;
		public float OuterConeAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OuterConeAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OuterConeAngle__Offset, false);}
			
		}
		
		static readonly int LightShaftConeAngle__Offset;
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
