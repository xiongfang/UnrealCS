using System;
namespace UnrealEngine
{
	public partial class UParticleModuleTypeDataMesh:UParticleModuleTypeDataBase
	{
		/// <summary>The static mesh to render at the particle positions</summary>
		public UStaticMesh Mesh;
		
		/// <summary>If true, has the meshes cast shadows</summary>
		public bool CastShadows;
		
		/// <summary>UNUSED (the collision module dictates doing collisions)</summary>
		public bool DoCollisions;
		
		/// <summary>
		/// The alignment to use on the meshes emitted.
		/// The RequiredModule->ScreenAlignment MUST be set to PSA_TypeSpecific to use.
		/// One of the following:
		/// PSMA_MeshFaceCameraWithRoll
		///         Face the camera allowing for rotation around the mesh-to-camera FVector
		///         (amount provided by the standard particle sprite rotation).
		/// PSMA_MeshFaceCameraWithSpin
		///         Face the camera allowing for the mesh to rotate about the tangential axis.
		/// PSMA_MeshFaceCameraWithLockedAxis
		///         Face the camera while maintaining the up FVector as the locked direction.
		/// </summary>
		public EMeshScreenAlignment MeshAlignment;
		
		/// <summary>
		/// If true, use the emitter material when rendering rather than the one applied
		/// to the static mesh model.
		/// </summary>
		public bool bOverrideMaterial;
		
		public bool bOverrideDefaultMotionBlurSettings;
		
		public bool bEnableMotionBlur;
		
		/// <summary>deprecated properties for initial orientation</summary>
		public float Pitch;
		
		public float Roll;
		
		public float Yaw;
		
		/// <summary>The 'pre' rotation pitch (in degrees) to apply to the static mesh used.</summary>
		public FRawDistributionVector RollPitchYawRange;
		
		/// <summary>
		/// The axis to lock the mesh on. This overrides TypeSpecific mesh alignment as well as the LockAxis module.
		///         EPAL_NONE                -      No locking to an axis.
		///         EPAL_X                   -      Lock the mesh X-axis facing towards +X.
		///         EPAL_Y                   -      Lock the mesh X-axis facing towards +Y.
		///         EPAL_Z                   -      Lock the mesh X-axis facing towards +Z.
		///         EPAL_NEGATIVE_X  -      Lock the mesh X-axis facing towards -X.
		///         EPAL_NEGATIVE_Y  -      Lock the mesh X-axis facing towards -Y.
		///         EPAL_NEGATIVE_Z  -      Lock the mesh X-axis facing towards -Z.
		///         EPAL_ROTATE_X    -      Ignored for mesh emitters. Treated as EPAL_NONE.
		///         EPAL_ROTATE_Y    -      Ignored for mesh emitters. Treated as EPAL_NONE.
		///         EPAL_ROTATE_Z    -      Ignored for mesh emitters. Treated as EPAL_NONE.
		/// </summary>
		public EParticleAxisLock AxisLockOption;
		
		/// <summary>
		/// If true, then point the X-axis of the mesh towards the camera.
		/// When set, AxisLockOption as well as all other locked axis/screen alignment settings are ignored.
		/// </summary>
		public bool bCameraFacing;
		
		/// <summary>
		/// The axis of the mesh to point up when camera facing the X-axis.
		///         CameraFacing_NoneUP                     No attempt to face an axis up or down.
		///         CameraFacing_ZUp                        Z-axis of the mesh should attempt to point up.
		///         CameraFacing_NegativeZUp        Z-axis of the mesh should attempt to point down.
		///         CameraFacing_YUp                        Y-axis of the mesh should attempt to point up.
		///         CameraFacing_NegativeYUp        Y-axis of the mesh should attempt to point down.
		/// </summary>
		public EMeshCameraFacingUpAxis CameraFacingUpAxisOption;
		
		/// <summary>
		/// The camera facing option to use:
		/// All camera facing options without locked axis assume X-axis will be facing the camera.
		///         XAxisFacing_NoUp                                - X-axis camera facing, no attempt to face an axis up or down.
		///         XAxisFacing_ZUp                                 - X-axis camera facing, Z-axis of the mesh should attempt to point up.
		///         XAxisFacing_NegativeZUp                 - X-axis camera facing, Z-axis of the mesh should attempt to point down.
		///         XAxisFacing_YUp                                 - X-axis camera facing, Y-axis of the mesh should attempt to point up.
		///         XAxisFacing_NegativeYUp                 - X-axis camera facing, Y-axis of the mesh should attempt to point down.
		/// All axis-locked camera facing options assume the AxisLockOption is set. EPAL_NONE will be treated as EPAL_X.
		///         LockedAxis_ZAxisFacing                  - X-axis locked on AxisLockOption axis, rotate Z-axis of the mesh to face towards camera.
		///         LockedAxis_NegativeZAxisFacing  - X-axis locked on AxisLockOption axis, rotate Z-axis of the mesh to face away from camera.
		///         LockedAxis_YAxisFacing                  - X-axis locked on AxisLockOption axis, rotate Y-axis of the mesh to face towards camera.
		///         LockedAxis_NegativeYAxisFacing  - X-axis locked on AxisLockOption axis, rotate Y-axis of the mesh to face away from camera.
		/// All velocity-aligned options do NOT require the ScreenAlignment be set to PSA_Velocity.
		/// Doing so will result in additional work being performed... (it will orient the mesh twice).
		///         VelocityAligned_ZAxisFacing         - X-axis aligned to the velocity, rotate the Z-axis of the mesh to face towards camera.
		///         VelocityAligned_NegativeZAxisFacing - X-axis aligned to the velocity, rotate the Z-axis of the mesh to face away from camera.
		///         VelocityAligned_YAxisFacing         - X-axis aligned to the velocity, rotate the Y-axis of the mesh to face towards camera.
		///         VelocityAligned_NegativeYAxisFacing - X-axis aligned to the velocity, rotate the Y-axis of the mesh to face away from camera.
		/// </summary>
		public EMeshCameraFacingOptions CameraFacingOption;
		
		/// <summary>
		/// If true, apply 'sprite' particle rotation about the orientation axis (direction mesh is pointing).
		/// If false, apply 'sprite' particle rotation about the camera facing axis.
		/// </summary>
		public bool bApplyParticleRotationAsSpin;
		
		/// <summary>
		/// If true, all camera facing options will point the mesh against the camera's view direction rather than pointing at the cameras location.
		/// If false, the camera facing will point to the cameras position as normal.
		/// </summary>
		public bool bFaceCameraDirectionRatherThanPosition;
		
		/// <summary>
		/// If true, all collisions for mesh particle on this emitter will take the particle size into account.
		/// If false, particle size will be ignored in collision checks.
		/// </summary>
		public bool bCollisionsConsiderPartilceSize;
		
		
	}
	
}
