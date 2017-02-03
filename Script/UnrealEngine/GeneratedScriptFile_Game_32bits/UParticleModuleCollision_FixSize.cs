#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleCollision
	{
		static readonly int DampingFactor__Offset;
		public FRawDistributionVector DampingFactor
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+DampingFactor__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DampingFactor__Offset, false);}
			
		}
		
		static readonly int DampingFactorRotation__Offset;
		public FRawDistributionVector DampingFactorRotation
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+DampingFactorRotation__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DampingFactorRotation__Offset, false);}
			
		}
		
		static readonly int MaxCollisions__Offset;
		public FRawDistributionFloat MaxCollisions
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+MaxCollisions__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxCollisions__Offset, false);}
			
		}
		
		static readonly int CollisionCompletionOption__Offset;
		public EParticleCollisionComplete CollisionCompletionOption
		{
			get{ CheckIsValid();return (EParticleCollisionComplete)Marshal.PtrToStructure(_this.Get()+CollisionCompletionOption__Offset, typeof(EParticleCollisionComplete));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CollisionCompletionOption__Offset, false);}
			
		}
		
		static readonly int CollisionTypes__Offset;
		public TStructArray<EObjectTypeQuery> CollisionTypes
		{
			get{ CheckIsValid();return new TStructArray<EObjectTypeQuery>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CollisionTypes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CollisionTypes__Offset, false);}
			
		}
		
		static readonly int bApplyPhysics__Offset;
		public bool bApplyPhysics
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bApplyPhysics__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bApplyPhysics__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bIgnoreTriggerVolumes__Offset;
		public bool bIgnoreTriggerVolumes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreTriggerVolumes__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreTriggerVolumes__Offset, 1,0,2,2);}
			
		}
		
		static readonly int ParticleMass__Offset;
		public FRawDistributionFloat ParticleMass
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+ParticleMass__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ParticleMass__Offset, false);}
			
		}
		
		static readonly int DirScalar__Offset;
		public float DirScalar
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DirScalar__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DirScalar__Offset, false);}
			
		}
		
		static readonly int bPawnsDoNotDecrementCount__Offset;
		public bool bPawnsDoNotDecrementCount
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPawnsDoNotDecrementCount__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPawnsDoNotDecrementCount__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOnlyVerticalNormalsDecrementCount__Offset;
		public bool bOnlyVerticalNormalsDecrementCount
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOnlyVerticalNormalsDecrementCount__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOnlyVerticalNormalsDecrementCount__Offset, 1,0,2,2);}
			
		}
		
		static readonly int VerticalFudgeFactor__Offset;
		public float VerticalFudgeFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VerticalFudgeFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VerticalFudgeFactor__Offset, false);}
			
		}
		
		static readonly int DelayAmount__Offset;
		public FRawDistributionFloat DelayAmount
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+DelayAmount__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DelayAmount__Offset, false);}
			
		}
		
		static readonly int bDropDetail__Offset;
		public bool bDropDetail
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDropDetail__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDropDetail__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bCollideOnlyIfVisible__Offset;
		public bool bCollideOnlyIfVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCollideOnlyIfVisible__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCollideOnlyIfVisible__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bIgnoreSourceActor__Offset;
		public bool bIgnoreSourceActor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreSourceActor__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreSourceActor__Offset, 1,0,4,4);}
			
		}
		
		static readonly int MaxCollisionDistance__Offset;
		public float MaxCollisionDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxCollisionDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxCollisionDistance__Offset, false);}
			
		}
		
		static UParticleModuleCollision()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleCollision");
			DampingFactor__Offset=GetPropertyOffset(NativeClassPtr,"DampingFactor");
			DampingFactorRotation__Offset=GetPropertyOffset(NativeClassPtr,"DampingFactorRotation");
			MaxCollisions__Offset=GetPropertyOffset(NativeClassPtr,"MaxCollisions");
			CollisionCompletionOption__Offset=GetPropertyOffset(NativeClassPtr,"CollisionCompletionOption");
			CollisionTypes__Offset=GetPropertyOffset(NativeClassPtr,"CollisionTypes");
			bApplyPhysics__Offset=GetPropertyOffset(NativeClassPtr,"bApplyPhysics");
			bIgnoreTriggerVolumes__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreTriggerVolumes");
			ParticleMass__Offset=GetPropertyOffset(NativeClassPtr,"ParticleMass");
			DirScalar__Offset=GetPropertyOffset(NativeClassPtr,"DirScalar");
			bPawnsDoNotDecrementCount__Offset=GetPropertyOffset(NativeClassPtr,"bPawnsDoNotDecrementCount");
			bOnlyVerticalNormalsDecrementCount__Offset=GetPropertyOffset(NativeClassPtr,"bOnlyVerticalNormalsDecrementCount");
			VerticalFudgeFactor__Offset=GetPropertyOffset(NativeClassPtr,"VerticalFudgeFactor");
			DelayAmount__Offset=GetPropertyOffset(NativeClassPtr,"DelayAmount");
			bDropDetail__Offset=GetPropertyOffset(NativeClassPtr,"bDropDetail");
			bCollideOnlyIfVisible__Offset=GetPropertyOffset(NativeClassPtr,"bCollideOnlyIfVisible");
			bIgnoreSourceActor__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreSourceActor");
			MaxCollisionDistance__Offset=GetPropertyOffset(NativeClassPtr,"MaxCollisionDistance");
			
		}
		
	}
	
}
#endif
#endif
