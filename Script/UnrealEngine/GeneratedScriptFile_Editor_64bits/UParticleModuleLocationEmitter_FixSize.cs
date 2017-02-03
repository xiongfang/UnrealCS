#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationEmitter
	{
		static readonly int EmitterName__Offset;
		/// <summary>The name of the emitter to use that the source location for particle.</summary>
		public FName EmitterName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+EmitterName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterName__Offset, false);}
			
		}
		
		static readonly int SelectionMethod__Offset;
		/// <summary>
		/// The method to use when selecting a spawn target particle from the emitter.
		/// Can be one of the following:
		///         ELESM_Random            Randomly select a particle from the source emitter.
		///         ELESM_Sequential        Step through each particle from the source emitter in order.
		/// </summary>
		public ELocationEmitterSelectionMethod SelectionMethod
		{
			get{ CheckIsValid();return (ELocationEmitterSelectionMethod)Marshal.PtrToStructure(_this.Get()+SelectionMethod__Offset, typeof(ELocationEmitterSelectionMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SelectionMethod__Offset, false);}
			
		}
		
		static readonly int InheritSourceVelocity__Offset;
		/// <summary>If true, the spawned particle should inherit the velocity of the source particle.</summary>
		public bool InheritSourceVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), InheritSourceVelocity__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), InheritSourceVelocity__Offset, 1,0,1,1);}
			
		}
		
		static readonly int InheritSourceVelocityScale__Offset;
		/// <summary>Amount to scale the source velocity by when inheriting it.</summary>
		public float InheritSourceVelocityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InheritSourceVelocityScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InheritSourceVelocityScale__Offset, false);}
			
		}
		
		static readonly int bInheritSourceRotation__Offset;
		/// <summary>If true, the spawned particle should inherit the rotation of the source particle.</summary>
		public bool bInheritSourceRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritSourceRotation__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritSourceRotation__Offset, 1,0,1,1);}
			
		}
		
		static readonly int InheritSourceRotationScale__Offset;
		/// <summary>Amount to scale the source rotation by when inheriting it.</summary>
		public float InheritSourceRotationScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InheritSourceRotationScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InheritSourceRotationScale__Offset, false);}
			
		}
		
		static UParticleModuleLocationEmitter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLocationEmitter");
			EmitterName__Offset=GetPropertyOffset(NativeClassPtr,"EmitterName");
			SelectionMethod__Offset=GetPropertyOffset(NativeClassPtr,"SelectionMethod");
			InheritSourceVelocity__Offset=GetPropertyOffset(NativeClassPtr,"InheritSourceVelocity");
			InheritSourceVelocityScale__Offset=GetPropertyOffset(NativeClassPtr,"InheritSourceVelocityScale");
			bInheritSourceRotation__Offset=GetPropertyOffset(NativeClassPtr,"bInheritSourceRotation");
			InheritSourceRotationScale__Offset=GetPropertyOffset(NativeClassPtr,"InheritSourceRotationScale");
			
		}
		
	}
	
}
#endif
#endif
