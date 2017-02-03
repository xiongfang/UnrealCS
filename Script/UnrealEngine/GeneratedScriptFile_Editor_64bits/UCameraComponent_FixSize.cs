#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Represents a camera viewpoint and settings, such as projection type, field of view, and post-process overrides.
	/// The default behavior for an actor used as the camera view target is to look for an attached camera component and use its location, rotation, and settings.
	/// </summary>
	public partial class UCameraComponent
	{
		static readonly int FieldOfView__Offset;
		/// <summary>The horizontal field of view (in degrees) in perspective mode (ignored in Orthographic mode)</summary>
		public float FieldOfView
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FieldOfView__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FieldOfView__Offset, false);}
			
		}
		
		static readonly int OrthoWidth__Offset;
		/// <summary>The desired width (in world units) of the orthographic view (ignored in Perspective mode)</summary>
		public float OrthoWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OrthoWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OrthoWidth__Offset, false);}
			
		}
		
		static readonly int OrthoNearClipPlane__Offset;
		/// <summary>The near plane distance of the orthographic view (in world units)</summary>
		public float OrthoNearClipPlane
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OrthoNearClipPlane__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OrthoNearClipPlane__Offset, false);}
			
		}
		
		static readonly int OrthoFarClipPlane__Offset;
		/// <summary>The far plane distance of the orthographic view (in world units)</summary>
		public float OrthoFarClipPlane
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OrthoFarClipPlane__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OrthoFarClipPlane__Offset, false);}
			
		}
		
		static readonly int AspectRatio__Offset;
		/// <summary>Aspect Ratio (Width/Height)</summary>
		public float AspectRatio
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AspectRatio__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AspectRatio__Offset, false);}
			
		}
		
		static readonly int bConstrainAspectRatio__Offset;
		/// <summary>If bConstrainAspectRatio is true, black bars will be added if the destination view has a different aspect ratio than this camera requested.</summary>
		public bool bConstrainAspectRatio
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bConstrainAspectRatio__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bConstrainAspectRatio__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUseFieldOfViewForLOD__Offset;
		/// <summary>If true, account for the field of view angle when computing which level of detail to use for meshes.</summary>
		public bool bUseFieldOfViewForLOD
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseFieldOfViewForLOD__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseFieldOfViewForLOD__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bLockToHmd__Offset;
		/// <summary>True if the camera's orientation and position should be locked to the HMD</summary>
		public bool bLockToHmd
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockToHmd__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLockToHmd__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bUsePawnControlRotation__Offset;
		/// <summary>
		/// If this camera component is placed on a pawn, should it use the view/control rotation of the pawn where possible?
		/// @see APawn::GetViewRotation()
		/// </summary>
		public bool bUsePawnControlRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsePawnControlRotation__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsePawnControlRotation__Offset, 1,0,8,8);}
			
		}
		
		static readonly int ProjectionMode__Offset;
		/// <summary>The type of camera</summary>
		public ECameraProjectionMode ProjectionMode
		{
			get{ CheckIsValid();return (ECameraProjectionMode)Marshal.PtrToStructure(_this.Get()+ProjectionMode__Offset, typeof(ECameraProjectionMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ProjectionMode__Offset, false);}
			
		}
		
		static readonly int PostProcessBlendWeight__Offset;
		/// <summary>Indicates if PostProcessSettings should be used when using this Camera to view through.</summary>
		public float PostProcessBlendWeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PostProcessBlendWeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PostProcessBlendWeight__Offset, false);}
			
		}
		
		static readonly int PostProcessSettings__Offset;
		/// <summary>Post process settings to use for this camera. Don't forget to check the properties you want to override</summary>
		public FPostProcessSettings PostProcessSettings
		{
			get{ CheckIsValid();return (FPostProcessSettings)Marshal.PtrToStructure(_this.Get()+PostProcessSettings__Offset, typeof(FPostProcessSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PostProcessSettings__Offset, false);}
			
		}
		
		static readonly int CameraMesh__Offset;
		public UStaticMesh CameraMesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CameraMesh__Offset); if (v == IntPtr.Zero)return null; UStaticMesh retValue = new UStaticMesh(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bUseControllerViewRotation__Offset;
		/// <summary>DEPRECATED: use bUsePawnControlRotation instead</summary>
		public bool bUseControllerViewRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseControllerViewRotation__Offset, 1, 0, 1, 1);}
			
		}
		
		static UCameraComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CameraComponent");
			FieldOfView__Offset=GetPropertyOffset(NativeClassPtr,"FieldOfView");
			OrthoWidth__Offset=GetPropertyOffset(NativeClassPtr,"OrthoWidth");
			OrthoNearClipPlane__Offset=GetPropertyOffset(NativeClassPtr,"OrthoNearClipPlane");
			OrthoFarClipPlane__Offset=GetPropertyOffset(NativeClassPtr,"OrthoFarClipPlane");
			AspectRatio__Offset=GetPropertyOffset(NativeClassPtr,"AspectRatio");
			bConstrainAspectRatio__Offset=GetPropertyOffset(NativeClassPtr,"bConstrainAspectRatio");
			bUseFieldOfViewForLOD__Offset=GetPropertyOffset(NativeClassPtr,"bUseFieldOfViewForLOD");
			bLockToHmd__Offset=GetPropertyOffset(NativeClassPtr,"bLockToHmd");
			bUsePawnControlRotation__Offset=GetPropertyOffset(NativeClassPtr,"bUsePawnControlRotation");
			ProjectionMode__Offset=GetPropertyOffset(NativeClassPtr,"ProjectionMode");
			PostProcessBlendWeight__Offset=GetPropertyOffset(NativeClassPtr,"PostProcessBlendWeight");
			PostProcessSettings__Offset=GetPropertyOffset(NativeClassPtr,"PostProcessSettings");
			CameraMesh__Offset=GetPropertyOffset(NativeClassPtr,"CameraMesh");
			bUseControllerViewRotation__Offset=GetPropertyOffset(NativeClassPtr,"bUseControllerViewRotation");
			
		}
		
	}
	
}
#endif
#endif
