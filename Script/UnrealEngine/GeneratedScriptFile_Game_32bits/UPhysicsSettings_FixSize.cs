#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPhysicsSettings
	{
		static readonly int DefaultGravityZ__Offset;
		public float DefaultGravityZ
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultGravityZ__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultGravityZ__Offset, false);}
			
		}
		
		static readonly int DefaultTerminalVelocity__Offset;
		public float DefaultTerminalVelocity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultTerminalVelocity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultTerminalVelocity__Offset, false);}
			
		}
		
		static readonly int DefaultFluidFriction__Offset;
		public float DefaultFluidFriction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultFluidFriction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultFluidFriction__Offset, false);}
			
		}
		
		static readonly int SimulateScratchMemorySize__Offset;
		public int SimulateScratchMemorySize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SimulateScratchMemorySize__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SimulateScratchMemorySize__Offset, false);}
			
		}
		
		static readonly int RagdollAggregateThreshold__Offset;
		public int RagdollAggregateThreshold
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RagdollAggregateThreshold__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RagdollAggregateThreshold__Offset, false);}
			
		}
		
		static readonly int TriangleMeshTriangleMinAreaThreshold__Offset;
		public float TriangleMeshTriangleMinAreaThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TriangleMeshTriangleMinAreaThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TriangleMeshTriangleMinAreaThreshold__Offset, false);}
			
		}
		
		static readonly int bEnableAsyncScene__Offset;
		public bool bEnableAsyncScene
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableAsyncScene__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableAsyncScene__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bEnableShapeSharing__Offset;
		public bool bEnableShapeSharing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableShapeSharing__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableShapeSharing__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bEnablePCM__Offset;
		public bool bEnablePCM
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnablePCM__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnablePCM__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bWarnMissingLocks__Offset;
		public bool bWarnMissingLocks
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWarnMissingLocks__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bWarnMissingLocks__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bEnable2DPhysics__Offset;
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
		public ESettingsDOF DefaultDegreesOfFreedom
		{
			get{ CheckIsValid();return (ESettingsDOF)Marshal.PtrToStructure(_this.Get()+DefaultDegreesOfFreedom__Offset, typeof(ESettingsDOF));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultDegreesOfFreedom__Offset, false);}
			
		}
		
		static readonly int BounceThresholdVelocity__Offset;
		public float BounceThresholdVelocity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BounceThresholdVelocity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BounceThresholdVelocity__Offset, false);}
			
		}
		
		static readonly int FrictionCombineMode__Offset;
		public EFrictionCombineMode FrictionCombineMode
		{
			get{ CheckIsValid();return (EFrictionCombineMode)Marshal.PtrToStructure(_this.Get()+FrictionCombineMode__Offset, typeof(EFrictionCombineMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FrictionCombineMode__Offset, false);}
			
		}
		
		static readonly int RestitutionCombineMode__Offset;
		public EFrictionCombineMode RestitutionCombineMode
		{
			get{ CheckIsValid();return (EFrictionCombineMode)Marshal.PtrToStructure(_this.Get()+RestitutionCombineMode__Offset, typeof(EFrictionCombineMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RestitutionCombineMode__Offset, false);}
			
		}
		
		static readonly int MaxAngularVelocity__Offset;
		public float MaxAngularVelocity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxAngularVelocity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxAngularVelocity__Offset, false);}
			
		}
		
		static readonly int MaxDepenetrationVelocity__Offset;
		public float MaxDepenetrationVelocity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDepenetrationVelocity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDepenetrationVelocity__Offset, false);}
			
		}
		
		static readonly int ContactOffsetMultiplier__Offset;
		public float ContactOffsetMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ContactOffsetMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ContactOffsetMultiplier__Offset, false);}
			
		}
		
		static readonly int MinContactOffset__Offset;
		public float MinContactOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinContactOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinContactOffset__Offset, false);}
			
		}
		
		static readonly int MaxContactOffset__Offset;
		public float MaxContactOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxContactOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxContactOffset__Offset, false);}
			
		}
		
		static readonly int bSimulateSkeletalMeshOnDedicatedServer__Offset;
		public bool bSimulateSkeletalMeshOnDedicatedServer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSimulateSkeletalMeshOnDedicatedServer__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSimulateSkeletalMeshOnDedicatedServer__Offset, 1,0,1,255);}
			
		}
		
		static readonly int DefaultShapeComplexity__Offset;
		public ECollisionTraceFlag DefaultShapeComplexity
		{
			get{ CheckIsValid();return (ECollisionTraceFlag)Marshal.PtrToStructure(_this.Get()+DefaultShapeComplexity__Offset, typeof(ECollisionTraceFlag));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultShapeComplexity__Offset, false);}
			
		}
		
		static readonly int bDefaultHasComplexCollision__Offset;
		public bool bDefaultHasComplexCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultHasComplexCollision__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bSuppressFaceRemapTable__Offset;
		public bool bSuppressFaceRemapTable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSuppressFaceRemapTable__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSuppressFaceRemapTable__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bSupportUVFromHitResults__Offset;
		public bool bSupportUVFromHitResults
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportUVFromHitResults__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSupportUVFromHitResults__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bDisableActiveActors__Offset;
		public bool bDisableActiveActors
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableActiveActors__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableActiveActors__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bDisableCCD__Offset;
		public bool bDisableCCD
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableCCD__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableCCD__Offset, 1,0,1,255);}
			
		}
		
		static readonly int MaxPhysicsDeltaTime__Offset;
		public float MaxPhysicsDeltaTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxPhysicsDeltaTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxPhysicsDeltaTime__Offset, false);}
			
		}
		
		static readonly int bSubstepping__Offset;
		public bool bSubstepping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSubstepping__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSubstepping__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bSubsteppingAsync__Offset;
		public bool bSubsteppingAsync
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSubsteppingAsync__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSubsteppingAsync__Offset, 1,0,1,255);}
			
		}
		
		static readonly int MaxSubstepDeltaTime__Offset;
		public float MaxSubstepDeltaTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSubstepDeltaTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSubstepDeltaTime__Offset, false);}
			
		}
		
		static readonly int MaxSubsteps__Offset;
		public int MaxSubsteps
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxSubsteps__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSubsteps__Offset, false);}
			
		}
		
		static readonly int SyncSceneSmoothingFactor__Offset;
		public float SyncSceneSmoothingFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SyncSceneSmoothingFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SyncSceneSmoothingFactor__Offset, false);}
			
		}
		
		static readonly int AsyncSceneSmoothingFactor__Offset;
		public float AsyncSceneSmoothingFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AsyncSceneSmoothingFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AsyncSceneSmoothingFactor__Offset, false);}
			
		}
		
		static readonly int InitialAverageFrameRate__Offset;
		public float InitialAverageFrameRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialAverageFrameRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialAverageFrameRate__Offset, false);}
			
		}
		
		static readonly int PhysicalSurfaces__Offset;
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
