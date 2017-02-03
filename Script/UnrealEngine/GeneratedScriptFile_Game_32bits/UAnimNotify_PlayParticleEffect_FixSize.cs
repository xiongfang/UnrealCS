#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimNotify_PlayParticleEffect
	{
		static readonly int PSTemplate__Offset;
		public UParticleSystem PSTemplate
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PSTemplate__Offset); if (v == IntPtr.Zero)return null; UParticleSystem retValue = new UParticleSystem(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PSTemplate__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PSTemplate__Offset, value._this.Get()); }
			
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
		
		static readonly int Attached__Offset;
		public bool Attached
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Attached__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Attached__Offset, 1,0,1,1);}
			
		}
		
		static readonly int SocketName__Offset;
		public FName SocketName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SocketName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SocketName__Offset, false);}
			
		}
		
		static UAnimNotify_PlayParticleEffect()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimNotify_PlayParticleEffect");
			PSTemplate__Offset=GetPropertyOffset(NativeClassPtr,"PSTemplate");
			LocationOffset__Offset=GetPropertyOffset(NativeClassPtr,"LocationOffset");
			RotationOffset__Offset=GetPropertyOffset(NativeClassPtr,"RotationOffset");
			Attached__Offset=GetPropertyOffset(NativeClassPtr,"Attached");
			SocketName__Offset=GetPropertyOffset(NativeClassPtr,"SocketName");
			
		}
		
	}
	
}
#endif
#endif
