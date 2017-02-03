#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationPrimitiveTriangle
	{
		static readonly int StartOffset__Offset;
		public FRawDistributionVector StartOffset
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+StartOffset__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartOffset__Offset, false);}
			
		}
		
		static readonly int Height__Offset;
		public FRawDistributionFloat Height
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Height__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Height__Offset, false);}
			
		}
		
		static readonly int Angle__Offset;
		public FRawDistributionFloat Angle
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Angle__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Angle__Offset, false);}
			
		}
		
		static readonly int Thickness__Offset;
		public FRawDistributionFloat Thickness
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Thickness__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Thickness__Offset, false);}
			
		}
		
		static UParticleModuleLocationPrimitiveTriangle()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLocationPrimitiveTriangle");
			StartOffset__Offset=GetPropertyOffset(NativeClassPtr,"StartOffset");
			Height__Offset=GetPropertyOffset(NativeClassPtr,"Height");
			Angle__Offset=GetPropertyOffset(NativeClassPtr,"Angle");
			Thickness__Offset=GetPropertyOffset(NativeClassPtr,"Thickness");
			
		}
		
	}
	
}
#endif
#endif
