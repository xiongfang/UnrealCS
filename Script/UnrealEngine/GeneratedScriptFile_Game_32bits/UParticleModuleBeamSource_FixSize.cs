#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleBeamSource
	{
		static readonly int SourceMethod__Offset;
		public Beam2SourceTargetMethod SourceMethod
		{
			get{ CheckIsValid();return (Beam2SourceTargetMethod)Marshal.PtrToStructure(_this.Get()+SourceMethod__Offset, typeof(Beam2SourceTargetMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceMethod__Offset, false);}
			
		}
		
		static readonly int SourceName__Offset;
		public FName SourceName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SourceName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceName__Offset, false);}
			
		}
		
		static readonly int bSourceAbsolute__Offset;
		public bool bSourceAbsolute
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSourceAbsolute__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSourceAbsolute__Offset, 1,0,1,1);}
			
		}
		
		static readonly int Source__Offset;
		public FRawDistributionVector Source
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+Source__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Source__Offset, false);}
			
		}
		
		static readonly int bLockSource__Offset;
		public bool bLockSource
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockSource__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLockSource__Offset, 1,0,1,1);}
			
		}
		
		static readonly int SourceTangentMethod__Offset;
		public Beam2SourceTargetTangentMethod SourceTangentMethod
		{
			get{ CheckIsValid();return (Beam2SourceTargetTangentMethod)Marshal.PtrToStructure(_this.Get()+SourceTangentMethod__Offset, typeof(Beam2SourceTargetTangentMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceTangentMethod__Offset, false);}
			
		}
		
		static readonly int SourceTangent__Offset;
		public FRawDistributionVector SourceTangent
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+SourceTangent__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceTangent__Offset, false);}
			
		}
		
		static readonly int bLockSourceTangent__Offset;
		public bool bLockSourceTangent
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockSourceTangent__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLockSourceTangent__Offset, 1,0,1,1);}
			
		}
		
		static readonly int SourceStrength__Offset;
		public FRawDistributionFloat SourceStrength
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+SourceStrength__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceStrength__Offset, false);}
			
		}
		
		static readonly int bLockSourceStength__Offset;
		public bool bLockSourceStength
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockSourceStength__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLockSourceStength__Offset, 1,0,1,1);}
			
		}
		
		static UParticleModuleBeamSource()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleBeamSource");
			SourceMethod__Offset=GetPropertyOffset(NativeClassPtr,"SourceMethod");
			SourceName__Offset=GetPropertyOffset(NativeClassPtr,"SourceName");
			bSourceAbsolute__Offset=GetPropertyOffset(NativeClassPtr,"bSourceAbsolute");
			Source__Offset=GetPropertyOffset(NativeClassPtr,"Source");
			bLockSource__Offset=GetPropertyOffset(NativeClassPtr,"bLockSource");
			SourceTangentMethod__Offset=GetPropertyOffset(NativeClassPtr,"SourceTangentMethod");
			SourceTangent__Offset=GetPropertyOffset(NativeClassPtr,"SourceTangent");
			bLockSourceTangent__Offset=GetPropertyOffset(NativeClassPtr,"bLockSourceTangent");
			SourceStrength__Offset=GetPropertyOffset(NativeClassPtr,"SourceStrength");
			bLockSourceStength__Offset=GetPropertyOffset(NativeClassPtr,"bLockSourceStength");
			
		}
		
	}
	
}
#endif
#endif
