#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// This component holds the physics data for a DestructibleActor.
	/// The USkeletalMesh pointer in the base class (SkinnedMeshComponent) MUST be a DestructibleMesh
	/// </summary>
	public partial class UDestructibleComponent
	{
		static readonly int bFractureEffectOverride__Offset;
		/// <summary>If set, use this actor's fracture effects instead of the asset's fracture effects.</summary>
		public bool bFractureEffectOverride
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFractureEffectOverride__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFractureEffectOverride__Offset, 1,0,1,1);}
			
		}
		
		static readonly int FractureEffects__Offset;
		/// <summary>Fracture effects for each fracture level. Used only if Fracture Effect Override is set.</summary>
		public TStructArray<FFractureEffect> FractureEffects
		{
			get{ CheckIsValid();return new TStructArray<FFractureEffect>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FractureEffects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FractureEffects__Offset, false);}
			
		}
		
		static readonly int bEnableHardSleeping__Offset;
		/// <summary>
		/// Enable "hard sleeping" for destruction-generated PxActors.  This means that they turn kinematic
		/// when they sleep, but can be made dynamic again by application of enough damage.
		/// </summary>
		public bool bEnableHardSleeping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableHardSleeping__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableHardSleeping__Offset, 1,0,1,255);}
			
		}
		
		static readonly int LargeChunkThreshold__Offset;
		/// <summary>The minimum size required to treat chunks as Large.</summary>
		public float LargeChunkThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LargeChunkThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LargeChunkThreshold__Offset, false);}
			
		}
		
		static readonly int DestructibleMesh__Offset;
		/// <summary>Provide a blueprint interface for setting the destructible mesh</summary>
		public UDestructibleMesh DestructibleMesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DestructibleMesh__Offset); if (v == IntPtr.Zero)return null; UDestructibleMesh retValue = new UDestructibleMesh(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + DestructibleMesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + DestructibleMesh__Offset, value._this.Get()); }
			
		}
		
		static readonly int OnComponentFracture__Offset;
		/// <summary>Called when a component is touched</summary>
		public FMulticastScriptDelegate OnComponentFracture
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnComponentFracture__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnComponentFracture__Offset, false);}
			
		}
		
		static UDestructibleComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DestructibleComponent");
			bFractureEffectOverride__Offset=GetPropertyOffset(NativeClassPtr,"bFractureEffectOverride");
			FractureEffects__Offset=GetPropertyOffset(NativeClassPtr,"FractureEffects");
			bEnableHardSleeping__Offset=GetPropertyOffset(NativeClassPtr,"bEnableHardSleeping");
			LargeChunkThreshold__Offset=GetPropertyOffset(NativeClassPtr,"LargeChunkThreshold");
			DestructibleMesh__Offset=GetPropertyOffset(NativeClassPtr,"DestructibleMesh");
			OnComponentFracture__Offset=GetPropertyOffset(NativeClassPtr,"OnComponentFracture");
			
		}
		
	}
	
}
#endif
#endif
