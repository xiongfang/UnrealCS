#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Helper structure for displaying the parameter.</summary>
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FEmitterDynamicParameter
	{
		/// <summary>The parameter name - from the material DynamicParameter expression. READ-ONLY</summary>
		[FieldOffset(0)]
		public FName ParamName;
		/// <summary>If true, use the EmitterTime to retrieve the value, otherwise use Particle RelativeTime.</summary>
		public bool bUseEmitterTime
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 1); } }}
			
		}
		/// <summary>If true, only set the value at spawn time of the particle, otherwise update each frame.</summary>
		public bool bSpawnTimeOnly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Where to get the parameter value from.</summary>
		[FieldOffset(16)]
		public EEmitterDynamicParameterValue ValueMethod;
		/// <summary>If true, scale the velocity value selected in ValueMethod by the evaluated ParamValue.</summary>
		public bool bScaleVelocityByParamValue
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 1, 1); } }}
			
		}
		/// <summary>The distriubtion for the parameter value.</summary>
		[FieldOffset(24)]
		public FRawDistributionFloat ParamValue;
		
	}
	
}
#endif
#endif
