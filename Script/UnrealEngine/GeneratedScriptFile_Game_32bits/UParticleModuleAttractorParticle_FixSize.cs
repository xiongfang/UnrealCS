#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleAttractorParticle
	{
		static readonly int EmitterName__Offset;
		public FName EmitterName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+EmitterName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterName__Offset, false);}
			
		}
		
		static readonly int Range__Offset;
		public FRawDistributionFloat Range
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Range__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Range__Offset, false);}
			
		}
		
		static readonly int bStrengthByDistance__Offset;
		public bool bStrengthByDistance
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStrengthByDistance__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStrengthByDistance__Offset, 1,0,1,1);}
			
		}
		
		static readonly int Strength__Offset;
		public FRawDistributionFloat Strength
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Strength__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Strength__Offset, false);}
			
		}
		
		static readonly int bAffectBaseVelocity__Offset;
		public bool bAffectBaseVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectBaseVelocity__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectBaseVelocity__Offset, 1,0,1,1);}
			
		}
		
		static readonly int SelectionMethod__Offset;
		public EAttractorParticleSelectionMethod SelectionMethod
		{
			get{ CheckIsValid();return (EAttractorParticleSelectionMethod)Marshal.PtrToStructure(_this.Get()+SelectionMethod__Offset, typeof(EAttractorParticleSelectionMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SelectionMethod__Offset, false);}
			
		}
		
		static readonly int bRenewSource__Offset;
		public bool bRenewSource
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenewSource__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenewSource__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bInheritSourceVel__Offset;
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
