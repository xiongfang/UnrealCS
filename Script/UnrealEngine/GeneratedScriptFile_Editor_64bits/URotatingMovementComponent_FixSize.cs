#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Performs continuous rotation of a component at a specific rotation rate.
	/// Rotation can optionally be offset around a pivot point.
	/// Collision testing is not performed during movement.
	/// </summary>
	public partial class URotatingMovementComponent
	{
		static readonly int RotationRate__Offset;
		/// <summary>How fast to update roll/pitch/yaw of the component we update.</summary>
		public FRotator RotationRate
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+RotationRate__Offset, typeof(FRotator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotationRate__Offset, false);}
			
		}
		
		static readonly int PivotTranslation__Offset;
		/// <summary>
		/// Translation of pivot point around which we rotate, relative to current rotation.
		/// For instance, with PivotTranslation set to (X=+100, Y=0, Z=0), rotation will occur
		/// around the point +100 units along the local X axis from the center of the object,
		/// rather than around the object's origin (the default).
		/// </summary>
		public FVector PivotTranslation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PivotTranslation__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PivotTranslation__Offset, false);}
			
		}
		
		static readonly int bRotationInLocalSpace__Offset;
		/// <summary>Whether rotation is applied in local or world space.</summary>
		public bool bRotationInLocalSpace
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRotationInLocalSpace__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRotationInLocalSpace__Offset, 1,0,1,1);}
			
		}
		
		static URotatingMovementComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("RotatingMovementComponent");
			RotationRate__Offset=GetPropertyOffset(NativeClassPtr,"RotationRate");
			PivotTranslation__Offset=GetPropertyOffset(NativeClassPtr,"PivotTranslation");
			bRotationInLocalSpace__Offset=GetPropertyOffset(NativeClassPtr,"bRotationInLocalSpace");
			
		}
		
	}
	
}
#endif
#endif
