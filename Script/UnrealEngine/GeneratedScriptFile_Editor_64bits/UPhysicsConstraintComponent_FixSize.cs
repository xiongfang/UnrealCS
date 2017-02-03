#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>This is effectively a joint that allows you to connect 2 rigid bodies together. You can create different types of joints using the various parameters of this component.</summary>
	public partial class UPhysicsConstraintComponent
	{
		static readonly int ConstraintActor1__Offset;
		/// <summary>Pointer to first Actor to constrain.</summary>
		public AActor ConstraintActor1
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintActor1__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ConstraintActor1__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ConstraintActor1__Offset, value._this.Get()); }
			
		}
		
		static readonly int ComponentName1__Offset;
		/// <summary>
		/// Name of first component property to constrain. If Actor1 is NULL, will look within Owner.
		/// If this is NULL, will use RootComponent of Actor1
		/// </summary>
		public FConstrainComponentPropName ComponentName1
		{
			get{ CheckIsValid();return (FConstrainComponentPropName)Marshal.PtrToStructure(_this.Get()+ComponentName1__Offset, typeof(FConstrainComponentPropName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ComponentName1__Offset, false);}
			
		}
		
		static readonly int ConstraintActor2__Offset;
		/// <summary>Pointer to second Actor to constrain.</summary>
		public AActor ConstraintActor2
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintActor2__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ConstraintActor2__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ConstraintActor2__Offset, value._this.Get()); }
			
		}
		
		static readonly int ComponentName2__Offset;
		/// <summary>
		/// Name of second component property to constrain. If Actor2 is NULL, will look within Owner.
		/// If this is NULL, will use RootComponent of Actor2
		/// </summary>
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
		/// <summary>Notification when constraint is broken.</summary>
		public FMulticastScriptDelegate OnConstraintBroken
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnConstraintBroken__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnConstraintBroken__Offset, false);}
			
		}
		
		static readonly int ConstraintInstance__Offset;
		/// <summary>All constraint settings</summary>
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
