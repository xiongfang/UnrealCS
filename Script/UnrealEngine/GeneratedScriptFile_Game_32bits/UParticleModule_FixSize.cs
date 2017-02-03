#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModule
	{
		static readonly int bSpawnModule__Offset;
		public bool bSpawnModule
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSpawnModule__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bUpdateModule__Offset;
		public bool bUpdateModule
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdateModule__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bFinalUpdateModule__Offset;
		public bool bFinalUpdateModule
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFinalUpdateModule__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bUpdateForGPUEmitter__Offset;
		public bool bUpdateForGPUEmitter
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdateForGPUEmitter__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bCurvesAsColor__Offset;
		public bool bCurvesAsColor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCurvesAsColor__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int b3DDrawMode__Offset;
		public bool b3DDrawMode
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), b3DDrawMode__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), b3DDrawMode__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bSupported3DDrawMode__Offset;
		public bool bSupported3DDrawMode
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupported3DDrawMode__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bEnabled__Offset;
		public bool bEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnabled__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bEditable__Offset;
		public bool bEditable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEditable__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int LODDuplicate__Offset;
		public bool LODDuplicate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), LODDuplicate__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bSupportsRandomSeed__Offset;
		public bool bSupportsRandomSeed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportsRandomSeed__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bRequiresLoopingNotification__Offset;
		public bool bRequiresLoopingNotification
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRequiresLoopingNotification__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int LODValidity__Offset;
		public byte LODValidity
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+LODValidity__Offset, typeof(byte));}
			
		}
		
		static UParticleModule()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModule");
			bSpawnModule__Offset=GetPropertyOffset(NativeClassPtr,"bSpawnModule");
			bUpdateModule__Offset=GetPropertyOffset(NativeClassPtr,"bUpdateModule");
			bFinalUpdateModule__Offset=GetPropertyOffset(NativeClassPtr,"bFinalUpdateModule");
			bUpdateForGPUEmitter__Offset=GetPropertyOffset(NativeClassPtr,"bUpdateForGPUEmitter");
			bCurvesAsColor__Offset=GetPropertyOffset(NativeClassPtr,"bCurvesAsColor");
			b3DDrawMode__Offset=GetPropertyOffset(NativeClassPtr,"b3DDrawMode");
			bSupported3DDrawMode__Offset=GetPropertyOffset(NativeClassPtr,"bSupported3DDrawMode");
			bEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bEnabled");
			bEditable__Offset=GetPropertyOffset(NativeClassPtr,"bEditable");
			LODDuplicate__Offset=GetPropertyOffset(NativeClassPtr,"LODDuplicate");
			bSupportsRandomSeed__Offset=GetPropertyOffset(NativeClassPtr,"bSupportsRandomSeed");
			bRequiresLoopingNotification__Offset=GetPropertyOffset(NativeClassPtr,"bRequiresLoopingNotification");
			LODValidity__Offset=GetPropertyOffset(NativeClassPtr,"LODValidity");
			
		}
		
	}
	
}
#endif
#endif
