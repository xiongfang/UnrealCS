#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Utility object for moving physics objects around.</summary>
	public partial class UPhysicsHandleComponent
	{
		static readonly int GrabbedComponent__Offset;
		/// <summary>Component we are currently holding</summary>
		public UPrimitiveComponent GrabbedComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GrabbedComponent__Offset); if (v == IntPtr.Zero)return null; UPrimitiveComponent retValue = new UPrimitiveComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bSoftAngularConstraint__Offset;
		public bool bSoftAngularConstraint
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSoftAngularConstraint__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSoftAngularConstraint__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bSoftLinearConstraint__Offset;
		public bool bSoftLinearConstraint
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSoftLinearConstraint__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSoftLinearConstraint__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bInterpolateTarget__Offset;
		public bool bInterpolateTarget
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInterpolateTarget__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInterpolateTarget__Offset, 1,0,8,8);}
			
		}
		
		static readonly int LinearDamping__Offset;
		/// <summary>Linear damping of the handle spring.</summary>
		public float LinearDamping
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LinearDamping__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LinearDamping__Offset, false);}
			
		}
		
		static readonly int LinearStiffness__Offset;
		/// <summary>Linear stiffness of the handle spring</summary>
		public float LinearStiffness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LinearStiffness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LinearStiffness__Offset, false);}
			
		}
		
		static readonly int AngularDamping__Offset;
		/// <summary>Angular stiffness of the handle spring</summary>
		public float AngularDamping
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AngularDamping__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AngularDamping__Offset, false);}
			
		}
		
		static readonly int AngularStiffness__Offset;
		/// <summary>Angular stiffness of the handle spring</summary>
		public float AngularStiffness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AngularStiffness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AngularStiffness__Offset, false);}
			
		}
		
		static readonly int InterpolationSpeed__Offset;
		/// <summary>How quickly we interpolate the physics target transform</summary>
		public float InterpolationSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InterpolationSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InterpolationSpeed__Offset, false);}
			
		}
		
		static UPhysicsHandleComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PhysicsHandleComponent");
			GrabbedComponent__Offset=GetPropertyOffset(NativeClassPtr,"GrabbedComponent");
			bSoftAngularConstraint__Offset=GetPropertyOffset(NativeClassPtr,"bSoftAngularConstraint");
			bSoftLinearConstraint__Offset=GetPropertyOffset(NativeClassPtr,"bSoftLinearConstraint");
			bInterpolateTarget__Offset=GetPropertyOffset(NativeClassPtr,"bInterpolateTarget");
			LinearDamping__Offset=GetPropertyOffset(NativeClassPtr,"LinearDamping");
			LinearStiffness__Offset=GetPropertyOffset(NativeClassPtr,"LinearStiffness");
			AngularDamping__Offset=GetPropertyOffset(NativeClassPtr,"AngularDamping");
			AngularStiffness__Offset=GetPropertyOffset(NativeClassPtr,"AngularStiffness");
			InterpolationSpeed__Offset=GetPropertyOffset(NativeClassPtr,"InterpolationSpeed");
			
		}
		
	}
	
}
#endif
#endif
