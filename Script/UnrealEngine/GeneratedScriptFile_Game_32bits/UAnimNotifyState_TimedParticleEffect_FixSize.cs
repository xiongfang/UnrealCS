#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimNotifyState_TimedParticleEffect
	{
		static readonly int PSTemplate__Offset;
		public UParticleSystem PSTemplate
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PSTemplate__Offset); if (v == IntPtr.Zero)return null; UParticleSystem retValue = new UParticleSystem(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PSTemplate__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PSTemplate__Offset, value._this.Get()); }
			
		}
		
		static readonly int SocketName__Offset;
		public FName SocketName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SocketName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SocketName__Offset, false);}
			
		}
		
		static readonly int LocationOffset__Offset;
		public FVector LocationOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LocationOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LocationOffset__Offset, false);}
			
		}
		
		static readonly int RotationOffset__Offset;
		public FRotator RotationOffset
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+RotationOffset__Offset, typeof(FRotator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotationOffset__Offset, false);}
			
		}
		
		static readonly int bDestroyAtEnd__Offset;
		public bool bDestroyAtEnd
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDestroyAtEnd__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDestroyAtEnd__Offset, 1,0,1,255);}
			
		}
		
		static UAnimNotifyState_TimedParticleEffect()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimNotifyState_TimedParticleEffect");
			PSTemplate__Offset=GetPropertyOffset(NativeClassPtr,"PSTemplate");
			SocketName__Offset=GetPropertyOffset(NativeClassPtr,"SocketName");
			LocationOffset__Offset=GetPropertyOffset(NativeClassPtr,"LocationOffset");
			RotationOffset__Offset=GetPropertyOffset(NativeClassPtr,"RotationOffset");
			bDestroyAtEnd__Offset=GetPropertyOffset(NativeClassPtr,"bDestroyAtEnd");
			
		}
		
	}
	
}
#endif
#endif
