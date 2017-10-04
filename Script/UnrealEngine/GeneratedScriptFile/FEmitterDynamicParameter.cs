using System;
namespace UnrealEngine
{
	/// <summary>Helper structure for displaying the parameter.</summary>
	public partial struct FEmitterDynamicParameter
	{
		/// <summary>The parameter name - from the material DynamicParameter expression. READ-ONLY</summary>
		public FName ParamName;
		/// <summary>If true, use the EmitterTime to retrieve the value, otherwise use Particle RelativeTime.</summary>
		public bool bUseEmitterTime;
		/// <summary>If true, only set the value at spawn time of the particle, otherwise update each frame.</summary>
		public bool bSpawnTimeOnly;
		/// <summary>Where to get the parameter value from.</summary>
		public EEmitterDynamicParameterValue ValueMethod;
		/// <summary>If true, scale the velocity value selected in ValueMethod by the evaluated ParamValue.</summary>
		public bool bScaleVelocityByParamValue;
		/// <summary>The distriubtion for the parameter value.</summary>
		public FRawDistributionFloat ParamValue;
		
	}
	
}
