#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPhysicsConstraintComponent
	{
		static readonly int ConstraintActor1__Offset;
		public AActor ConstraintActor1
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintActor1__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ConstraintActor1__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ConstraintActor1__Offset, value._this.Get()); }
			
		}
		
		static readonly int ComponentName1__Offset;
		public FConstrainComponentPropName ComponentName1
		{
			get{ CheckIsValid();return (FConstrainComponentPropName)Marshal.PtrToStructure(_this.Get()+ComponentName1__Offset, typeof(FConstrainComponentPropName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ComponentName1__Offset, false);}
			
		}
		
		static readonly int ConstraintActor2__Offset;
		public AActor ConstraintActor2
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintActor2__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ConstraintActor2__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ConstraintActor2__Offset, value._this.Get()); }
			
		}
		
		static readonly int ComponentName2__Offset;
		public FConstrainComponentPropName ComponentName2
		{
			get{ CheckIsValid();return (FConstrainComponentPropName)Marshal.PtrToStructure(_this.Get()+ComponentName2__Offset, typeof(FConstrainComponentPropName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ComponentName2__Offset, false);}
			
		}
		
		static readonly int ConstraintSetup__Offset;
		public UPhysicsConstraintTemplate ConstraintSetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintSetup__Offset); if (v == IntPtr.Zero)return null; UPhysicsConstraintTemplate retValue = new UPhysicsConstraintTemplate(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int OnConstraintBroken__Offset;
		public FMulticastScriptDelegate OnConstraintBroken
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnConstraintBroken__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnConstraintBroken__Offset, false);}
			
		}
		
		static readonly int ConstraintInstance__Offset;
		public FConstraintInstance ConstraintInstance
		{
			get{ CheckIsValid();return (FConstraintInstance)Marshal.PtrToStructure(_this.Get()+ConstraintInstance__Offset, typeof(FConstraintInstance));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstraintInstance__Offset, false);}
			
		}
		
		static UPhysicsConstraintComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PhysicsConstraintComponent");
			ConstraintActor1__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintActor1");
			ComponentName1__Offset=GetPropertyOffset(NativeClassPtr,"ComponentName1");
			ConstraintActor2__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintActor2");
			ComponentName2__Offset=GetPropertyOffset(NativeClassPtr,"ComponentName2");
			ConstraintSetup__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintSetup");
			OnConstraintBroken__Offset=GetPropertyOffset(NativeClassPtr,"OnConstraintBroken");
			ConstraintInstance__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintInstance");
			
		}
		
	}
	
}
#endif
#endif
