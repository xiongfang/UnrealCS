#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleTrailSource
	{
		static readonly int SourceMethod__Offset;
		/// <summary>The source method for the trail.</summary>
		public ETrail2SourceMethod SourceMethod
		{
			get{ CheckIsValid();return (ETrail2SourceMethod)Marshal.PtrToStructure(_this.Get()+SourceMethod__Offset, typeof(ETrail2SourceMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceMethod__Offset, false);}
			
		}
		
		static readonly int SourceName__Offset;
		/// <summary>The name of the source - either the emitter or Actor.</summary>
		public FName SourceName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SourceName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceName__Offset, false);}
			
		}
		
		static readonly int SourceStrength__Offset;
		/// <summary>The strength of the tangent from the source point for each Trail.</summary>
		public FRawDistributionFloat SourceStrength
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+SourceStrength__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceStrength__Offset, false);}
			
		}
		
		static readonly int bLockSourceStength__Offset;
		/// <summary>Whether to lock the source to the life of the particle.</summary>
		public bool bLockSourceStength
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockSourceStength__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLockSourceStength__Offset, 1,0,1,1);}
			
		}
		
		static readonly int SourceOffsetCount__Offset;
		/// <summary>
		/// SourceOffsetCount
		/// The number of source offsets that can be expected to be found on the instance.
		/// These must be named
		///         TrailSourceOffset#
		/// </summary>
		public int SourceOffsetCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SourceOffsetCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceOffsetCount__Offset, false);}
			
		}
		
		static readonly int SourceOffsetDefaults__Offset;
		/// <summary>
		/// Default offsets from the source(s).
		/// If there are < SourceOffsetCount slots, the grabbing of values will simply wrap.
		/// </summary>
		public TStructArray<FVector> SourceOffsetDefaults
		{
			get{ CheckIsValid();return new TStructArray<FVector>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SourceOffsetDefaults__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SourceOffsetDefaults__Offset, false);}
			
		}
		
		static readonly int SelectionMethod__Offset;
		/// <summary>Particle selection method, when using the SourceMethod of Particle.</summary>
		public EParticleSourceSelectionMethod SelectionMethod
		{
			get{ CheckIsValid();return (EParticleSourceSelectionMethod)Marshal.PtrToStructure(_this.Get()+SelectionMethod__Offset, typeof(EParticleSourceSelectionMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SelectionMethod__Offset, false);}
			
		}
		
		static readonly int bInheritRotation__Offset;
		/// <summary>Interhit particle rotation - only valid for SourceMethod of PET2SRCM_Particle.</summary>
		public bool bInheritRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritRotation__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritRotation__Offset, 1,0,1,1);}
			
		}
		
		static UParticleModuleTrailSource()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleTrailSource");
			SourceMethod__Offset=GetPropertyOffset(NativeClassPtr,"SourceMethod");
			SourceName__Offset=GetPropertyOffset(NativeClassPtr,"SourceName");
			SourceStrength__Offset=GetPropertyOffset(NativeClassPtr,"SourceStrength");
			bLockSourceStength__Offset=GetPropertyOffset(NativeClassPtr,"bLockSourceStength");
			SourceOffsetCount__Offset=GetPropertyOffset(NativeClassPtr,"SourceOffsetCount");
			SourceOffsetDefaults__Offset=GetPropertyOffset(NativeClassPtr,"SourceOffsetDefaults");
			SelectionMethod__Offset=GetPropertyOffset(NativeClassPtr,"SelectionMethod");
			bInheritRotation__Offset=GetPropertyOffset(NativeClassPtr,"bInheritRotation");
			
		}
		
	}
	
}
#endif
#endif
