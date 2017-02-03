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
