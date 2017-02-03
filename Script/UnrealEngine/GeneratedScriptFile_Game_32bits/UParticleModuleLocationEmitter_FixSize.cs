#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationEmitter
	{
		static readonly int EmitterName__Offset;
		public FName EmitterName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+EmitterName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterName__Offset, false);}
			
		}
		
		static readonly int SelectionMethod__Offset;
		public ELocationEmitterSelectionMethod SelectionMethod
		{
			get{ CheckIsValid();return (ELocationEmitterSelectionMethod)Marshal.PtrToStructure(_this.Get()+SelectionMethod__Offset, typeof(ELocationEmitterSelectionMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SelectionMethod__Offset, false);}
			
		}
		
		static readonly int InheritSourceVelocity__Offset;
		public bool InheritSourceVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), InheritSourceVelocity__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), InheritSourceVelocity__Offset, 1,0,1,1);}
			
		}
		
		static readonly int InheritSourceVelocityScale__Offset;
		public float InheritSourceVelocityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InheritSourceVelocityScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InheritSourceVelocityScale__Offset, false);}
			
		}
		
		static readonly int bInheritSourceRotation__Offset;
		public bool bInheritSourceRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritSourceRotation__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritSourceRotation__Offset, 1,0,1,1);}
			
		}
		
		static readonly int InheritSourceRotationScale__Offset;
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
