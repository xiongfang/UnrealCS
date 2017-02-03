#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDestructibleComponent
	{
		static readonly int bFractureEffectOverride__Offset;
		public bool bFractureEffectOverride
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFractureEffectOverride__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFractureEffectOverride__Offset, 1,0,1,1);}
			
		}
		
		static readonly int FractureEffects__Offset;
		public TStructArray<FFractureEffect> FractureEffects
		{
			get{ CheckIsValid();return new TStructArray<FFractureEffect>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FractureEffects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FractureEffects__Offset, false);}
			
		}
		
		static readonly int bEnableHardSleeping__Offset;
		public bool bEnableHardSleeping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableHardSleeping__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableHardSleeping__Offset, 1,0,1,255);}
			
		}
		
		static readonly int LargeChunkThreshold__Offset;
		public float LargeChunkThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LargeChunkThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LargeChunkThreshold__Offset, false);}
			
		}
		
		static readonly int OnComponentFracture__Offset;
		public FMulticastScriptDelegate OnComponentFracture
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnComponentFracture__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnComponentFracture__Offset, false);}
			
		}
		
		static UDestructibleComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DestructibleComponent");
			bFractureEffectOverride__Offset=GetPropertyOffset(NativeClassPtr,"bFractureEffectOverride");
			FractureEffects__Offset=GetPropertyOffset(NativeClassPtr,"FractureEffects");
			bEnableHardSleeping__Offset=GetPropertyOffset(NativeClassPtr,"bEnableHardSleeping");
			LargeChunkThreshold__Offset=GetPropertyOffset(NativeClassPtr,"LargeChunkThreshold");
			OnComponentFracture__Offset=GetPropertyOffset(NativeClassPtr,"OnComponentFracture");
			
		}
		
	}
	
}
#endif
#endif
