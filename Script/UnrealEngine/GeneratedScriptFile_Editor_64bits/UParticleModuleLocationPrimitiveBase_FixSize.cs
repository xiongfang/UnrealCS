#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationPrimitiveBase
	{
		static readonly int Positive_X__Offset;
		/// <summary>Whether the positive X axis is valid for spawning.</summary>
		public bool Positive_X
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Positive_X__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Positive_X__Offset, 1,0,1,1);}
			
		}
		
		static readonly int Positive_Y__Offset;
		/// <summary>Whether the positive Y axis is valid for spawning.</summary>
		public bool Positive_Y
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Positive_Y__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Positive_Y__Offset, 1,0,2,2);}
			
		}
		
		static readonly int Positive_Z__Offset;
		/// <summary>Whether the positive Z axis is valid for spawning.</summary>
		public bool Positive_Z
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Positive_Z__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Positive_Z__Offset, 1,0,4,4);}
			
		}
		
		static readonly int Negative_X__Offset;
		/// <summary>Whether the negative X axis is valid for spawning.</summary>
		public bool Negative_X
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Negative_X__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Negative_X__Offset, 1,0,8,8);}
			
		}
		
		static readonly int Negative_Y__Offset;
		/// <summary>Whether the negative Y axis is valid for spawning.</summary>
		public bool Negative_Y
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Negative_Y__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Negative_Y__Offset, 1,0,16,16);}
			
		}
		
		static readonly int Negative_Z__Offset;
		/// <summary>Whether the negative Zaxis is valid for spawning.</summary>
		public bool Negative_Z
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Negative_Z__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Negative_Z__Offset, 1,0,32,32);}
			
		}
		
		static readonly int SurfaceOnly__Offset;
		/// <summary>Whether particles will only spawn on the surface of the primitive.</summary>
		public bool SurfaceOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), SurfaceOnly__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), SurfaceOnly__Offset, 1,0,64,64);}
			
		}
		
		static readonly int Velocity__Offset;
		/// <summary>Whether the particle should get its velocity from the position within the primitive.</summary>
		public bool Velocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Velocity__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Velocity__Offset, 1,0,128,128);}
			
		}
		
		static readonly int VelocityScale__Offset;
		/// <summary>The scale applied to the velocity. (Only used if 'Velocity' is checked).</summary>
		public FRawDistributionFloat VelocityScale
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+VelocityScale__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VelocityScale__Offset, false);}
			
		}
		
		static readonly int StartLocation__Offset;
		/// <summary>The location of the bounding primitive relative to the position of the emitter.</summary>
		public FRawDistributionVector StartLocation
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+StartLocation__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartLocation__Offset, false);}
			
		}
		
		static UParticleModuleLocationPrimitiveBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLocationPrimitiveBase");
			Positive_X__Offset=GetPropertyOffset(NativeClassPtr,"Positive_X");
			Positive_Y__Offset=GetPropertyOffset(NativeClassPtr,"Positive_Y");
			Positive_Z__Offset=GetPropertyOffset(NativeClassPtr,"Positive_Z");
			Negative_X__Offset=GetPropertyOffset(NativeClassPtr,"Negative_X");
			Negative_Y__Offset=GetPropertyOffset(NativeClassPtr,"Negative_Y");
			Negative_Z__Offset=GetPropertyOffset(NativeClassPtr,"Negative_Z");
			SurfaceOnly__Offset=GetPropertyOffset(NativeClassPtr,"SurfaceOnly");
			Velocity__Offset=GetPropertyOffset(NativeClassPtr,"Velocity");
			VelocityScale__Offset=GetPropertyOffset(NativeClassPtr,"VelocityScale");
			StartLocation__Offset=GetPropertyOffset(NativeClassPtr,"StartLocation");
			
		}
		
	}
	
}
#endif
#endif
