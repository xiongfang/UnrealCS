#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USceneCaptureComponent2D
	{
		static readonly int ProjectionType__Offset;
		public ECameraProjectionMode ProjectionType
		{
			get{ CheckIsValid();return (ECameraProjectionMode)Marshal.PtrToStructure(_this.Get()+ProjectionType__Offset, typeof(ECameraProjectionMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ProjectionType__Offset, false);}
			
		}
		
		static readonly int FOVAngle__Offset;
		public float FOVAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FOVAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FOVAngle__Offset, false);}
			
		}
		
		static readonly int OrthoWidth__Offset;
		public float OrthoWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OrthoWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OrthoWidth__Offset, false);}
			
		}
		
		static readonly int TextureTarget__Offset;
		public UTextureRenderTarget2D TextureTarget
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TextureTarget__Offset); if (v == IntPtr.Zero)return null; UTextureRenderTarget2D retValue = new UTextureRenderTarget2D(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + TextureTarget__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + TextureTarget__Offset, value._this.Get()); }
			
		}
		
		static readonly int CaptureSource__Offset;
		public ESceneCaptureSource CaptureSource
		{
			get{ CheckIsValid();return (ESceneCaptureSource)Marshal.PtrToStructure(_this.Get()+CaptureSource__Offset, typeof(ESceneCaptureSource));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CaptureSource__Offset, false);}
			
		}
		
		static readonly int CompositeMode__Offset;
		public ESceneCaptureCompositeMode CompositeMode
		{
			get{ CheckIsValid();return (ESceneCaptureCompositeMode)Marshal.PtrToStructure(_this.Get()+CompositeMode__Offset, typeof(ESceneCaptureCompositeMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CompositeMode__Offset, false);}
			
		}
		
		static readonly int PostProcessSettings__Offset;
		public FPostProcessSettings PostProcessSettings
		{
			get{ CheckIsValid();return (FPostProcessSettings)Marshal.PtrToStructure(_this.Get()+PostProcessSettings__Offset, typeof(FPostProcessSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PostProcessSettings__Offset, false);}
			
		}
		
		static readonly int PostProcessBlendWeight__Offset;
		public float PostProcessBlendWeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PostProcessBlendWeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PostProcessBlendWeight__Offset, false);}
			
		}
		
		static readonly int bUseCustomProjectionMatrix__Offset;
		public bool bUseCustomProjectionMatrix
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseCustomProjectionMatrix__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int CustomProjectionMatrix__Offset;
		public FMatrix CustomProjectionMatrix
		{
			get{ CheckIsValid();return (FMatrix)Marshal.PtrToStructure(_this.Get()+CustomProjectionMatrix__Offset, typeof(FMatrix));}
			
		}
		
		static readonly int bEnableClipPlane__Offset;
		public bool bEnableClipPlane
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableClipPlane__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableClipPlane__Offset, 1,0,1,255);}
			
		}
		
		static readonly int ClipPlaneBase__Offset;
		public FVector ClipPlaneBase
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+ClipPlaneBase__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ClipPlaneBase__Offset, false);}
			
		}
		
		static readonly int ClipPlaneNormal__Offset;
		public FVector ClipPlaneNormal
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+ClipPlaneNormal__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ClipPlaneNormal__Offset, false);}
			
		}
		
		static USceneCaptureComponent2D()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SceneCaptureComponent2D");
			ProjectionType__Offset=GetPropertyOffset(NativeClassPtr,"ProjectionType");
			FOVAngle__Offset=GetPropertyOffset(NativeClassPtr,"FOVAngle");
			OrthoWidth__Offset=GetPropertyOffset(NativeClassPtr,"OrthoWidth");
			TextureTarget__Offset=GetPropertyOffset(NativeClassPtr,"TextureTarget");
			CaptureSource__Offset=GetPropertyOffset(NativeClassPtr,"CaptureSource");
			CompositeMode__Offset=GetPropertyOffset(NativeClassPtr,"CompositeMode");
			PostProcessSettings__Offset=GetPropertyOffset(NativeClassPtr,"PostProcessSettings");
			PostProcessBlendWeight__Offset=GetPropertyOffset(NativeClassPtr,"PostProcessBlendWeight");
			bUseCustomProjectionMatrix__Offset=GetPropertyOffset(NativeClassPtr,"bUseCustomProjectionMatrix");
			CustomProjectionMatrix__Offset=GetPropertyOffset(NativeClassPtr,"CustomProjectionMatrix");
			bEnableClipPlane__Offset=GetPropertyOffset(NativeClassPtr,"bEnableClipPlane");
			ClipPlaneBase__Offset=GetPropertyOffset(NativeClassPtr,"ClipPlaneBase");
			ClipPlaneNormal__Offset=GetPropertyOffset(NativeClassPtr,"ClipPlaneNormal");
			
		}
		
	}
	
}
#endif
#endif
