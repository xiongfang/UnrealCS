#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Default physics settings.</summary>
	public partial class UPhysicsSettings
	{
		static readonly int DefaultGravityZ__Offset;
		/// <summary>Default gravity.</summary>
		public float DefaultGravityZ
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultGravityZ__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultGravityZ__Offset, false);}
			
		}
		
		static readonly int DefaultTerminalVelocity__Offset;
		/// <summary>Default terminal velocity for Physics Volumes.</summary>
		public float DefaultTerminalVelocity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultTerminalVelocity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultTerminalVelocity__Offset, false);}
			
		}
		
		static readonly int DefaultFluidFriction__Offset;
		/// <summary>Default fluid friction for Physics Volumes.</summary>
		public float DefaultFluidFriction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultFluidFriction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultFluidFriction__Offset, false);}
			
		}
		
		static readonly int SimulateScratchMemorySize__Offset;
		/// <summary>Amount of memory to reserve for PhysX simulate(), this is per pxscene and will be rounded up to the next 16K boundary</summary>
		public int SimulateScratchMemorySize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SimulateScratchMemorySize__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SimulateScratchMemorySize__Offset, false);}
			
		}
		
		static readonly int RagdollAggregateThreshold__Offset;
		/// <summary>Threshold for ragdoll bodies above which they will be added to an aggregate before being added to the scene</summary>
		public int RagdollAggregateThreshold
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RagdollAggregateThreshold__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RagdollAggregateThreshold__Offset, false);}
			
		}
		
		static readonly int TriangleMeshTriangleMinAreaThreshold__Offset;
		/// <summary>Triangles from triangle meshes (BSP) with an area less than or equal to this value will be removed from physics collision data. Set to less than 0 to disable.</summary>
		public float TriangleMeshTriangleMinAreaThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TriangleMeshTriangleMinAreaThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TriangleMeshTriangleMinAreaThreshold__Offset, false);}
			
		}
		
		static readonly int bEnableAsyncScene__Offset;
		/// <summary>Enables the use of an async scene</summary>
		public bool bEnableAsyncScene
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableAsyncScene__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableAsyncScene__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bEnableShapeSharing__Offset;
		/// <summary>Enables shape sharing between sync and async scene for static rigid actors</summary>
		public bool bEnableShapeSharing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableShapeSharing__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableShapeSharing__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bEnablePCM__Offset;
		/// <summary>Enables persistent contact manifolds. This will generate fewer contact points, but with more accuracy. Reduces stability of stacking, but can help energy conservation.</summary>
		public bool bEnablePCM
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnablePCM__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnablePCM__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bWarnMissingLocks__Offset;
		/// <summary>Whether to warn when physics locks are used incorrectly. Turning this off is not recommended and should only be used by very advanced users.</summary>
		public bool bWarnMissingLocks
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWarnMissingLocks__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bWarnMissingLocks__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bEnable2DPhysics__Offset;
		/// <summary>Can 2D physics be used (Box2D)?</summary>
		public bool bEnable2DPhysics
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnable2DPhysics__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnable2DPhysics__Offset, 1,0,1,255);}
			
		}
		
		static readonly int LockedAxis__Offset;
		public ESettingsLockedAxis LockedAxis
		{
			get{ CheckIsValid();return (ESettingsLockedAxis)Marshal.PtrToStructure(_this.Get()+LockedAxis__Offset, typeof(ESettingsLockedAxis));}
			
		}
		
		static readonly int DefaultDegreesOfFreedom__Offset;
		/// <summary>Useful for constraining all objects in the world, for example if you are making a 2D game using 3D environments.</summary>
		public ESettingsDOF DefaultDegreesOfFreedom
		{
			get{ CheckIsValid();return (ESettingsDOF)Marshal.PtrToStructure(_this.Get()+DefaultDegreesOfFreedom__Offset, typeof(ESettingsDOF));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultDegreesOfFreedom__Offset, false);}
			
		}
		
		static readonly int BounceThresholdVelocity__Offset;
		/// <summary>Minimum relative velocity required for an object to bounce. A typical value for simulation stability is about 0.2 * gravity</summary>
		public float BounceThresholdVelocity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BounceThresholdVelocity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BounceThresholdVelocity__Offset, false);}
			
		}
		
		static readonly int FrictionCombineMode__Offset;
		/// <summary>Friction combine mode, controls how friction is computed for multiple materials.</summary>
		public EFrictionCombineMode FrictionCombineMode
		{
			get{ CheckIsValid();return (EFrictionCombineMode)Marshal.PtrToStructure(_this.Get()+FrictionCombineMode__Offset, typeof(EFrictionCombineMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FrictionCombineMode__Offset, false);}
			
		}
		
		static readonly int RestitutionCombineMode__Offset;
		/// <summary>Restitution combine mode, controls how restitution is computed for multiple materials.</summary>
		public EFrictionCombineMode RestitutionCombineMode
		{
			get{ CheckIsValid();return (EFrictionCombineMode)Marshal.PtrToStructure(_this.Get()+RestitutionCombineMode__Offset, typeof(EFrictionCombineMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RestitutionCombineMode__Offset, false);}
			
		}
		
		static readonly int MaxAngularVelocity__Offset;
		/// <summary>Max angular velocity that a simulated object can achieve.</summary>
		public float MaxAngularVelocity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxAngularVelocity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxAngularVelocity__Offset, false);}
			
		}
		
		static readonly int MaxDepenetrationVelocity__Offset;
		/// <summary>Max velocity which may be used to depenetrate simulated physics objects. 0 means no maximum.</summary>
		public float MaxDepenetrationVelocity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDepenetrationVelocity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDepenetrationVelocity__Offset, false);}
			
		}
		
		static readonly int ContactOffsetMultiplier__Offset;
		/// <summary>Contact offset multiplier. When creating a physics shape we look at its bounding volume and multiply its minimum value by this multiplier. A bigger number will generate contact points earlier which results in higher stability at the cost of performance.</summary>
		public float ContactOffsetMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ContactOffsetMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ContactOffsetMultiplier__Offset, false);}
			
		}
		
		static readonly int MinContactOffset__Offset;
		/// <summary>Min Contact offset.</summary>
		public float MinContactOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinContactOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinContactOffset__Offset, false);}
			
		}
		
		static readonly int MaxContactOffset__Offset;
		/// <summary>Max Contact offset.</summary>
		public float MaxContactOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxContactOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxContactOffset__Offset, false);}
			
		}
		
		static readonly int bSimulateSkeletalMeshOnDedicatedServer__Offset;
		/// <summary>
		/// If true, simulate physics for this component on a dedicated server.
		/// This should be set if simulating physics and replicating with a dedicated server.
		/// </summary>
		public bool bSimulateSkeletalMeshOnDedicatedServer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSimulateSkeletalMeshOnDedicatedServer__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSimulateSkeletalMeshOnDedicatedServer__Offset, 1,0,1,255);}
			
		}
		
		static readonly int DefaultShapeComplexity__Offset;
		/// <summary>Determines the default physics shape complexity.</summary>
		public ECollisionTraceFlag DefaultShapeComplexity
		{
			get{ CheckIsValid();return (ECollisionTraceFlag)Marshal.PtrToStructure(_this.Get()+DefaultShapeComplexity__Offset, typeof(ECollisionTraceFlag));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultShapeComplexity__Offset, false);}
			
		}
		
		static readonly int bDefaultHasComplexCollision__Offset;
		/// <summary>If true, static meshes will use per poly collision as complex collision by default. If false the default behavior is the same as UseSimpleAsComplex.</summary>
		public bool bDefaultHasComplexCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultHasComplexCollision__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bSuppressFaceRemapTable__Offset;
		/// <summary>If true, the internal physx face to UE face mapping will not be generated. This is a memory optimization available if you do not rely on face indices returned by scene queries.</summary>
		public bool bSuppressFaceRemapTable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSuppressFaceRemapTable__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSuppressFaceRemapTable__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bSupportUVFromHitResults__Offset;
		/// <summary>If true, store extra information to allow FindCollisionUV to derive UV info from a line trace hit result, using the FindCollisionUV utility</summary>
		public bool bSupportUVFromHitResults
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportUVFromHitResults__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSupportUVFromHitResults__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bDisableActiveActors__Offset;
		/// <summary>If true, physx will not update unreal with any bodies that have moved during the simulation. This should only be used if you have no physx simulation or you are manually updating the unreal data via polling physx.</summary>
		public bool bDisableActiveActors
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableActiveActors__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableActiveActors__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bDisableCCD__Offset;
		/// <summary>If true CCD will be ignored. This is an optimization when CCD is never used which removes the need for physx to check it internally.</summary>
		public bool bDisableCCD
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableCCD__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableCCD__Offset, 1,0,1,255);}
			
		}
		
		static readonly int MaxPhysicsDeltaTime__Offset;
		/// <summary>Max Physics Delta Time to be clamped.</summary>
		public float MaxPhysicsDeltaTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxPhysicsDeltaTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxPhysicsDeltaTime__Offset, false);}
			
		}
		
		static readonly int bSubstepping__Offset;
		/// <summary>Whether to substep the physics simulation. This feature is still experimental. Certain functionality might not work correctly</summary>
		public bool bSubstepping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSubstepping__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSubstepping__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bSubsteppingAsync__Offset;
		/// <summary>Whether to substep the async physics simulation. This feature is still experimental. Certain functionality might not work correctly</summary>
		public bool bSubsteppingAsync
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSubsteppingAsync__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSubsteppingAsync__Offset, 1,0,1,255);}
			
		}
		
		static readonly int MaxSubstepDeltaTime__Offset;
		/// <summary>Max delta time (in seconds) for an individual simulation substep.</summary>
		public float MaxSubstepDeltaTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSubstepDeltaTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSubstepDeltaTime__Offset, false);}
			
		}
		
		static readonly int MaxSubsteps__Offset;
		/// <summary>Max number of substeps for physics simulation.</summary>
		public int MaxSubsteps
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxSubsteps__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSubsteps__Offset, false);}
			
		}
		
		static readonly int SyncSceneSmoothingFactor__Offset;
		/// <summary>Physics delta time smoothing factor for sync scene.</summary>
		public float SyncSceneSmoothingFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SyncSceneSmoothingFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SyncSceneSmoothingFactor__Offset, false);}
			
		}
		
		static readonly int AsyncSceneSmoothingFactor__Offset;
		/// <summary>Physics delta time smoothing factor for async scene.</summary>
		public float AsyncSceneSmoothingFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AsyncSceneSmoothingFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AsyncSceneSmoothingFactor__Offset, false);}
			
		}
		
		static readonly int InitialAverageFrameRate__Offset;
		/// <summary>Physics delta time initial average.</summary>
		public float InitialAverageFrameRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialAverageFrameRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialAverageFrameRate__Offset, false);}
			
		}
		
		static readonly int PhysicalSurfaces__Offset;
		/// <summary>PhysicalMaterial Surface Types</summary>
		public TStructArray<FPhysicalSurfaceName> PhysicalSurfaces
		{
			get{ CheckIsValid();return new TStructArray<FPhysicalSurfaceName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PhysicalSurfaces__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PhysicalSurfaces__Offset, false);}
			
		}
		
		static UPhysicsSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PhysicsSettings");
			DefaultGravityZ__Offset=GetPropertyOffset(NativeClassPtr,"DefaultGravityZ");
			DefaultTerminalVelocity__Offset=GetPropertyOffset(NativeClassPtr,"DefaultTerminalVelocity");
			DefaultFluidFriction__Offset=GetPropertyOffset(NativeClassPtr,"DefaultFluidFriction");
			SimulateScratchMemorySize__Offset=GetPropertyOffset(NativeClassPtr,"SimulateScratchMemorySize");
			RagdollAggregateThreshold__Offset=GetPropertyOffset(NativeClassPtr,"RagdollAggregateThreshold");
			TriangleMeshTriangleMinAreaThreshold__Offset=GetPropertyOffset(NativeClassPtr,"TriangleMeshTriangleMinAreaThreshold");
			bEnableAsyncScene__Offset=GetPropertyOffset(NativeClassPtr,"bEnableAsyncScene");
			bEnableShapeSharing__Offset=GetPropertyOffset(NativeClassPtr,"bEnableShapeSharing");
			bEnablePCM__Offset=GetPropertyOffset(NativeClassPtr,"bEnablePCM");
			bWarnMissingLocks__Offset=GetPropertyOffset(NativeClassPtr,"bWarnMissingLocks");
			bEnable2DPhysics__Offset=GetPropertyOffset(NativeClassPtr,"bEnable2DPhysics");
			LockedAxis__Offset=GetPropertyOffset(NativeClassPtr,"LockedAxis");
			DefaultDegreesOfFreedom__Offset=GetPropertyOffset(NativeClassPtr,"DefaultDegreesOfFreedom");
			BounceThresholdVelocity__Offset=GetPropertyOffset(NativeClassPtr,"BounceThresholdVelocity");
			FrictionCombineMode__Offset=GetPropertyOffset(NativeClassPtr,"FrictionCombineMode");
			RestitutionCombineMode__Offset=GetPropertyOffset(NativeClassPtr,"RestitutionCombineMode");
			MaxAngularVelocity__Offset=GetPropertyOffset(NativeClassPtr,"MaxAngularVelocity");
			MaxDepenetrationVelocity__Offset=GetPropertyOffset(NativeClassPtr,"MaxDepenetrationVelocity");
			ContactOffsetMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"ContactOffsetMultiplier");
			MinContactOffset__Offset=GetPropertyOffset(NativeClassPtr,"MinContactOffset");
			MaxContactOffset__Offset=GetPropertyOffset(NativeClassPtr,"MaxContactOffset");
			bSimulateSkeletalMeshOnDedicatedServer__Offset=GetPropertyOffset(NativeClassPtr,"bSimulateSkeletalMeshOnDedicatedServer");
			DefaultShapeComplexity__Offset=GetPropertyOffset(NativeClassPtr,"DefaultShapeComplexity");
			bDefaultHasComplexCollision__Offset=GetPropertyOffset(NativeClassPtr,"bDefaultHasComplexCollision");
			bSuppressFaceRemapTable__Offset=GetPropertyOffset(NativeClassPtr,"bSuppressFaceRemapTable");
			bSupportUVFromHitResults__Offset=GetPropertyOffset(NativeClassPtr,"bSupportUVFromHitResults");
			bDisableActiveActors__Offset=GetPropertyOffset(NativeClassPtr,"bDisableActiveActors");
			bDisableCCD__Offset=GetPropertyOffset(NativeClassPtr,"bDisableCCD");
			MaxPhysicsDeltaTime__Offset=GetPropertyOffset(NativeClassPtr,"MaxPhysicsDeltaTime");
			bSubstepping__Offset=GetPropertyOffset(NativeClassPtr,"bSubstepping");
			bSubsteppingAsync__Offset=GetPropertyOffset(NativeClassPtr,"bSubsteppingAsync");
			MaxSubstepDeltaTime__Offset=GetPropertyOffset(NativeClassPtr,"MaxSubstepDeltaTime");
			MaxSubsteps__Offset=GetPropertyOffset(NativeClassPtr,"MaxSubsteps");
			SyncSceneSmoothingFactor__Offset=GetPropertyOffset(NativeClassPtr,"SyncSceneSmoothingFactor");
			AsyncSceneSmoothingFactor__Offset=GetPropertyOffset(NativeClassPtr,"AsyncSceneSmoothingFactor");
			InitialAverageFrameRate__Offset=GetPropertyOffset(NativeClassPtr,"InitialAverageFrameRate");
			PhysicalSurfaces__Offset=GetPropertyOffset(NativeClassPtr,"PhysicalSurfaces");
			
		}
		
	}
	
}
#endif
#endif
