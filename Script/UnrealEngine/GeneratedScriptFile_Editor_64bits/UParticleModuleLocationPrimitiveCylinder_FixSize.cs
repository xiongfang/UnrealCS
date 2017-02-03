#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationPrimitiveCylinder
	{
		static readonly int RadialVelocity__Offset;
		/// <summary>If true, get the particle velocity form the radial distance inside the primitive.</summary>
		public bool RadialVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), RadialVelocity__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), RadialVelocity__Offset, 1,0,1,1);}
			
		}
		
		static readonly int StartRadius__Offset;
		/// <summary>The radius of the cylinder.</summary>
		public FRawDistributionFloat StartRadius
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+StartRadius__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartRadius__Offset, false);}
			
		}
		
		static readonly int StartHeight__Offset;
		/// <summary>The height of the cylinder, centered about the location.</summary>
		public FRawDistributionFloat StartHeight
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+StartHeight__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartHeight__Offset, false);}
			
		}
		
		static readonly int HeightAxis__Offset;
		/// <summary>
		/// Determine particle particle system axis that should represent the height of the cylinder.
		/// Can be one of the following:
		///   PMLPC_HEIGHTAXIS_X - Orient the height along the particle system X-axis.
		///   PMLPC_HEIGHTAXIS_Y - Orient the height along the particle system Y-axis.
		///   PMLPC_HEIGHTAXIS_Z - Orient the height along the particle system Z-axis.
		/// </summary>
		public CylinderHeightAxis HeightAxis
		{
			get{ CheckIsValid();return (CylinderHeightAxis)Marshal.PtrToStructure(_this.Get()+HeightAxis__Offset, typeof(CylinderHeightAxis));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HeightAxis__Offset, false);}
			
		}
		
		static UParticleModuleLocationPrimitiveCylinder()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLocationPrimitiveCylinder");
			RadialVelocity__Offset=GetPropertyOffset(NativeClassPtr,"RadialVelocity");
			StartRadius__Offset=GetPropertyOffset(NativeClassPtr,"StartRadius");
			StartHeight__Offset=GetPropertyOffset(NativeClassPtr,"StartHeight");
			HeightAxis__Offset=GetPropertyOffset(NativeClassPtr,"HeightAxis");
			
		}
		
	}
	
}
#endif
#endif
