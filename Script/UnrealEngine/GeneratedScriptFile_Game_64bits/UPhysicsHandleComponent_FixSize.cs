#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPhysicsHandleComponent
	{
		static readonly int GrabbedComponent__Offset;
		public UPrimitiveComponent GrabbedComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GrabbedComponent__Offset); if (v == IntPtr.Zero)return null; UPrimitiveComponent retValue = new UPrimitiveComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LinearDamping__Offset;
		public float LinearDamping
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LinearDamping__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LinearDamping__Offset, false);}
			
		}
		
		static readonly int LinearStiffness__Offset;
		public float LinearStiffness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LinearStiffness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LinearStiffness__Offset, false);}
			
		}
		
		static readonly int AngularDamping__Offset;
		public float AngularDamping
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AngularDamping__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AngularDamping__Offset, false);}
			
		}
		
		static readonly int AngularStiffness__Offset;
		public float AngularStiffness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AngularStiffness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AngularStiffness__Offset, false);}
			
		}
		
		static readonly int InterpolationSpeed__Offset;
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
