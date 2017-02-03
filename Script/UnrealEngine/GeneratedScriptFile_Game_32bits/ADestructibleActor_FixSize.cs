#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ADestructibleActor
	{
		static readonly int DestructibleComponent__Offset;
		public UDestructibleComponent DestructibleComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DestructibleComponent__Offset); if (v == IntPtr.Zero)return null; UDestructibleComponent retValue = new UDestructibleComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + DestructibleComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + DestructibleComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int bAffectNavigation__Offset;
		public bool bAffectNavigation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectNavigation__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectNavigation__Offset, 1,0,1,1);}
			
		}
		
		static readonly int OnActorFracture__Offset;
		public FMulticastScriptDelegate OnActorFracture
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnActorFracture__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnActorFracture__Offset, false);}
			
		}
		
		static ADestructibleActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DestructibleActor");
			DestructibleComponent__Offset=GetPropertyOffset(NativeClassPtr,"DestructibleComponent");
			bAffectNavigation__Offset=GetPropertyOffset(NativeClassPtr,"bAffectNavigation");
			OnActorFracture__Offset=GetPropertyOffset(NativeClassPtr,"OnActorFracture");
			
		}
		
	}
	
}
#endif
#endif
