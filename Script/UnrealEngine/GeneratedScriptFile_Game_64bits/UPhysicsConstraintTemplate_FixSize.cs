#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPhysicsConstraintTemplate
	{
		static readonly int DefaultInstance__Offset;
		public FConstraintInstance DefaultInstance
		{
			get{ CheckIsValid();return (FConstraintInstance)Marshal.PtrToStructure(_this.Get()+DefaultInstance__Offset, typeof(FConstraintInstance));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultInstance__Offset, false);}
			
		}
		
		static readonly int ProfileHandles__Offset;
		public TStructArray<FPhysicsConstraintProfileHandle> ProfileHandles
		{
			get{ CheckIsValid();return new TStructArray<FPhysicsConstraintProfileHandle>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ProfileHandles__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ProfileHandles__Offset, false);}
			
		}
		
		static readonly int DefaultProfile__Offset;
		public FConstraintProfileProperties DefaultProfile
		{
			get{ CheckIsValid();return (FConstraintProfileProperties)Marshal.PtrToStructure(_this.Get()+DefaultProfile__Offset, typeof(FConstraintProfileProperties));}
			
		}
		
		static UPhysicsConstraintTemplate()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PhysicsConstraintTemplate");
			DefaultInstance__Offset=GetPropertyOffset(NativeClassPtr,"DefaultInstance");
			ProfileHandles__Offset=GetPropertyOffset(NativeClassPtr,"ProfileHandles");
			DefaultProfile__Offset=GetPropertyOffset(NativeClassPtr,"DefaultProfile");
			
		}
		
	}
	
}
#endif
#endif
