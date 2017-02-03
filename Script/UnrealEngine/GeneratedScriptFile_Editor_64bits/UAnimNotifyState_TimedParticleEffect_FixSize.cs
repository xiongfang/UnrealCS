#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Timed Particle Effect Notify
	/// Allows a looping particle effect to be played in an animation that will activate
	/// at the beginning of the notify and deactivate at the end.
	/// </summary>
	public partial class UAnimNotifyState_TimedParticleEffect
	{
		static readonly int PSTemplate__Offset;
		/// <summary>The particle system to spawn for the notify state</summary>
		public UParticleSystem PSTemplate
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PSTemplate__Offset); if (v == IntPtr.Zero)return null; UParticleSystem retValue = new UParticleSystem(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PSTemplate__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PSTemplate__Offset, value._this.Get()); }
			
		}
		
		static readonly int SocketName__Offset;
		/// <summary>The socket or bone to attach the system to</summary>
		public FName SocketName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SocketName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SocketName__Offset, false);}
			
		}
		
		static readonly int LocationOffset__Offset;
		/// <summary>Offset from the socket or bone to place the particle system</summary>
		public FVector LocationOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LocationOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LocationOffset__Offset, false);}
			
		}
		
		static readonly int RotationOffset__Offset;
		/// <summary>Rotation offset from the socket or bone for the particle system</summary>
		public FRotator RotationOffset
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+RotationOffset__Offset, typeof(FRotator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotationOffset__Offset, false);}
			
		}
		
		static readonly int bDestroyAtEnd__Offset;
		/// <summary>Whether the particle system should be immediately destroyed at the end of the notify state or be allowed to finish</summary>
		public bool bDestroyAtEnd
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDestroyAtEnd__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDestroyAtEnd__Offset, 1,0,1,255);}
			
		}
		
		static readonly int PreviousPSTemplates__Offset;
		/// <summary>
		/// The following arrays are used to handle property changes during a state. Because we can't
		/// store any stateful data here we can't know which emitter is ours. The best metric we have
		/// is an emitter on our Mesh Component with the same template and socket name we have defined.
		/// Because these can change at any time we need to track previous versions when we are in an
		/// editor build. Refactor when stateful data is possible, tracking our component instead.
		/// </summary>
		public TObjectArray<UParticleSystem>  PreviousPSTemplates
		{
					get{ CheckIsValid();return new TObjectArray<UParticleSystem>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PreviousPSTemplates__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PreviousPSTemplates__Offset, false);}
			
		}
		
		static readonly int PreviousSocketNames__Offset;
		public TStructArray<FName> PreviousSocketNames
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PreviousSocketNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PreviousSocketNames__Offset, false);}
			
		}
		
		static UAnimNotifyState_TimedParticleEffect()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimNotifyState_TimedParticleEffect");
			PSTemplate__Offset=GetPropertyOffset(NativeClassPtr,"PSTemplate");
			SocketName__Offset=GetPropertyOffset(NativeClassPtr,"SocketName");
			LocationOffset__Offset=GetPropertyOffset(NativeClassPtr,"LocationOffset");
			RotationOffset__Offset=GetPropertyOffset(NativeClassPtr,"RotationOffset");
			bDestroyAtEnd__Offset=GetPropertyOffset(NativeClassPtr,"bDestroyAtEnd");
			PreviousPSTemplates__Offset=GetPropertyOffset(NativeClassPtr,"PreviousPSTemplates");
			PreviousSocketNames__Offset=GetPropertyOffset(NativeClassPtr,"PreviousSocketNames");
			
		}
		
	}
	
}
#endif
#endif
