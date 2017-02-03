#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleAttractorLine
	{
		static readonly int EndPoint0__Offset;
		public FVector EndPoint0
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+EndPoint0__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EndPoint0__Offset, false);}
			
		}
		
		static readonly int EndPoint1__Offset;
		public FVector EndPoint1
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+EndPoint1__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EndPoint1__Offset, false);}
			
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
		
		static UParticleModuleAttractorLine()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleAttractorLine");
			EndPoint0__Offset=GetPropertyOffset(NativeClassPtr,"EndPoint0");
			EndPoint1__Offset=GetPropertyOffset(NativeClassPtr,"EndPoint1");
			Range__Offset=GetPropertyOffset(NativeClassPtr,"Range");
			Strength__Offset=GetPropertyOffset(NativeClassPtr,"Strength");
			
		}
		
	}
	
}
#endif
#endif
