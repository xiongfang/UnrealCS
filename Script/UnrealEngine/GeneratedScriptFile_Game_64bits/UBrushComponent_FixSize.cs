#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBrushComponent
	{
		static readonly int Brush__Offset;
		public UModel Brush
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Brush__Offset); if (v == IntPtr.Zero)return null; UModel retValue = new UModel(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BrushBodySetup__Offset;
		public UBodySetup BrushBodySetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BrushBodySetup__Offset); if (v == IntPtr.Zero)return null; UBodySetup retValue = new UBodySetup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PrePivot__Offset;
		public FVector PrePivot
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PrePivot__Offset, typeof(FVector));}
			
		}
		
		static UBrushComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BrushComponent");
			Brush__Offset=GetPropertyOffset(NativeClassPtr,"Brush");
			BrushBodySetup__Offset=GetPropertyOffset(NativeClassPtr,"BrushBodySetup");
			PrePivot__Offset=GetPropertyOffset(NativeClassPtr,"PrePivot");
			
		}
		
	}
	
}
#endif
#endif
