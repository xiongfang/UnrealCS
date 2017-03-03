#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>UPlanarReflectionComponent</summary>
	public partial class UPlanarReflectionComponent
	{
		static readonly int PreviewBox__Offset;
		public UBoxComponent PreviewBox
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewBox__Offset); if (v == IntPtr.Zero)return null; UBoxComponent retValue = new UBoxComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NormalDistortionStrength__Offset;
		/// <summary>Controls the strength of normals when distorting the planar reflection.</summary>
		public float NormalDistortionStrength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NormalDistortionStrength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NormalDistortionStrength__Offset, false);}
			
		}
		
		static readonly int PrefilterRoughness__Offset;
		/// <summary>The roughness value to prefilter the planar reflection texture with, useful for hiding low resolution.  Larger values have larger GPU cost.</summary>
		public float PrefilterRoughness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PrefilterRoughness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PrefilterRoughness__Offset, false);}
			
		}
		
		static readonly int PrefilterRoughnessDistance__Offset;
		/// <summary>The distance at which the prefilter roughness value will be achieved.</summary>
		public float PrefilterRoughnessDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PrefilterRoughnessDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PrefilterRoughnessDistance__Offset, false);}
			
		}
		
		static readonly int ScreenPercentage__Offset;
		/// <summary>Downsample percent, can be used to reduce GPU time rendering the planar reflection.</summary>
		public int ScreenPercentage
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ScreenPercentage__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ScreenPercentage__Offset, false);}
			
		}
		
		static readonly int ExtraFOV__Offset;
		/// <summary>
		/// Additional FOV used when rendering to the reflection texture.
		/// This is useful when normal distortion is causing reads outside the reflection texture.
		/// Larger values increase rendering thread and GPU cost, as more objects and triangles have to be rendered into the planar reflection.
		/// </summary>
		public float ExtraFOV
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ExtraFOV__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ExtraFOV__Offset, false);}
			
		}
		
		static readonly int DistanceFromPlaneFadeStart__Offset;
		public float DistanceFromPlaneFadeStart
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistanceFromPlaneFadeStart__Offset, typeof(float));}
			
		}
		
		static readonly int DistanceFromPlaneFadeEnd__Offset;
		public float DistanceFromPlaneFadeEnd
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistanceFromPlaneFadeEnd__Offset, typeof(float));}
			
		}
		
		static readonly int DistanceFromPlaneFadeoutStart__Offset;
		/// <summary>Receiving pixels at this distance from the reflection plane will begin to fade out the planar reflection.</summary>
		public float DistanceFromPlaneFadeoutStart
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistanceFromPlaneFadeoutStart__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistanceFromPlaneFadeoutStart__Offset, false);}
			
		}
		
		static readonly int DistanceFromPlaneFadeoutEnd__Offset;
		/// <summary>Receiving pixels at this distance from the reflection plane will have completely faded out the planar reflection.</summary>
		public float DistanceFromPlaneFadeoutEnd
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistanceFromPlaneFadeoutEnd__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistanceFromPlaneFadeoutEnd__Offset, false);}
			
		}
		
		static readonly int AngleFromPlaneFadeStart__Offset;
		/// <summary>Receiving pixels whose normal is at this angle from the reflection plane will begin to fade out the planar reflection.</summary>
		public float AngleFromPlaneFadeStart
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AngleFromPlaneFadeStart__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AngleFromPlaneFadeStart__Offset, false);}
			
		}
		
		static readonly int AngleFromPlaneFadeEnd__Offset;
		/// <summary>Receiving pixels whose normal is at this angle from the reflection plane will have completely faded out the planar reflection.</summary>
		public float AngleFromPlaneFadeEnd
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AngleFromPlaneFadeEnd__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AngleFromPlaneFadeEnd__Offset, false);}
			
		}
		
		static readonly int bRenderSceneTwoSided__Offset;
		/// <summary>
		/// Whether to render the scene as two-sided, which can be useful to hide artifacts where normal distortion would read 'under' an object that has been clipped by the reflection plane.
		/// With this setting enabled, the backfaces of a mesh would be displayed in the clipped region instead of the background which is potentially a bright sky.
		/// Be sure to add the water plane to HiddenActors if enabling this, as the water plane will now block the reflection.
		/// </summary>
		public bool bRenderSceneTwoSided
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderSceneTwoSided__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderSceneTwoSided__Offset, 1,0,1,255);}
			
		}
		
		static UPlanarReflectionComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PlanarReflectionComponent");
			PreviewBox__Offset=GetPropertyOffset(NativeClassPtr,"PreviewBox");
			NormalDistortionStrength__Offset=GetPropertyOffset(NativeClassPtr,"NormalDistortionStrength");
			PrefilterRoughness__Offset=GetPropertyOffset(NativeClassPtr,"PrefilterRoughness");
			PrefilterRoughnessDistance__Offset=GetPropertyOffset(NativeClassPtr,"PrefilterRoughnessDistance");
			ScreenPercentage__Offset=GetPropertyOffset(NativeClassPtr,"ScreenPercentage");
			ExtraFOV__Offset=GetPropertyOffset(NativeClassPtr,"ExtraFOV");
			DistanceFromPlaneFadeStart__Offset=GetPropertyOffset(NativeClassPtr,"DistanceFromPlaneFadeStart");
			DistanceFromPlaneFadeEnd__Offset=GetPropertyOffset(NativeClassPtr,"DistanceFromPlaneFadeEnd");
			DistanceFromPlaneFadeoutStart__Offset=GetPropertyOffset(NativeClassPtr,"DistanceFromPlaneFadeoutStart");
			DistanceFromPlaneFadeoutEnd__Offset=GetPropertyOffset(NativeClassPtr,"DistanceFromPlaneFadeoutEnd");
			AngleFromPlaneFadeStart__Offset=GetPropertyOffset(NativeClassPtr,"AngleFromPlaneFadeStart");
			AngleFromPlaneFadeEnd__Offset=GetPropertyOffset(NativeClassPtr,"AngleFromPlaneFadeEnd");
			bRenderSceneTwoSided__Offset=GetPropertyOffset(NativeClassPtr,"bRenderSceneTwoSided");
			
		}
		
	}
	
}
#endif
#endif
