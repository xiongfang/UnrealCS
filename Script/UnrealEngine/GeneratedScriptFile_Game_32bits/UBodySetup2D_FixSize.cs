#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBodySetup2D
	{
		static readonly int AggGeom2D__Offset;
		public FAggregateGeometry2D AggGeom2D
		{
			get{ CheckIsValid();return (FAggregateGeometry2D)Marshal.PtrToStructure(_this.Get()+AggGeom2D__Offset, typeof(FAggregateGeometry2D));}
			
		}
		
		static UBodySetup2D()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BodySetup2D");
			AggGeom2D__Offset=GetPropertyOffset(NativeClassPtr,"AggGeom2D");
			
		}
		
	}
	
}
#endif
#endif
