#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleAttractorPoint
	{
		static readonly int Position__Offset;
		/// <summary>The position of the point attractor from the source of the emitter.</summary>
		public FRawDistributionVector Position
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+Position__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Position__Offset, false);}
			
		}
		
		static readonly int Range__Offset;
		/// <summary>The radial range of the attractor.</summary>
		public FRawDistributionFloat Range
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Range__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Range__Offset, false);}
			
		}
		
		static readonly int Strength__Offset;
		/// <summary>The strength of the point attractor.</summary>
		public FRawDistributionFloat Strength
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Strength__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Strength__Offset, false);}
			
		}
		
		static readonly int StrengthByDistance__Offset;
		/// <summary>The strength curve is a function of distance or of time.</summary>
		public bool StrengthByDistance
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), StrengthByDistance__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), StrengthByDistance__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bAffectBaseVelocity__Offset;
		/// <summary>If true, the velocity adjustment will be applied to the base velocity.</summary>
		public bool bAffectBaseVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectBaseVelocity__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectBaseVelocity__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bOverrideVelocity__Offset;
		/// <summary>If true, set the velocity.</summary>
		public bool bOverrideVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideVelocity__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideVelocity__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bUseWorldSpacePosition__Offset;
		/// <summary>If true, treat the position as world space.  So don't transform the the point to localspace.</summary>
		public bool bUseWorldSpacePosition
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseWorldSpacePosition__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseWorldSpacePosition__Offset, 1,0,8,8);}
			
		}
		
		static readonly int Positive_X__Offset;
		/// <summary>Whether particles can move along the positive X axis.</summary>
		public bool Positive_X
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Positive_X__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Positive_X__Offset, 1,0,16,16);}
			
		}
		
		static readonly int Positive_Y__Offset;
		/// <summary>Whether particles can move along the positive Y axis.</summary>
		public bool Positive_Y
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Positive_Y__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Positive_Y__Offset, 1,0,32,32);}
			
		}
		
		static readonly int Positive_Z__Offset;
		/// <summary>Whether particles can move along the positive Z axis.</summary>
		public bool Positive_Z
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Positive_Z__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Positive_Z__Offset, 1,0,64,64);}
			
		}
		
		static readonly int Negative_X__Offset;
		/// <summary>Whether particles can move along the negative X axis.</summary>
		public bool Negative_X
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Negative_X__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Negative_X__Offset, 1,0,128,128);}
			
		}
		
		static readonly int Negative_Y__Offset;
		/// <summary>Whether particles can move along the negative Y axis.</summary>
		public bool Negative_Y
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Negative_Y__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Negative_Y__Offset, 1,0,1,1);}
			
		}
		
		static readonly int Negative_Z__Offset;
		/// <summary>Whether particles can move along the negative Z axis.</summary>
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
