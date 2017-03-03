#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ULightComponentBase
	{
		static readonly int LightGuid__Offset;
		/// <summary>
		/// GUID used to associate a light component with precomputed shadowing information across levels.
		/// The GUID changes whenever the light position changes.
		/// </summary>
		public FGuid LightGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+LightGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int Brightness__Offset;
		public float Brightness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Brightness__Offset, typeof(float));}
			
		}
		
		static readonly int Intensity__Offset;
		/// <summary>
		/// Total energy that the light emits.
		/// For point/spot lights with inverse squared falloff, this is in units of lumens.  1700 lumens corresponds to a 100W lightbulb.
		/// For other lights, this is just a brightness multiplier.
		/// </summary>
		public float Intensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Intensity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Intensity__Offset, false);}
			
		}
		
		static readonly int LightColor__Offset;
		/// <summary>
		/// Filter color of the light.
		/// Note that this can change the light's effective intensity.
		/// </summary>
		public FColor LightColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+LightColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightColor__Offset, false);}
			
		}
		
		static readonly int bAffectsWorld__Offset;
		/// <summary>
		/// Whether the light can affect the world, or whether it is disabled.
		/// A disabled light will not contribute to the scene in any way.  This setting cannot be changed at runtime and unbuilds lighting when changed.
		/// Setting this to false has the same effect as deleting the light, so it is useful for non-destructive experiments.
		/// </summary>
		public bool bAffectsWorld
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectsWorld__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectsWorld__Offset, 1,0,1,1);}
			
		}
		
		static readonly int CastShadows__Offset;
		/// <summary>Whether the light should cast any shadows.</summary>
		public bool CastShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CastShadows__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), CastShadows__Offset, 1,0,2,2);}
			
		}
		
		static readonly int CastStaticShadows__Offset;
		/// <summary>Whether the light should cast shadows from static objects.  Also requires Cast Shadows to be set to True.</summary>
		public bool CastStaticShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CastStaticShadows__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), CastStaticShadows__Offset, 1,0,4,4);}
			
		}
		
		static readonly int CastDynamicShadows__Offset;
		/// <summary>Whether the light should cast shadows from dynamic objects.  Also requires Cast Shadows to be set to True.</summary>
		public bool CastDynamicShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CastDynamicShadows__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), CastDynamicShadows__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bAffectTranslucentLighting__Offset;
		/// <summary>Whether the light affects translucency or not.  Disabling this can save GPU time when there are many small lights.</summary>
		public bool bAffectTranslucentLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectTranslucentLighting__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectTranslucentLighting__Offset, 1,0,16,16);}
			
		}
		
		static readonly int IndirectLightingIntensity__Offset;
		/// <summary>
		/// Scales the indirect lighting contribution from this light.
		/// A value of 0 disables any GI from this light. Default is 1.
		/// </summary>
		public float IndirectLightingIntensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+IndirectLightingIntensity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+IndirectLightingIntensity__Offset, false);}
			
		}
		
		static readonly int StaticEditorTexture__Offset;
		/// <summary>Sprite for static light in the editor.</summary>
		public UTexture2D StaticEditorTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + StaticEditorTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int StaticEditorTextureScale__Offset;
		/// <summary>Sprite scaling for static light in the editor.</summary>
		public float StaticEditorTextureScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StaticEditorTextureScale__Offset, typeof(float));}
			
		}
		
		static readonly int DynamicEditorTexture__Offset;
		/// <summary>Sprite for dynamic light in the editor.</summary>
		public UTexture2D DynamicEditorTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DynamicEditorTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DynamicEditorTextureScale__Offset;
		/// <summary>Sprite scaling for dynamic light in the editor.</summary>
		public float DynamicEditorTextureScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DynamicEditorTextureScale__Offset, typeof(float));}
			
		}
		
		static ULightComponentBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LightComponentBase");
			LightGuid__Offset=GetPropertyOffset(NativeClassPtr,"LightGuid");
			Brightness__Offset=GetPropertyOffset(NativeClassPtr,"Brightness");
			Intensity__Offset=GetPropertyOffset(NativeClassPtr,"Intensity");
			LightColor__Offset=GetPropertyOffset(NativeClassPtr,"LightColor");
			bAffectsWorld__Offset=GetPropertyOffset(NativeClassPtr,"bAffectsWorld");
			CastShadows__Offset=GetPropertyOffset(NativeClassPtr,"CastShadows");
			CastStaticShadows__Offset=GetPropertyOffset(NativeClassPtr,"CastStaticShadows");
			CastDynamicShadows__Offset=GetPropertyOffset(NativeClassPtr,"CastDynamicShadows");
			bAffectTranslucentLighting__Offset=GetPropertyOffset(NativeClassPtr,"bAffectTranslucentLighting");
			IndirectLightingIntensity__Offset=GetPropertyOffset(NativeClassPtr,"IndirectLightingIntensity");
			StaticEditorTexture__Offset=GetPropertyOffset(NativeClassPtr,"StaticEditorTexture");
			StaticEditorTextureScale__Offset=GetPropertyOffset(NativeClassPtr,"StaticEditorTextureScale");
			DynamicEditorTexture__Offset=GetPropertyOffset(NativeClassPtr,"DynamicEditorTexture");
			DynamicEditorTextureScale__Offset=GetPropertyOffset(NativeClassPtr,"DynamicEditorTextureScale");
			
		}
		
	}
	
}
#endif
#endif
