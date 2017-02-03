#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class APhysicsConstraintActor
	{
		static readonly int ConstraintComp__Offset;
		public UPhysicsConstraintComponent ConstraintComp
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintComp__Offset); if (v == IntPtr.Zero)return null; UPhysicsConstraintComponent retValue = new UPhysicsConstraintComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ConstraintComp__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ConstraintComp__Offset, value._this.Get()); }
			
		}
		
		static readonly int ConstraintActor1__Offset;
		public AActor ConstraintActor1
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintActor1__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ConstraintActor2__Offset;
		public AActor ConstraintActor2
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintActor2__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bDisableCollision__Offset;
		public bool bDisableCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableCollision__Offset, 1, 0, 1, 1);}
			
		}
		
		static APhysicsConstraintActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PhysicsConstraintActor");
			ConstraintComp__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintComp");
			ConstraintActor1__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintActor1");
			ConstraintActor2__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintActor2");
			bDisableCollision__Offset=GetPropertyOffset(NativeClassPtr,"bDisableCollision");
			
		}
		
	}
	
}
#endif
#endif
