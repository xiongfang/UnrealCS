using System;
namespace UnrealEngine
{
	/// <summary>
	/// Struct used for storing one per-instance named parameter for this AudioComponent.
	/// Certain nodes in the SoundCue may reference parameters by name so they can be adjusted per-instance.
	/// </summary>
	public partial struct FAudioComponentParam
	{
		/// <summary>Name of the parameter</summary>
		public FName ParamName;
		/// <summary>Value of the parameter when used as a float</summary>
		public float FloatParam;
		/// <summary>Value of the parameter when used as a boolean</summary>
		public bool BoolParam;
		/// <summary>Value of the parameter when used as an integer</summary>
		public int IntParam;
		/// <summary>Value of the parameter when used as a sound wave</summary>
		public USoundWave SoundWaveParam;
		
	}
	
}
