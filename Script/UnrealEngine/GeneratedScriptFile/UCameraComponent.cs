using System;
namespace UnrealEngine
{
	public partial class UCameraComponent:USceneComponent
	{
		/// <summary>
		/// Returns camera's Point of View.
		/// Called by Camera class. Subclass and postprocess to add any effects.
		/// </summary>
		public extern virtual void GetCameraView(float DeltaTime,out FMinimalViewInfo DesiredView);
		public extern void SetPostProcessBlendWeight(float InPostProcessBlendWeight);
		public extern void SetProjectionMode(ECameraProjectionMode InProjectionMode);
		public extern void SetUseFieldOfViewForLOD(bool bInUseFieldOfViewForLOD);
		public extern void SetConstraintAspectRatio(bool bInConstrainAspectRatio);
		public extern void SetAspectRatio(float InAspectRatio);
		public extern void SetOrthoFarClipPlane(float InOrthoFarClipPlane);
		public extern void SetOrthoNearClipPlane(float InOrthoNearClipPlane);
		public extern void SetOrthoWidth(float InOrthoWidth);
		public extern void SetFieldOfView(float InFieldOfView);
		/// <summary>The horizontal field of view (in degrees) in perspective mode (ignored in Orthographic mode)</summary>
		public float FieldOfView;
		
		/// <summary>The desired width (in world units) of the orthographic view (ignored in Perspective mode)</summary>
		public float OrthoWidth;
		
		/// <summary>The near plane distance of the orthographic view (in world units)</summary>
		public float OrthoNearClipPlane;
		
		/// <summary>The far plane distance of the orthographic view (in world units)</summary>
		public float OrthoFarClipPlane;
		
		/// <summary>Aspect Ratio (Width/Height)</summary>
		public float AspectRatio;
		
		/// <summary>If bConstrainAspectRatio is true, black bars will be added if the destination view has a different aspect ratio than this camera requested.</summary>
		public bool bConstrainAspectRatio;
		
		/// <summary>If true, account for the field of view angle when computing which level of detail to use for meshes.</summary>
		public bool bUseFieldOfViewForLOD;
		
		/// <summary>True if the camera's orientation and position should be locked to the HMD</summary>
		public bool bLockToHmd;
		
		/// <summary>
		/// If this camera component is placed on a pawn, should it use the view/control rotation of the pawn where possible?
		/// @see APawn::GetViewRotation()
		/// </summary>
		public bool bUsePawnControlRotation;
		
		/// <summary>The type of camera</summary>
		public ECameraProjectionMode ProjectionMode;
		
		/// <summary>Indicates if PostProcessSettings should be used when using this Camera to view through.</summary>
		public float PostProcessBlendWeight;
		
		/// <summary>Post process settings to use for this camera. Don't forget to check the properties you want to override</summary>
		public FPostProcessSettings PostProcessSettings;
		
		public UStaticMesh CameraMesh;
		
		/// <summary>DEPRECATED: use bUsePawnControlRotation instead</summary>
		public bool bUseControllerViewRotation;
		
		
	}
	
}
