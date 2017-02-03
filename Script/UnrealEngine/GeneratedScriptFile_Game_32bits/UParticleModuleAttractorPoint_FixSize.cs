#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleAttractorPoint
	{
		static readonly int Position__Offset;
		public FRawDistributionVector Position
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+Position__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Position__Offset, false);}
			
		}
		
		static readonly int Range__Offset;
		public FRawDistributionFloat Range
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Range__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Range__Offset, false);}
			
		}
		
		static readonly int Strength__Offset;
		public FRawDistributionFloat Strength
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Strength__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Strength__Offset, false);}
			
		}
		
		static readonly int StrengthByDistance__Offset;
		public bool StrengthByDistance
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), StrengthByDistance__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), StrengthByDistance__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bAffectBaseVelocity__Offset;
		public bool bAffectBaseVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectBaseVelocity__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectBaseVelocity__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bOverrideVelocity__Offset;
		public bool bOverrideVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideVelocity__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideVelocity__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bUseWorldSpacePosition__Offset;
		public bool bUseWorldSpacePosition
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseWorldSpacePosition__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseWorldSpacePosition__Offset, 1,0,8,8);}
			
		}
		
		static readonly int Positive_X__Offset;
		public bool Positive_X
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Positive_X__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Positive_X__Offset, 1,0,16,16);}
			
		}
		
		static readonly int Positive_Y__Offset;
		public bool Positive_Y
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Positive_Y__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Positive_Y__Offset, 1,0,32,32);}
			
		}
		
		static readonly int Positive_Z__Offset;
		public bool Positive_Z
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Positive_Z__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Positive_Z__Offset, 1,0,64,64);}
			
		}
		
		static readonly int Negative_X__Offset;
		public bool Negative_X
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Negative_X__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Negative_X__Offset, 1,0,128,128);}
			
		}
		
		static readonly int Negative_Y__Offset;
		public bool Negative_Y
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Negative_Y__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Negative_Y__Offset, 1,0,1,1);}
			
		}
		
		static readonly int Negative_Z__Offset;
		public bool Negative_Z
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Negative_Z__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Negative_Z__Offset, 1,0,2,2);}
			
		}
		
		static UParticleModuleAttractorPoint()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleAttractorPoint");
			Position__Offset=GetPropertyOffset(NativeClassPtr,"Position");
			Range__Offset=GetPropertyOffset(NativeClassPtr,"Range");
			Strength__Offset=GetPropertyOffset(NativeClassPtr,"Strength");
			StrengthByDistance__Offset=GetPropertyOffset(NativeClassPtr,"StrengthByDistance");
			bAffectBaseVelocity__Offset=GetPropertyOffset(NativeClassPtr,"bAffectBaseVelocity");
			bOverrideVelocity__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideVelocity");
			bUseWorldSpacePosition__Offset=GetPropertyOffset(NativeClassPtr,"bUseWorldSpacePosition");
			Positive_X__Offset=GetPropertyOffset(NativeClassPtr,"Positive_X");
			Positive_Y__Offset=GetPropertyOffset(NativeClassPtr,"Positive_Y");
			Positive_Z__Offset=GetPropertyOffset(NativeClassPtr,"Positive_Z");
			Negative_X__Offset=GetPropertyOffset(NativeClassPtr,"Negative_X");
			Negative_Y__Offset=GetPropertyOffset(NativeClassPtr,"Negative_Y");
			Negative_Z__Offset=GetPropertyOffset(NativeClassPtr,"Negative_Z");
			
		}
		
	}
	
}
#endif
#endif
