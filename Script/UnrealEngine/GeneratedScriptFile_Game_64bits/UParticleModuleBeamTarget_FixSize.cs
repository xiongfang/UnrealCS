#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleBeamTarget
	{
		static readonly int TargetMethod__Offset;
		public Beam2SourceTargetMethod TargetMethod
		{
			get{ CheckIsValid();return (Beam2SourceTargetMethod)Marshal.PtrToStructure(_this.Get()+TargetMethod__Offset, typeof(Beam2SourceTargetMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetMethod__Offset, false);}
			
		}
		
		static readonly int TargetName__Offset;
		public FName TargetName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+TargetName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetName__Offset, false);}
			
		}
		
		static readonly int Target__Offset;
		public FRawDistributionVector Target
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+Target__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Target__Offset, false);}
			
		}
		
		static readonly int bTargetAbsolute__Offset;
		public bool bTargetAbsolute
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTargetAbsolute__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTargetAbsolute__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bLockTarget__Offset;
		public bool bLockTarget
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockTarget__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLockTarget__Offset, 1,0,2,2);}
			
		}
		
		static readonly int TargetTangentMethod__Offset;
		public Beam2SourceTargetTangentMethod TargetTangentMethod
		{
			get{ CheckIsValid();return (Beam2SourceTargetTangentMethod)Marshal.PtrToStructure(_this.Get()+TargetTangentMethod__Offset, typeof(Beam2SourceTargetTangentMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetTangentMethod__Offset, false);}
			
		}
		
		static readonly int TargetTangent__Offset;
		public FRawDistributionVector TargetTangent
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+TargetTangent__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetTangent__Offset, false);}
			
		}
		
		static readonly int bLockTargetTangent__Offset;
		public bool bLockTargetTangent
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockTargetTangent__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLockTargetTangent__Offset, 1,0,1,1);}
			
		}
		
		static readonly int TargetStrength__Offset;
		public FRawDistributionFloat TargetStrength
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+TargetStrength__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetStrength__Offset, false);}
			
		}
		
		static readonly int bLockTargetStength__Offset;
		public bool bLockTargetStength
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockTargetStength__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLockTargetStength__Offset, 1,0,1,1);}
			
		}
		
		static readonly int LockRadius__Offset;
		public float LockRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LockRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LockRadius__Offset, false);}
			
		}
		
		static UParticleModuleBeamTarget()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleBeamTarget");
			TargetMethod__Offset=GetPropertyOffset(NativeClassPtr,"TargetMethod");
			TargetName__Offset=GetPropertyOffset(NativeClassPtr,"TargetName");
			Target__Offset=GetPropertyOffset(NativeClassPtr,"Target");
			bTargetAbsolute__Offset=GetPropertyOffset(NativeClassPtr,"bTargetAbsolute");
			bLockTarget__Offset=GetPropertyOffset(NativeClassPtr,"bLockTarget");
			TargetTangentMethod__Offset=GetPropertyOffset(NativeClassPtr,"TargetTangentMethod");
			TargetTangent__Offset=GetPropertyOffset(NativeClassPtr,"TargetTangent");
			bLockTargetTangent__Offset=GetPropertyOffset(NativeClassPtr,"bLockTargetTangent");
			TargetStrength__Offset=GetPropertyOffset(NativeClassPtr,"TargetStrength");
			bLockTargetStength__Offset=GetPropertyOffset(NativeClassPtr,"bLockTargetStength");
			LockRadius__Offset=GetPropertyOffset(NativeClassPtr,"LockRadius");
			
		}
		
	}
	
}
#endif
#endif
