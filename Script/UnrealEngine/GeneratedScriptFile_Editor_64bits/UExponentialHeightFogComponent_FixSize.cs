#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Used to create fogging effects such as clouds but with a density that is related to the height of the fog.</summary>
	public partial class UExponentialHeightFogComponent
	{
		static readonly int FogDensity__Offset;
		/// <summary>Global density factor.</summary>
		public float FogDensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FogDensity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FogDensity__Offset, false);}
			
		}
		
		static readonly int FogInscatteringColor__Offset;
		public FLinearColor FogInscatteringColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+FogInscatteringColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FogInscatteringColor__Offset, false);}
			
		}
		
		static readonly int DirectionalInscatteringExponent__Offset;
		/// <summary>
		/// Controls the size of the directional inscattering cone, which is used to approximate inscattering from a directional light.
		/// Note: there must be a directional light with bUsedAsAtmosphereSunLight enabled for DirectionalInscattering to be used.
		/// </summary>
		public float DirectionalInscatteringExponent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DirectionalInscatteringExponent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DirectionalInscatteringExponent__Offset, false);}
			
		}
		
		static readonly int DirectionalInscatteringStartDistance__Offset;
		/// <summary>
		/// Controls the start distance from the viewer of the directional inscattering, which is used to approximate inscattering from a directional light.
		/// Note: there must be a directional light with bUsedAsAtmosphereSunLight enabled for DirectionalInscattering to be used.
		/// </summary>
		public float DirectionalInscatteringStartDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DirectionalInscatteringStartDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DirectionalInscatteringStartDistance__Offset, false);}
			
		}
		
		static readonly int DirectionalInscatteringColor__Offset;
		/// <summary>
		/// Controls the color of the directional inscattering, which is used to approximate inscattering from a directional light.
		/// Note: there must be a directional light with bUsedAsAtmosphereSunLight enabled for DirectionalInscattering to be used.
		/// </summary>
		public FLinearColor DirectionalInscatteringColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+DirectionalInscatteringColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DirectionalInscatteringColor__Offset, false);}
			
		}
		
		static readonly int FogHeightFalloff__Offset;
		/// <summary>
		/// Height density factor, controls how the density increases as height decreases.
		/// Smaller values make the visible transition larger.
		/// </summary>
		public float FogHeightFalloff
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FogHeightFalloff__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FogHeightFalloff__Offset, false);}
			
		}
		
		static readonly int FogMaxOpacity__Offset;
		/// <summary>
		/// Maximum opacity of the fog.
		/// A value of 1 means the fog can become fully opaque at a distance and replace scene color completely,
		/// A value of 0 means the fog color will not be factored in at all.
		/// </summary>
		public float FogMaxOpacity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FogMaxOpacity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FogMaxOpacity__Offset, false);}
			
		}
		
		static readonly int StartDistance__Offset;
		/// <summary>Distance from the camera that the fog will start, in world units.</summary>
		public float StartDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StartDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartDistance__Offset, false);}
			
		}
		
		static UExponentialHeightFogComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ExponentialHeightFogComponent");
			FogDensity__Offset=GetPropertyOffset(NativeClassPtr,"FogDensity");
			FogInscatteringColor__Offset=GetPropertyOffset(NativeClassPtr,"FogInscatteringColor");
			DirectionalInscatteringExponent__Offset=GetPropertyOffset(NativeClassPtr,"DirectionalInscatteringExponent");
			DirectionalInscatteringStartDistance__Offset=GetPropertyOffset(NativeClassPtr,"DirectionalInscatteringStartDistance");
			DirectionalInscatteringColor__Offset=GetPropertyOffset(NativeClassPtr,"DirectionalInscatteringColor");
			FogHeightFalloff__Offset=GetPropertyOffset(NativeClassPtr,"FogHeightFalloff");
			FogMaxOpacity__Offset=GetPropertyOffset(NativeClassPtr,"FogMaxOpacity");
			StartDistance__Offset=GetPropertyOffset(NativeClassPtr,"StartDistance");
			
		}
		
	}
	
}
#endif
#endif
