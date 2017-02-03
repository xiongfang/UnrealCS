#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AEmitter
	{
		static readonly int ParticleSystemComponent__Offset;
		public UParticleSystemComponent ParticleSystemComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ParticleSystemComponent__Offset); if (v == IntPtr.Zero)return null; UParticleSystemComponent retValue = new UParticleSystemComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ParticleSystemComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ParticleSystemComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int bDestroyOnSystemFinish__Offset;
		public bool bDestroyOnSystemFinish
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDestroyOnSystemFinish__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bPostUpdateTickGroup__Offset;
		public bool bPostUpdateTickGroup
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPostUpdateTickGroup__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPostUpdateTickGroup__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bCurrentlyActive__Offset;
		public bool bCurrentlyActive
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCurrentlyActive__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int OnParticleSpawn__Offset;
		public FMulticastScriptDelegate OnParticleSpawn
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnParticleSpawn__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnParticleSpawn__Offset, false);}
			
		}
		
		static readonly int OnParticleBurst__Offset;
		public FMulticastScriptDelegate OnParticleBurst
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnParticleBurst__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnParticleBurst__Offset, false);}
			
		}
		
		static readonly int OnParticleDeath__Offset;
		public FMulticastScriptDelegate OnParticleDeath
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnParticleDeath__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnParticleDeath__Offset, false);}
			
		}
		
		static readonly int OnParticleCollide__Offset;
		public FMulticastScriptDelegate OnParticleCollide
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnParticleCollide__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnParticleCollide__Offset, false);}
			
		}
		
		static AEmitter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Emitter");
			ParticleSystemComponent__Offset=GetPropertyOffset(NativeClassPtr,"ParticleSystemComponent");
			bDestroyOnSystemFinish__Offset=GetPropertyOffset(NativeClassPtr,"bDestroyOnSystemFinish");
			bPostUpdateTickGroup__Offset=GetPropertyOffset(NativeClassPtr,"bPostUpdateTickGroup");
			bCurrentlyActive__Offset=GetPropertyOffset(NativeClassPtr,"bCurrentlyActive");
			OnParticleSpawn__Offset=GetPropertyOffset(NativeClassPtr,"OnParticleSpawn");
			OnParticleBurst__Offset=GetPropertyOffset(NativeClassPtr,"OnParticleBurst");
			OnParticleDeath__Offset=GetPropertyOffset(NativeClassPtr,"OnParticleDeath");
			OnParticleCollide__Offset=GetPropertyOffset(NativeClassPtr,"OnParticleCollide");
			
		}
		
	}
	
}
#endif
#endif
