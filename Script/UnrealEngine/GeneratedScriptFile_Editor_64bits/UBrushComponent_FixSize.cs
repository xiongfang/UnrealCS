#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A brush component defines a shape that can be modified within the editor. They are used both as part of BSP building, and for volumes.
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Actors/Volumes
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Actors/Brushes
	/// </summary>
	public partial class UBrushComponent
	{
		static readonly int Brush__Offset;
		public UModel Brush
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Brush__Offset); if (v == IntPtr.Zero)return null; UModel retValue = new UModel(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BrushBodySetup__Offset;
		/// <summary>Description of collision</summary>
		public UBodySetup BrushBodySetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BrushBodySetup__Offset); if (v == IntPtr.Zero)return null; UBodySetup retValue = new UBodySetup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PrePivot__Offset;
		/// <summary>Local space translation</summary>
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
