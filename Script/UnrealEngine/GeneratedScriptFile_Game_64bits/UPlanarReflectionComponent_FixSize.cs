#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPlanarReflectionComponent
	{
		static readonly int PreviewBox__Offset;
		public UBoxComponent PreviewBox
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewBox__Offset); if (v == IntPtr.Zero)return null; UBoxComponent retValue = new UBoxComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NormalDistortionStrength__Offset;
		public float NormalDistortionStrength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NormalDistortionStrength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NormalDistortionStrength__Offset, false);}
			
		}
		
		static readonly int PrefilterRoughness__Offset;
		public float PrefilterRoughness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PrefilterRoughness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PrefilterRoughness__Offset, false);}
			
		}
		
		static readonly int PrefilterRoughnessDistance__Offset;
		public float PrefilterRoughnessDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PrefilterRoughnessDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PrefilterRoughnessDistance__Offset, false);}
			
		}
		
		static readonly int ScreenPercentage__Offset;
		public int ScreenPercentage
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ScreenPercentage__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ScreenPercentage__Offset, false);}
			
		}
		
		static readonly int ExtraFOV__Offset;
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
		public float DistanceFromPlaneFadeoutStart
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistanceFromPlaneFadeoutStart__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistanceFromPlaneFadeoutStart__Offset, false);}
			
		}
		
		static readonly int DistanceFromPlaneFadeoutEnd__Offset;
		public float DistanceFromPlaneFadeoutEnd
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistanceFromPlaneFadeoutEnd__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistanceFromPlaneFadeoutEnd__Offset, false);}
			
		}
		
		static readonly int AngleFromPlaneFadeStart__Offset;
		public float AngleFromPlaneFadeStart
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AngleFromPlaneFadeStart__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AngleFromPlaneFadeStart__Offset, false);}
			
		}
		
		static readonly int AngleFromPlaneFadeEnd__Offset;
		public float AngleFromPlaneFadeEnd
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AngleFromPlaneFadeEnd__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AngleFromPlaneFadeEnd__Offset, false);}
			
		}
		
		static readonly int bRenderSceneTwoSided__Offset;
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
