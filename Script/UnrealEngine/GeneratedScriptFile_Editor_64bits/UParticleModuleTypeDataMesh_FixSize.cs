#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleTypeDataMesh
	{
		static readonly int Mesh__Offset;
		/// <summary>The static mesh to render at the particle positions</summary>
		public UStaticMesh Mesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Mesh__Offset); if (v == IntPtr.Zero)return null; UStaticMesh retValue = new UStaticMesh(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Mesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Mesh__Offset, value._this.Get()); }
			
		}
		
		static readonly int CastShadows__Offset;
		/// <summary>If true, has the meshes cast shadows</summary>
		public bool CastShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CastShadows__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int DoCollisions__Offset;
		/// <summary>UNUSED (the collision module dictates doing collisions)</summary>
		public bool DoCollisions
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), DoCollisions__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int MeshAlignment__Offset;
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
		public EMeshScreenAlignment MeshAlignment
		{
			get{ CheckIsValid();return (EMeshScreenAlignment)Marshal.PtrToStructure(_this.Get()+MeshAlignment__Offset, typeof(EMeshScreenAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MeshAlignment__Offset, false);}
			
		}
		
		static readonly int bOverrideMaterial__Offset;
		/// <summary>
		/// If true, use the emitter material when rendering rather than the one applied
		/// to the static mesh model.
		/// </summary>
		public bool bOverrideMaterial
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideMaterial__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideMaterial__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOverrideDefaultMotionBlurSettings__Offset;
		public bool bOverrideDefaultMotionBlurSettings
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideDefaultMotionBlurSettings__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideDefaultMotionBlurSettings__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bEnableMotionBlur__Offset;
		public bool bEnableMotionBlur
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableMotionBlur__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableMotionBlur__Offset, 1,0,4,4);}
			
		}
		
		static readonly int Pitch__Offset;
		/// <summary>deprecated properties for initial orientation</summary>
		public float Pitch
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Pitch__Offset, typeof(float));}
			
		}
		
		static readonly int Roll__Offset;
		public float Roll
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Roll__Offset, typeof(float));}
			
		}
		
		static readonly int Yaw__Offset;
		public float Yaw
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Yaw__Offset, typeof(float));}
			
		}
		
		static readonly int RollPitchYawRange__Offset;
		/// <summary>The 'pre' rotation pitch (in degrees) to apply to the static mesh used.</summary>
		public FRawDistributionVector RollPitchYawRange
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+RollPitchYawRange__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RollPitchYawRange__Offset, false);}
			
		}
		
		static readonly int AxisLockOption__Offset;
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
		public EParticleAxisLock AxisLockOption
		{
			get{ CheckIsValid();return (EParticleAxisLock)Marshal.PtrToStructure(_this.Get()+AxisLockOption__Offset, typeof(EParticleAxisLock));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AxisLockOption__Offset, false);}
			
		}
		
		static readonly int bCameraFacing__Offset;
		/// <summary>
		/// If true, then point the X-axis of the mesh towards the camera.
		/// When set, AxisLockOption as well as all other locked axis/screen alignment settings are ignored.
		/// </summary>
		public bool bCameraFacing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCameraFacing__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCameraFacing__Offset, 1,0,1,1);}
			
		}
		
		static readonly int CameraFacingUpAxisOption__Offset;
		/// <summary>
		/// The axis of the mesh to point up when camera facing the X-axis.
		///         CameraFacing_NoneUP                     No attempt to face an axis up or down.
		///         CameraFacing_ZUp                        Z-axis of the mesh should attempt to point up.
		///         CameraFacing_NegativeZUp        Z-axis of the mesh should attempt to point down.
		///         CameraFacing_YUp                        Y-axis of the mesh should attempt to point up.
		///         CameraFacing_NegativeYUp        Y-axis of the mesh should attempt to point down.
		/// </summary>
		public EMeshCameraFacingUpAxis CameraFacingUpAxisOption
		{
			get{ CheckIsValid();return (EMeshCameraFacingUpAxis)Marshal.PtrToStructure(_this.Get()+CameraFacingUpAxisOption__Offset, typeof(EMeshCameraFacingUpAxis));}
			
		}
		
		static readonly int CameraFacingOption__Offset;
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
		public EMeshCameraFacingOptions CameraFacingOption
		{
			get{ CheckIsValid();return (EMeshCameraFacingOptions)Marshal.PtrToStructure(_this.Get()+CameraFacingOption__Offset, typeof(EMeshCameraFacingOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CameraFacingOption__Offset, false);}
			
		}
		
		static readonly int bApplyParticleRotationAsSpin__Offset;
		/// <summary>
		/// If true, apply 'sprite' particle rotation about the orientation axis (direction mesh is pointing).
		/// If false, apply 'sprite' particle rotation about the camera facing axis.
		/// </summary>
		public bool bApplyParticleRotationAsSpin
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bApplyParticleRotationAsSpin__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bApplyParticleRotationAsSpin__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bFaceCameraDirectionRatherThanPosition__Offset;
		/// <summary>
		/// If true, all camera facing options will point the mesh against the camera's view direction rather than pointing at the cameras location.
		/// If false, the camera facing will point to the cameras position as normal.
		/// </summary>
		public bool bFaceCameraDirectionRatherThanPosition
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFaceCameraDirectionRatherThanPosition__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFaceCameraDirectionRatherThanPosition__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bCollisionsConsiderPartilceSize__Offset;
		/// <summary>
		/// If true, all collisions for mesh particle on this emitter will take the particle size into account.
		/// If false, particle size will be ignored in collision checks.
		/// </summary>
		public bool bCollisionsConsiderPartilceSize
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCollisionsConsiderPartilceSize__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCollisionsConsiderPartilceSize__Offset, 1,0,4,4);}
			
		}
		
		static UParticleModuleTypeDataMesh()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleTypeDataMesh");
			Mesh__Offset=GetPropertyOffset(NativeClassPtr,"Mesh");
			CastShadows__Offset=GetPropertyOffset(NativeClassPtr,"CastShadows");
			DoCollisions__Offset=GetPropertyOffset(NativeClassPtr,"DoCollisions");
			MeshAlignment__Offset=GetPropertyOffset(NativeClassPtr,"MeshAlignment");
			bOverrideMaterial__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideMaterial");
			bOverrideDefaultMotionBlurSettings__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideDefaultMotionBlurSettings");
			bEnableMotionBlur__Offset=GetPropertyOffset(NativeClassPtr,"bEnableMotionBlur");
			Pitch__Offset=GetPropertyOffset(NativeClassPtr,"Pitch");
			Roll__Offset=GetPropertyOffset(NativeClassPtr,"Roll");
			Yaw__Offset=GetPropertyOffset(NativeClassPtr,"Yaw");
			RollPitchYawRange__Offset=GetPropertyOffset(NativeClassPtr,"RollPitchYawRange");
			AxisLockOption__Offset=GetPropertyOffset(NativeClassPtr,"AxisLockOption");
			bCameraFacing__Offset=GetPropertyOffset(NativeClassPtr,"bCameraFacing");
			CameraFacingUpAxisOption__Offset=GetPropertyOffset(NativeClassPtr,"CameraFacingUpAxisOption");
			CameraFacingOption__Offset=GetPropertyOffset(NativeClassPtr,"CameraFacingOption");
			bApplyParticleRotationAsSpin__Offset=GetPropertyOffset(NativeClassPtr,"bApplyParticleRotationAsSpin");
			bFaceCameraDirectionRatherThanPosition__Offset=GetPropertyOffset(NativeClassPtr,"bFaceCameraDirectionRatherThanPosition");
			bCollisionsConsiderPartilceSize__Offset=GetPropertyOffset(NativeClassPtr,"bCollisionsConsiderPartilceSize");
			
		}
		
	}
	
}
#endif
#endif
