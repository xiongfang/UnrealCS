#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleAttractorParticle
	{
		static readonly int EmitterName__Offset;
		/// <summary>The source emitter for attractors</summary>
		public FName EmitterName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+EmitterName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterName__Offset, false);}
			
		}
		
		static readonly int Range__Offset;
		/// <summary>
		/// The radial range of the attraction around the source particle.
		/// Particle-life relative.
		/// </summary>
		public FRawDistributionFloat Range
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Range__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Range__Offset, false);}
			
		}
		
		static readonly int bStrengthByDistance__Offset;
		/// <summary>The strength curve is a function of distance or of time.</summary>
		public bool bStrengthByDistance
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStrengthByDistance__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStrengthByDistance__Offset, 1,0,1,1);}
			
		}
		
		static readonly int Strength__Offset;
		/// <summary>
		/// The strength of the attraction (negative values repel).
		/// Particle-life relative if StrengthByDistance is false.
		/// </summary>
		public FRawDistributionFloat Strength
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Strength__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Strength__Offset, false);}
			
		}
		
		static readonly int bAffectBaseVelocity__Offset;
		/// <summary>If true, the velocity adjustment will be applied to the base velocity.</summary>
		public bool bAffectBaseVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectBaseVelocity__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectBaseVelocity__Offset, 1,0,1,1);}
			
		}
		
		static readonly int SelectionMethod__Offset;
		/// <summary>
		/// The method to use when selecting an attractor target particle from the emitter.
		/// One of the following:
		/// Random          - Randomly select a particle from the source emitter.
		/// Sequential  - Select a particle using a sequential order.
		/// </summary>
		public EAttractorParticleSelectionMethod SelectionMethod
		{
			get{ CheckIsValid();return (EAttractorParticleSelectionMethod)Marshal.PtrToStructure(_this.Get()+SelectionMethod__Offset, typeof(EAttractorParticleSelectionMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SelectionMethod__Offset, false);}
			
		}
		
		static readonly int bRenewSource__Offset;
		/// <summary>Whether the particle should grab a new particle if it's source expires.</summary>
		public bool bRenewSource
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenewSource__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenewSource__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bInheritSourceVel__Offset;
		/// <summary>Whether the particle should inherit the source veloctiy if it expires.</summary>
		public bool bInheritSourceVel
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritSourceVel__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritSourceVel__Offset, 1,0,2,2);}
			
		}
		
		static readonly int LastSelIndex__Offset;
		public int LastSelIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LastSelIndex__Offset, typeof(int));}
			
		}
		
		static UParticleModuleAttractorParticle()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleAttractorParticle");
			EmitterName__Offset=GetPropertyOffset(NativeClassPtr,"EmitterName");
			Range__Offset=GetPropertyOffset(NativeClassPtr,"Range");
			bStrengthByDistance__Offset=GetPropertyOffset(NativeClassPtr,"bStrengthByDistance");
			Strength__Offset=GetPropertyOffset(NativeClassPtr,"Strength");
			bAffectBaseVelocity__Offset=GetPropertyOffset(NativeClassPtr,"bAffectBaseVelocity");
			SelectionMethod__Offset=GetPropertyOffset(NativeClassPtr,"SelectionMethod");
			bRenewSource__Offset=GetPropertyOffset(NativeClassPtr,"bRenewSource");
			bInheritSourceVel__Offset=GetPropertyOffset(NativeClassPtr,"bInheritSourceVel");
			LastSelIndex__Offset=GetPropertyOffset(NativeClassPtr,"LastSelIndex");
			
		}
		
	}
	
}
#endif
#endif
